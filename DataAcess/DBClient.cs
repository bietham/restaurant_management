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


namespace DeliveryApp.DataAcess
{
    class DBClient
    {

        public SqlConnection conn;



        public DBClient ()
        {
            conn = new SqlConnection(
            @"Data Source=DESKTOP-KHO5CBP\SQLEXPRESS" +
            ";Initial catalog=DeliveryDB" +
            ";Integrated Security=True");
        }

        public User Login(string login, string password)
        {
            var queryString = $"SELECT u.[Id]" +
                $",u.[name]" +
                $",u.[login]" +
                $",u.[user_role_id]" +
                $",r.[name] as rname" +
                $"  FROM[DeliveryDB].[dbo].[Users] u" +
                $" JOIN Roles r on r.id = u.user_role_id" +
                $" WHERE u.login = @login AND u.password = @password";

            User result = null;

            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.Add("@login", SqlDbType.NChar);
                command.Parameters["@login"].Value = login;
                command.Parameters.Add("@password", SqlDbType.NChar);
                command.Parameters["@password"].Value = password;

                SqlDataReader reader = command.ExecuteReader();
                
                if (!reader.HasRows)
                {
                    reader.Close();
                    result = null;
                }
                else
                {
                    result = new User();

                    while (reader.Read())
                    {
                        result.Id = reader.GetInt32(0);
                        result.Name = reader.GetString(1);
                        result.Login = reader.GetString(2);
                        result.Roles.Add(new Role
                        {
                            Id = reader.GetInt32(3),
                            Name = reader.GetString(4)
                        });
                    }
                    reader.Close();
                }

            }
            catch (SqlException e)
            {
                //Исключения нужно логировать
                result = null;
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public int? PlaceOrder (Order order )
        {
            int? result;
            var insertString = "INSERT INTO [Orders] ([manager_id],[ordered_at],[status_id],[comments],[phone],[name], [address]) values (@manager_id, @ordered_at,@status_id,@comments,@phone,@name, @address)";
            var getIdString = "SELECT TOP(1) [Id] FROM [Orders] ORDER BY [Id] DESC";

            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand(insertString, conn);
                command.Parameters.Add("@manager_id", SqlDbType.Int);
                command.Parameters["@manager_id"].Value = order.Manager.Id;
                command.Parameters.Add("@ordered_at", SqlDbType.DateTime);
                command.Parameters["@ordered_at"].Value = order.OrderedAt.ToString("s");
                command.Parameters.Add("@status_id", SqlDbType.Int);
                command.Parameters["@status_id"].Value = order.State.Id;
                command.Parameters.Add("@comments", SqlDbType.NChar);
                command.Parameters["@comments"].Value = order.Comments;
                command.Parameters.Add("@phone", SqlDbType.NChar);
                command.Parameters["@phone"].Value = order.Phone;
                command.Parameters.Add("@name", SqlDbType.NChar);
                command.Parameters["@name"].Value = order.Name;
                command.Parameters.Add("@address", SqlDbType.NChar);
                command.Parameters["@address"].Value = order.Address;



                var rowsAffected = command.ExecuteNonQuery();

                command = new SqlCommand(getIdString, conn);
                var reader = command.ExecuteScalar();

                result = (int?)reader;
            }
            catch (SqlException e)
            {
                //Исключения нужно логировать
                result = null;
            }
            finally
            {
                CloseConnection();
            }

            return result;



        }

        public void FillOrderItems(string insertString)
        {
            try
            {
                OpenConnection() ;
                SqlCommand command = new SqlCommand(insertString, conn);
                var rowsAffected = command.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                //Исключения нужно логировать
                return;
            }
            finally
            {
                CloseConnection();
            }

        }

        



        public void OpenConnection ()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection GetConn ()
        {
            return conn;
        }
    }

}
