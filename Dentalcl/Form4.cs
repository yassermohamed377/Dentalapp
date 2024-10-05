using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dentalcl
{
    public partial class signuppage : Form
    {
        static string Sql2003 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\yasser\Desktop\Dentalcl\dentalclinicgbgb.mdb";
        OleDbConnection con2003 = new OleDbConnection(Sql2003);
        public signuppage()
        {
            InitializeComponent();
        }
        public void InsertIntoAcc200311()
        {//add signup
            con2003.Open();
            string query1 = "INSERT INTO signuptable ([username] ,[password] ,[regname]) VALUES (@user,@pass,@name)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);

            cmd.Parameters.AddWithValue("@user", newemailstaff.Text);
            //user name
            cmd.Parameters.AddWithValue("@pass", newpasswordstaff.Text);//nid = national id doctor
            cmd.Parameters.AddWithValue("@name", newstaffname.Text);// phone
                                                                    // cmd.Parameters.AddWithValue("@Dateofbirth", dobdoc.Text); //dob = date of birth
            cmd.ExecuteNonQuery();
            con2003.Close();
            // dataGridView5.DataSource = LoadDb11112003();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void regester_Click(object sender, EventArgs e)
        {

            string conf = confirmcode.Text;
            if (conf == "admin")
            {


                InsertIntoAcc200311();
                MessageBox.Show("Done");
                Form2 regester = new Form2();
                regester.ShowDialog();
                this.Hide();
                
            }

        }

        private void newstaffname_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 regester = new Form2();
            regester.ShowDialog();
            this.Hide();

        }

        private void confirmcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
