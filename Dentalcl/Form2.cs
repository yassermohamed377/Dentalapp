using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentalcl
{
    public partial class Form2 : Form
    {

        static string Sql2003 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =  C:\Users\yasser\Desktop\tasksoop (6)\dentalclinicgbgb.mdb";
        OleDbConnection con2003 = new OleDbConnection(Sql2003);
        public Form2()
        {
            InitializeComponent();
        }
         private bool AuthenticateUser(string username, string password)
         {
             string query = "SELECT COUNT(*) FROM signuptable WHERE username = @username AND password = @password";
             int count = 0;
             /* username = username12.Text;
              password = textBox2.Text;*/
             try
             {
                 con2003.Open();
                 OleDbCommand command = new OleDbCommand(query, con2003);
                 command.Parameters.AddWithValue("@username", username);
                 command.Parameters.AddWithValue("@password", password);
                 count = (int)command.ExecuteScalar();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error: " + ex.Message);
             }
             finally
             {
                 con2003.Close();
             }

             return count > 0;
         }/*
        private bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT * FROM signuptable WHERE username = @username AND password = @password";

            int count = 0;

            con2003.Open();
            OleDbCommand command = new OleDbCommand(query, con2003);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                count = reader.GetInt32(0);
            }

            reader.Close();
            con2003.Close();

            return count > 0;
        }*/

        private void login_Click(object sender, EventArgs e)
        {
            string username = username12.Text;
            string password = textBox2.Text;

            if (AuthenticateUser(username, password))
            {
               
                Form3 fm3 = new Form3();
                fm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.try again.");
            }
           /* Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();*/
        }
        

        private void signup_Click(object sender, EventArgs e)
        {
            signuppage f4 = new signuppage();
            f4.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
