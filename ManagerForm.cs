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
    public partial class ManagerForm : Form
    {
        private DBClient _dbclient;
        public ManagerForm()
        {
            InitializeComponent();

            _dbclient = new DBClient();

            
            }
        
        int Id;
        double Quantity;
        private void OrderForm_Load(object sender, EventArgs e)
        {


        }

        private void Fill_Button_Click(object sender, EventArgs e)
        {
            _dbclient.OpenConnection();

            var queryString = "SELECT o.[id], TRIM(o.[name]), TRIM(o.[phone]), TRIM(o.[address]), TRIM(s.[name]) as status FROM [DeliveryDB].[dbo].[Orders] o join [DeliveryDB].[dbo].[Statuses] s on o.status_id = s.id";

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

                    Products_Table.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

                }
                reader.Close();
                Products_Table.Refresh();
            }
        }
    }
}
