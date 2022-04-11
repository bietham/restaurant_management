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
    public partial class LoginForm : Form
    {
        private DBClient _dbclient;

        public LoginForm()
        {
            InitializeComponent();

            _dbclient = new DBClient();

            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Width, 45);
            this.LoginField.Height = this.PasswordField.Height;
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            var user = _dbclient.Login(LoginField.Text, PasswordField.Text);

            if (user == null)
            {
                // Нужно сообщить о проблеме
                return;
            }
            else
            {
                CurrentUser.UserInfo = user;


                if (user.Roles[0].Name.Split(' ')[0] == Roles.Manager)
                {
                    var f = new OrderForm();
                    f.Show();
                }

                else if (user.Roles[0].Name.Split(' ')[0] == Roles.Cook)
                {
                    var f = new KitchenForm();
                    f.Show();
                }

                if (user.Roles[0].Name.Split(' ')[0] == Roles.Courier)
                {
                    var f = new DeliveryForm();
                    f.Show();
                }
            }
        }
    }
}
