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
    public partial class OrderForm : Form
    {
        private DBClient _dbclient;
        public OrderForm()
        {
            InitializeComponent();

            _dbclient = new DBClient();

            
            }
        
        int Id;
        double Quantity;
        private void OrderForm_Load(object sender, EventArgs e)
        {


        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(ID_Field.Text);
                Quantity = Convert.ToDouble(Quantity_Field.Text);
            }
            catch
            {
                return;
            }
            int count = Products_Table.Rows.Count;

            Products_Table.Refresh();
            

            if (Id <= 0 | Quantity <= 0 | Id >= count)
            {
                return;
            }
            else
            {
                string Name = Products_Table.Rows[Id-1].Cells[1].Value.ToString();
                double Price = Convert.ToDouble(Products_Table.Rows[Id - 1].Cells[2].Value);

                Order_Table.Rows.Add(Id, Name, Quantity, (Price * Quantity));
                Total_Price.Text = Convert.ToString(Convert.ToDouble(Total_Price.Text) + Price * Quantity);

                Order_Table.Refresh();
                Total_Price.Refresh();
                ID_Field.Text = "";
                Quantity_Field.Text = "";
            }
            
        }

        private void Order_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            Order_Table.Columns["Order_Remove_Button"].Index) return;

            int Id = e.RowIndex;
            double Price = Convert.ToDouble(Order_Table.Rows[Id].Cells[3].Value);

            Order_Table.Rows.RemoveAt(Id);
            Total_Price.Text = Convert.ToString(Convert.ToDouble(Total_Price.Text) - Price);

            Total_Price.Refresh();
            Order_Table.Refresh();


        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string C_Name = Convert.ToString(Customer_Name.Text);
            string C_Phone = Convert.ToString(Customer_Number.Text);
            string C_Address = Convert.ToString(Customer_Address.Text);
            string C_Comments = Convert.ToString(Customer_Comments.Text);

            var Order_Status = new Status();
            Order_Status.Id = 1;
            Order_Status.Name = "Ordered";

            var order = new Order();
            order.Manager = CurrentUser.UserInfo;
            order.Name = C_Name;
            order.OrderedAt = DateTime.Now;
            order.Comments = C_Comments;
            order.Phone = C_Phone;
            order.Address = C_Address;
            order.State = Order_Status;

            order.Id = Convert.ToInt32(_dbclient.PlaceOrder(order));

            var insertString = "INSERT INTO [OrderItems] ([order_id], [dish_id], [quantity]) VALUES ";
            

            for (int i = 0; i < Order_Table.Rows.Count; i ++)
            {
         
                insertString += $"({order.Id}, {Order_Table.Rows[i].Cells[0].Value}, {Order_Table.Rows[i].Cells[2].Value}),";

            }

            insertString = insertString.TrimEnd(',');

            _dbclient.FillOrderItems(insertString);

            Customer_Name.Text = "";
            Customer_Number.Text = "";
            Customer_Address.Text = "";
            Customer_Comments.Text = "";
            Total_Price.Text = "0";
            Order_Table.Rows.Clear();

        }

        private void Fill_Button_Click(object sender, EventArgs e)
        {
            _dbclient.OpenConnection();

            var queryString = "SELECT [id], [name], [price] FROM [DeliveryDB].[dbo].[Dishes]";

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

                    Products_Table.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2));

                }
                reader.Close();
                Products_Table.Refresh();
            }
        }

        private void ManagerForm_Click(object sender, EventArgs e)
        {
            var f = new ManagerForm();
            f.Show();
        }

        private void Cusom_Button_Click(object sender, EventArgs e)
        {
            var f = new CustomDish();
            f.Show();
        }
    }
}
