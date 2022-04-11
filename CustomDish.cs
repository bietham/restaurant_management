using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.DataAcess;
using System.Data.SqlClient;


namespace DeliveryApp
{
    public partial class CustomDish : Form
    {
        private DBClient _dbclient;
        public Custom C_Dish;
        public CustomDish()
        {
            InitializeComponent();
            _dbclient = new DBClient();

            C_Dish = new Custom();
        }

        private void Dishes_Button_Click(object sender, EventArgs e)
        {
            _dbclient.OpenConnection();

            var queryString = "SELECT [id], [name] FROM [DeliveryDB].[dbo].[Dishes]";

            SqlCommand command = new SqlCommand(queryString, _dbclient.conn);


            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();

            }
            else
            {

                while (reader.Read())
                {

                    Products_Table.Rows.Add(reader.GetInt32(0), reader.GetString(1));

                }
                reader.Close();
                Products_Table.Refresh();
            }
        }

        private void Products_Table_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Base_Table.Rows.Clear();
            Removed_Table.Rows.Clear();
            int Id = e.RowIndex;


            try
            {

                var queryString = $"SELECT di.[ingredient_id], i.[name] FROM [DeliveryDB].[dbo].[IngredientToDish] di join [DeliveryDB].[dbo].[Ingredients] i on i.[id] = di.[ingredient_id] WHERE di.[dish_id] = {Products_Table.Rows[Id].Cells[0].Value}";

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

                        Base_Table.Rows.Add(reader.GetInt32(0), reader.GetString(1));

                    }
                    reader.Close();
                    Base_Table.Refresh();
                }
            }
            catch
            {
                return;
            }
            try
            {
                New_Table.Rows.Clear();

                var queryStringIn = $"SELECT [id], [name] FROM [DeliveryDB].[dbo].[Ingredients]";

                SqlCommand command = new SqlCommand(queryStringIn, _dbclient.conn);

                SqlDataReader readerIn = command.ExecuteReader();

                if (!readerIn.HasRows)
                {
                    readerIn.Close();
                    return;
                }
                else
                {

                    while (readerIn.Read())
                    {

                        New_Table.Rows.Add(readerIn.GetInt32(0), readerIn.GetString(1));

                    }
                    readerIn.Close();
                    Base_Table.Refresh();
                }
            }
            catch
            {
                return;
            }
        }

        private void Base_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            Base_Table.Columns["Remove_Button"].Index) return;

            int Id = e.RowIndex;



            Removed_Table.Rows.Add(Base_Table.Rows[Id].Cells[0].Value, Base_Table.Rows[Id].Cells[1].Value);

            Base_Table.Rows.Remove(Base_Table.Rows[Id]);
        }

        private void Removed_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            Removed_Table.Columns["Return_Button"].Index) return;

            int Id = e.RowIndex;



            Base_Table.Rows.Add(Removed_Table.Rows[Id].Cells[0].Value, Removed_Table.Rows[Id].Cells[1].Value);
            Removed_Table.Rows.Remove(Removed_Table.Rows[Id]);
        }
    }
}
