using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using DeliveryApp.DataAcess;
namespace DeliveryApp
{
    public partial class DeliveryForm : Form
    {
        private DBClient _dbclient;
        public DeliveryForm()
        {
            InitializeComponent();
            _dbclient = new DBClient();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            _dbclient.OpenConnection();

            var queryString = "SELECT [id], [ordered_at], [name], [address] FROM [DeliveryDB].[dbo].[Orders] WHERE [status_id] = 3";

            SqlCommand command = new SqlCommand(queryString, _dbclient.conn);

            SqlDataReader reader = command.ExecuteReader();
            Delivery_Table.Rows.Clear();
            In_Delivery_Table.Rows.Clear();
            if (!reader.HasRows)
            {
                reader.Close();
                
            }
            else
            {

                while (reader.Read())
                {

                    Delivery_Table.Rows.Add(reader.GetInt32(0), reader.GetSqlDateTime(1), reader.GetString(2), reader.GetString(3));

                }
                reader.Close();
                Delivery_Table.Refresh();
            }
            var queryString2 = "SELECT [id], [ordered_at], [name], [address] FROM [DeliveryDB].[dbo].[Orders] WHERE [status_id] = 4";

            SqlCommand command2 = new SqlCommand(queryString2, _dbclient.conn);


            SqlDataReader reader2 = command2.ExecuteReader();

            if (!reader2.HasRows)
            {
                reader2.Close();
                return;
            }
            else
            {

                while (reader2.Read())
                {

                    In_Delivery_Table.Rows.Add(reader2.GetInt32(0), reader2.GetSqlDateTime(1), reader2.GetString(2), reader2.GetString(3));

                }
                reader2.Close();
                In_Delivery_Table.Refresh();
            }
        }

        private void Delivery_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            Delivery_Table.Columns["Accept_Button"].Index) return;

            In_Delivery_Table.Rows.Clear();

            int Id = e.RowIndex;

            var queryString = $"UPDATE[DeliveryDB].[dbo].[Orders] SET[status_id] = 4, [courier_id] = {CurrentUser.UserInfo.Id} WHERE[Id] = {Delivery_Table.Rows[Id].Cells[0].Value}";


            SqlCommand command = new SqlCommand(queryString, _dbclient.conn);
            var rowsAffected = command.ExecuteNonQuery();

            Delivery_Table.Rows.Remove(Delivery_Table.Rows[Id]);
            Delivery_Table.Refresh();

            var queryString2 = "SELECT [id], [ordered_at], [comments] FROM [DeliveryDB].[dbo].[Orders] WHERE [status_id] = 4";

            SqlCommand command2 = new SqlCommand(queryString2, _dbclient.conn);


            SqlDataReader reader2 = command2.ExecuteReader();

            if (!reader2.HasRows)
            {
                reader2.Close();
                return;
            }
            else
            {

                while (reader2.Read())
                {

                    In_Delivery_Table.Rows.Add(reader2.GetInt32(0), reader2.GetSqlDateTime(1), "In Preparation", reader2.GetString(2));

                }
                reader2.Close();
                In_Delivery_Table.Refresh();
            }
        }

        private void In_Delivery_Table_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Id = e.RowIndex;

            try
            {

                var queryString = $"SELECT SUM(d.[price] * do.[quantity]) FROM[DeliveryDB].[dbo].[OrderItems] do join[DeliveryDB].[dbo].[Dishes] d on d.[id] = do.[dish_id] WHERE do.[order_id] = {In_Delivery_Table.Rows[Id].Cells[0].Value}";

                SqlCommand command = new SqlCommand(queryString, _dbclient.conn);


                

                var reader = command.ExecuteScalar();

                var Payment = Convert.ToDouble(reader);

                ID_Field.Text = In_Delivery_Table.Rows[Id].Cells[0].Value.ToString();
                Payment_Field.Text = Payment.ToString();

                ID_Field.Refresh();
                Payment_Field.Refresh();
            }
            catch
            {
                return;
            }


        }

        private void Checkout_Button_Click(object sender, EventArgs e)
        {
            if (ID_Field.Text == "")
            {
                return;
            }
            else
            {

                var insertString = $"INSERT INTO [DeliveryDB].[dbo].[Transactions] ([amount], [date]) VALUES ({Payment_Field.Text}, @date) ";
                var getIdString = "SELECT TOP(1) [Id] FROM [Transactions] ORDER BY [Id] DESC";
                

                SqlCommand command = new SqlCommand(insertString, _dbclient.conn);
                command.Parameters.Add("@date", SqlDbType.DateTime);
                command.Parameters["@date"].Value = DateTime.Now.ToString("s");

                var rowsAffected = command.ExecuteNonQuery();

                SqlCommand command_get = new SqlCommand(getIdString, _dbclient.conn);

                var reader = command_get.ExecuteScalar();

                var result = (int?)reader;

                var updateString = $"UPDATE[DeliveryDB].[dbo].[Orders] SET [trans_id] = @trans_id, [status_id] = 5, [delivered_at] = @delivered_at WHERE[Id] = @Id";

                SqlCommand command_update = new SqlCommand(updateString, _dbclient.conn);

                command_update.Parameters.Add("@delivered_at", SqlDbType.DateTime);
                command_update.Parameters["@delivered_at"].Value = DateTime.Now.ToString("s");
                command_update.Parameters.Add("@trans_id", SqlDbType.Int);
                command_update.Parameters["@trans_id"].Value = Convert.ToInt32(result);
                command_update.Parameters.Add("@Id", SqlDbType.Int);
                command_update.Parameters["@Id"].Value = Convert.ToInt32(ID_Field.Text);

                var rowsAffected2 = command_update.ExecuteNonQuery();

                var queryString2 = "SELECT [id], [ordered_at], [comments] FROM [DeliveryDB].[dbo].[Orders] WHERE [status_id] = 4";

                In_Delivery_Table.Rows.Clear();

                SqlCommand command2 = new SqlCommand(queryString2, _dbclient.conn);

                SqlDataReader reader2 = command2.ExecuteReader();

                if (!reader2.HasRows)
                {
                    reader2.Close();
                    return;
                }
                else
                {

                    while (reader2.Read())
                    {

                        In_Delivery_Table.Rows.Add(reader2.GetInt32(0), reader2.GetSqlDateTime(1), "In Preparation", reader2.GetString(2));

                    }
                    reader2.Close();
                    In_Delivery_Table.Refresh();
                }

            }
        }
    }
}
