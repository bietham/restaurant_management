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
    public partial class KitchenForm : Form
    {

        private DBClient _dbclient;
        public KitchenForm()
        {
            InitializeComponent();
            _dbclient = new DBClient();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            

        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            _dbclient.OpenConnection();

            var queryString = "SELECT [id], [ordered_at], [comments] FROM [DeliveryDB].[dbo].[Orders] WHERE [status_id] = 1";

            SqlCommand command = new SqlCommand(queryString, _dbclient.conn);


            SqlDataReader reader = command.ExecuteReader();
            Ordered_Table.Rows.Clear();
            Preparation_Table.Rows.Clear();
            if (!reader.HasRows)
            {
                reader.Close();
                
            }
            else
            {

                while (reader.Read())
                {

                    Ordered_Table.Rows.Add(reader.GetInt32(0), reader.GetSqlDateTime(1), "Ordered", reader.GetString(2));

                }
                reader.Close();
                Ordered_Table.Refresh();
            }
            var queryString2 = "SELECT [id], [ordered_at], [comments] FROM [DeliveryDB].[dbo].[Orders] WHERE [status_id] = 2";

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

                    Preparation_Table.Rows.Add(reader2.GetInt32(0), reader2.GetSqlDateTime(1), "In Preparation", reader2.GetString(2));

                }
                reader2.Close();
                Preparation_Table.Refresh();
            }

        }

        private void Ordered_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.ColumnIndex !=
            Ordered_Table.Columns["Assign_Cook"].Index) return;

            Preparation_Table.Rows.Clear();

            int Id = e.RowIndex;

            var queryString = $"UPDATE[DeliveryDB].[dbo].[Orders] SET[status_id] = 2, [cook_id] = {CurrentUser.UserInfo.Id} WHERE[Id] = {Ordered_Table.Rows[Id].Cells[0].Value}";


            SqlCommand command = new SqlCommand(queryString, _dbclient.conn);
            var rowsAffected = command.ExecuteNonQuery();

            Ordered_Table.Rows.Remove(Ordered_Table.Rows[Id]);
            Ordered_Table.Refresh();

            var queryString2 = "SELECT [id], [ordered_at], [comments] FROM [DeliveryDB].[dbo].[Orders] WHERE [status_id] = 2";

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

                    Preparation_Table.Rows.Add(reader2.GetInt32(0), reader2.GetSqlDateTime(1), "In Preparation", reader2.GetString(2));

                }
                reader2.Close();
                Preparation_Table.Refresh();
            }


        }

        private void Ordered_Table_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dishes_Table.Rows.Clear();
            int Id = e.RowIndex;

            try
            {

                var queryString = $"SELECT do.[dish_id], d.[name], do.[quantity] FROM [DeliveryDB].[dbo].[OrderItems] do join [DeliveryDB].[dbo].[Dishes] d on d.[id] = do.[dish_id] WHERE do.[order_id] = {Ordered_Table.Rows[Id].Cells[0].Value}";

                SqlCommand command = new SqlCommand(queryString, _dbclient.conn);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();
                    return;
                }
                else
                {

                    while (reader.Read())
                    {

                        Dishes_Table.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));

                    }
                    reader.Close();
                    Dishes_Table.Refresh();
                }

            }
            catch
            {
                return;
            }

        }

        private void Dishes_Table_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Ingredients_Table.Rows.Clear();
            int Id = e.RowIndex;


            try
            {

                var queryString = $"	SELECT di.[ingredient_id], i.[name] FROM [DeliveryDB].[dbo].[IngredientToDish] di join [DeliveryDB].[dbo].[Ingredients] i on i.[id] = di.[ingredient_id] WHERE di.[dish_id] = {Dishes_Table.Rows[Id].Cells[0].Value}";

                SqlCommand command = new SqlCommand(queryString, _dbclient.conn);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();
                    return;
                }
                else
                {

                    while (reader.Read())
                    {

                        Ingredients_Table.Rows.Add(reader.GetInt32(0), reader.GetString(1));

                    }
                    reader.Close();
                    Ingredients_Table.Refresh();
                }
            }
            catch
            {
                return;
            }


        }

        private void Preparation_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.ColumnIndex !=
            Preparation_Table.Columns["Complete_Order"].Index) return;


            int Id = e.RowIndex;

            var queryString = $"UPDATE[DeliveryDB].[dbo].[Orders] SET[status_id] = 3, [cook_id] = {CurrentUser.UserInfo.Id} WHERE[Id] = {Preparation_Table.Rows[Id].Cells[0].Value}";


            SqlCommand command = new SqlCommand(queryString, _dbclient.conn);
            var rowsAffected = command.ExecuteNonQuery();

            Preparation_Table.Rows.Remove(Preparation_Table.Rows[Id]);
            Preparation_Table.Refresh();

            

        }

        private void Preparation_Table_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dishes_Table.Rows.Clear();
            Ingredients_Table.Rows.Clear();
            int Id = e.RowIndex;

            try
            {

                var queryString = $"SELECT do.[dish_id], d.[name], do.[quantity] FROM [DeliveryDB].[dbo].[OrderItems] do join [DeliveryDB].[dbo].[Dishes] d on d.[id] = do.[dish_id] WHERE do.[order_id] = {Preparation_Table.Rows[Id].Cells[0].Value}";

                SqlCommand command = new SqlCommand(queryString, _dbclient.conn);

                SqlDataReader prep_reader = command.ExecuteReader();

                if (!prep_reader.HasRows)
                {
                    prep_reader.Close();
                    return;
                }
                else
                {

                    while (prep_reader.Read())
                    {

                        Dishes_Table.Rows.Add(prep_reader.GetInt32(0), prep_reader.GetString(1), prep_reader.GetInt32(2));

                    }
                    prep_reader.Close();
                    Dishes_Table.Refresh();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
