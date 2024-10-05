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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dentalcl
{
    public partial class Form3 : Form
    {

       static string Sql2003 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\yasser\Desktop\tasksoop (6)\dentalclinicgbgb.mdb";
        OleDbConnection con2003 = new OleDbConnection(Sql2003);
        public Form3()
        {
            InitializeComponent();
        }
        void calc()
        {
            if (con2003 != null)
            {
                MessageBox.Show("Enter the data ");
            }
        }

        //materials
        private void label2_Click(object sender, EventArgs e)
        {

        }
       // private void Form3_Load(object sender, EventArgs e)
       // {
         //   dataGridView1.DataSource = LoadDb2003();
       // }
        public DataTable LoadDb2003()
        {
          
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM proscription";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }

        public  DataTable LoadDb12003()
        {
            
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM staffdb";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
        public DataTable LoadDb112003()
        {
           
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM patientdatabase"; 
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
        public DataTable LoadDb11200301()// try case
        {


            con2003.Open();
          //  int x;
            // TextBox8.text=
           // textBox8.Text = x;

            DataTable dt = new DataTable();
            string query = "SELECT * FROM patientdatabase WHERE cost > 50";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
        public DataTable LoadDb1112003()
        {

            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM bookingtable";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
        public DataTable LoadDb11112003()
        {
            
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM doctorstable";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
        public DataTable LoadDb111112003()
        {

            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM interviewtable";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
       public DataTable LoadDb1111112003()
        {
            // services show
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM servt";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
        public DataTable LoadDb11111112003()
        {//markting

            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM martb";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
      /*  public DataTable LoadDb111111112003()
        {//markting

            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM materials";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }*/
        public DataTable LoadDb1111111112003()
        {

            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM materials";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            return dt;
        }
        /* con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM patientdatabase WHERE cost=20 ";
            OleDbCommand cmd = new OleDbCommand(query,con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();*/
        private void ResetInputFields()
        {
            nametext.Text = "";
            textBox8.Text = "";
            textphone.Text = "";
            servicestext.Text = "";
            // Reset other input fields as needed
        }
        private void newpatient_Click(object sender, EventArgs e)
        {
            mewpatient.BringToFront();
        }

        private void markting_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            pstaff.BringToFront();
        }

        private void prescription_Click(object sender, EventArgs e)
        {
            pprescription.BringToFront();
        //    contextMenuStrip3.Show(prescription, 20, prescription.Height);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void doctors_Click(object sender, EventArgs e)
        {
            //pdoctor.BringToFront();
           // doctorpanel1.BringToFront();
           doctorpanel.BringToFront();
        }

        private void services_Click(object sender, EventArgs e)
        {
            pservices.BringToFront();
        }

        private void usernameshow_Click(object sender, EventArgs e)
        {
            //pservices.BringToFront();
        }

        private void sernices2_Click(object sender, EventArgs e)
        {

        }
     
        public void InsertIntoAcc2003()
        {//add data for tables
            con2003.Open();
            string query = "INSERT INTO patientdatabase ([patient_name] ,[cost] ,[phone] ,[services],[time] ) VALUES (@patient_name  ,@cost ,@phone,@services,@time )";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.Parameters.AddWithValue("@patient_name", nametext.Text);
           // cmd.Parameters.AddWithValue("@gender", gendername.Text);
            //cmd.Parameters.AddWithValue("@Age", agetext.Text);
           // cmd.Parameters.AddWithValue("@services", servicestext.Text);
            cmd.Parameters.AddWithValue("@cost", textBox8.Text);
            cmd.Parameters.AddWithValue("@phone", textphone.Text);
            cmd.Parameters.AddWithValue("@services", servicestext.Text);
            cmd.Parameters.AddWithValue("@time", dateTimePicker1.Value);
            // cmd.Parameters.AddWithValue("@medichal_history", casehistory.Text);
            //cmd.Parameters.AddWithValue("@no", textBox3.Text);
            // calc();
            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView3.DataSource = LoadDb112003();
            dataGridView17.DataSource = LoadDb112003();
            ResetInputFields();
            LoadChartFromAcc2003();
            LoadPieChart();
           dataGridView19.DataSource= LoadDb11200301();
            // calc();
        }
        public void InsertIntoAcc20031()
        {//add booking
            con2003.Open();
            string query1 = "INSERT INTO bookingtable ([Patient_name] ,[phone]) VALUES (@Patient_name,@phone)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);
            
            cmd.Parameters.AddWithValue("@Patient_name", textBox2.Text);
                  // textbox2 = patient name
            cmd.Parameters.AddWithValue("@phone", textBox1.Text); //text box1 = phone
            
            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView4.DataSource = LoadDb1112003();
        }
        public void InsertIntoAcc200311()
        {//add doctors
            con2003.Open();
            string query1 = "INSERT INTO doctorstable ([doctor_name] ,[National ID] ,[phone], [Date of birth]) VALUES (@doctorname,@NationalID,@phone,@Dataofbirth)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);

            cmd.Parameters.AddWithValue("@doctorname", namedoc.Text);
                           //namedoc= name doctor
            cmd.Parameters.AddWithValue("@NationalID", niddoc.Text);//nid = national id doctor
            cmd.Parameters.AddWithValue("@phone", phonedoc.Text);// phone
            cmd.Parameters.AddWithValue("@Dateofbirth", dateTimePicker2.Value); //dob = date of birth
            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView5.DataSource = LoadDb11112003();
        }
        public void InsertIntoAcc2003111()
        {//add interview
            con2003.Open();
            string query1 = "INSERT INTO interviewtable ([name] ,[NID] ,[phone], [staff or doctor], [accepted?]) VALUES (@name,@NID,@phone,@staffordoc,@accepted)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);

            cmd.Parameters.AddWithValue("@name", nameinterv.Text);
            //namedoc= name doctor
            cmd.Parameters.AddWithValue("@NID", nidinterv.Text);//nid = national id 
            cmd.Parameters.AddWithValue("@phone", phoneinterv.Text);// phone
            cmd.Parameters.AddWithValue("@staffordoc", staffordocinterv.Text); //dob = date of birth
            cmd.Parameters.AddWithValue("@accepted", acceptedinterv.Text); //dob = date of birth
            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView6.DataSource = LoadDb111112003();
        }
        /* public void InsertIntoAcc2003111111()
         {//add servies
             con2003.Open();
             string query1 = "INSERT INTO servt ([name of service] ,[price]) VALUES (@Patient_name,@phone)";
             OleDbCommand cmd = new OleDbCommand(query1, con2003);

             cmd.Parameters.AddWithValue("@Patient_name", textBox9.Text);// 
             // textbox2 = patient name
             cmd.Parameters.AddWithValue("@phone", textBox10.Text); //text box10 = price
             cmd.ExecuteNonQuery();
             con2003.Close();
             dataGridView10.DataSource = LoadDb1111112003();
         }*/
        public void InsertIntoAcc2003111111()
        {
            con2003.Open();
            string query1 = "INSERT INTO servt ([name_of_service], [price]) VALUES (@ServiceName, @Price)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);

            cmd.Parameters.AddWithValue("@ServiceName", textBox9.Text);// 
            cmd.Parameters.AddWithValue("@Price", textBox10.Text);

            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView10.DataSource = LoadDb1111112003();
        }

        public void InsertIntoAcc20031111111()
        {//add social markting
            con2003.Open();
            string query1 = "INSERT INTO martb ([social_media] ,[Link]) VALUES (@Patient_name,@phone)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);

            cmd.Parameters.AddWithValue("@Patient_name", textBox11.Text);// 
            
            cmd.Parameters.AddWithValue("@phone", textBox12.Text); //text box12 = link
            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView7.DataSource = LoadDb11111112003();
        }
        public void InsertIntoAcc200311111111()
        {//add social staff
            con2003.Open();
            string query1 = "INSERT INTO staffdb ([Name] ,[phone],[National id],[Date of birth]) VALUES (@Patient_name,@phone,@me,@mee)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);

            cmd.Parameters.AddWithValue("@Patient_name", textBox13.Text);// 

            cmd.Parameters.AddWithValue("@phone", textBox14.Text); //text box12 = link
            cmd.Parameters.AddWithValue("@me", textBox15.Text); //text box12 = link
            cmd.Parameters.AddWithValue("@mee", dateTimePicker3.Value); //text box12 = link
            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView2.DataSource = LoadDb12003();
        }
        public void InsertIntoAcc2003111111111( string medicineName)
        {//add  prescription
            con2003.Open();
            string query1 = "INSERT INTO proscription ([Name] ,[medicens]) VALUES (@Patient_name,@phone)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);

            cmd.Parameters.AddWithValue("@Patient_name", textBox21.Text);// name

            //  cmd.Parameters.AddWithValue("@phone", textBox20.Text); //medicens
            cmd.Parameters.AddWithValue("@phone", medicineName);
            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView1.DataSource = LoadDb2003();

        }
        public void InsertIntoAcc20031111111111()
        {//add  material
            con2003.Open();
            string query1 = "INSERT INTO materials ([material] ,[From] ,[cost] ,[Datein]) VALUES (@Patient_name,@phone,@me,@mo)";
            OleDbCommand cmd = new OleDbCommand(query1, con2003);

            cmd.Parameters.AddWithValue("@Patient_name", textBox3.Text);// name

            cmd.Parameters.AddWithValue("@phone", textBox5.Text); //medicens
            cmd.Parameters.AddWithValue("@me", textBox6.Text); //medicens
            cmd.Parameters.AddWithValue("@mo", dateTimePicker4.Value); //medicens

            cmd.ExecuteNonQuery();
            con2003.Close();
            dataGridView18.DataSource = LoadDb1111111112003();
        }
        /*  public void InsertIntoAcc20031111()
           {//add material
               con2003.Open();
               string query1 = "INSERT INTO materials ([Material] ,[from] ,[cost], [Date]) VALUES (@doctorname1, @NationalID1 , @phone1 , @Dataofbirth1)";
               OleDbCommand cmd = new OleDbCommand(query1, con2003);

               cmd.Parameters.AddWithValue("@doctorname1", textBox3.Text);
               //namedoc= name doctor
               cmd.Parameters.AddWithValue("@NationalID1", textBox4.Text);//nid = national id doctor
               cmd.Parameters.AddWithValue("@phone1", textBox5.Text);// phone
               cmd.Parameters.AddWithValue("@Dateofbirth1", textBox7.Text); //dob = date of birth
               cmd.ExecuteNonQuery();
               con2003.Close();
               dataGridView18.DataSource = LoadDb111111112003();
           }*/
        /*  public void InsertIntoAcc20031111() // insert material
         {
              con2003.Open();
              // string query1 = "INSERT INTO materials ([Material], [from], [cost], [Date]) VALUES (@doctorname1, @NationalID1, @phone1, @Dateofbirth1)";
              //"INSERT INTO materials ([Material], [from], [cost], [Date]) VALUES (@doctorname1, @NationalID1, @phone1, Format(@Dateofbirth1, 'yyyy-mm-dd'))"
              string query1 = "INSERT INTO materials ([Material], [from], [cost], [Date]) VALUES (@doctorname1, @NationalID1, @phone1, @hk)";

              OleDbCommand cmd = new OleDbCommand(query1, con2003);

              cmd.Parameters.AddWithValue("@doctorname1", textBox3.Text);
              cmd.Parameters.AddWithValue("@NationalID1", textBox4.Text);
              cmd.Parameters.AddWithValue("@phone1", textBox5.Text);

              //  cmd.Parameters.AddWithValue("@Dateofbirth1", dateTimePicker4.Value); // Format the date correctly
              //  cmd.Parameters.AddWithValue("@Dateofbirth1", dateTimePicker4.Value.ToString("yyyy-MM-dd HH:mm:ss"));
              cmd.Parameters.AddWithValue("@hk", textBox7.Text);
             // cmd.Parameters["@Dateofbirth1"].DbType = DbType.DateTime;

              cmd.ExecuteNonQuery();
              con2003.Close();
              dataGridView18.DataSource = LoadDb111111112003();
          }
        */

        public void LoadChartFromAcc2003()
        {// to  view data in dashboard services 
            chart1.Series.Clear(); // Clear any existing series from the chart

            con2003.Open();

            string query = "SELECT [services], COUNT(*) AS [Count] FROM [patientdatabase] GROUP BY [services]";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string service = reader["services"].ToString();
                int count = Convert.ToInt32(reader["Count"]);
                if (!chart1.Series.IsUniqueName(service))
                {
                    service += DateTime.Now.Ticks.ToString(); // Append a unique identifier if the series name already exists
                }

                Series series = chart1.Series.FindByName(service);
                if (series == null)
                {
                    series = chart1.Series.Add(service);
                    series.ChartType = SeriesChartType.Column;
                }

                // chart1.Series.Add(service);
                series.Points.AddXY(service, count);
               // chart1.Series[service].Points.AddXY(service, count);
                //chart1.Series.Clear();
            }

            con2003.Close();
        }
       


        private void LoadPieChart()
        {
            // Retrieve data from the database
            DataTable dataTable = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT services, COUNT(*) AS service_count FROM patientdatabase GROUP BY services", con2003);
            adapter.Fill(dataTable);

            // Clear existing data
            chart2.Series.Clear();
            chart2.Legends.Clear(); // Clear existing legends

            // Add series
            Series series1 = new Series("Series1");
            chart2.Series.Add(series1);

            // Prepare data for the pie chart
            foreach (DataRow row in dataTable.Rows)
            {
                string serviceName = row["services"].ToString();
                int serviceCount = Convert.ToInt32(row["service_count"]);
                chart2.Series["Series1"].Points.AddXY(serviceName, serviceCount);
            }

            // Set chart properties
            chart2.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart2.Series["Series1"].IsValueShownAsLabel = true;

            // Add legend if it doesn't exist
            if (chart2.Legends.Count == 0) // Check if any legends exist
            {
                Legend legend1 = new Legend("Legend1"); // Create new legend object
                chart2.Legends.Add(legend1); // Add legend to chart's LegendCollection
                chart2.Series["Series1"].Legend = "Legend1"; // Assign legend to series
            }
        }



        private void Form3_Load(object sender, EventArgs e)
         {
                  dataGridView1.DataSource = LoadDb2003(); // proscription view
                  dataGridView2.DataSource = LoadDb12003();//staff view
                  dataGridView3.DataSource = LoadDb112003(); //patient data
                  dataGridView4.DataSource = LoadDb1112003();// booking data
                  dataGridView5.DataSource = LoadDb11112003();//doctors data
                  dataGridView6.DataSource = LoadDb111112003();// interview data
                  dataGridView10.DataSource = LoadDb1111112003();// services data
                  dataGridView7.DataSource =  LoadDb11111112003();//markting data
                  dataGridView17.DataSource =/*****/LoadDb112003();// patient data view
                  dataGridView18.DataSource = LoadDb1111111112003();// materials
                                                                    //   dataGridView18.DataSource =  LoadDb111111112003();// materials view 
                                                                    // chart1.Series= LoadDb112003();
           LoadPieChart();
            LoadChartFromAcc2003();
               dataGridView19.DataSource=    LoadDb11200301();
         //   CreateMenuItems();
           

        }

        private void dbview_Click(object sender, EventArgs e)
        {
            patientdb.BringToFront();//show patients database 
        }

        private void save_Click(object sender, EventArgs e)
        {
           // LoadChartFromAcc2003();
            try
            {
                string name = nametext.Text;//name
                if (name.Any(char.IsDigit))
                {
                    throw new FormatException();
                }
                string uitext = textBox8.Text;//cost
                double value = double.Parse(uitext);
                InsertIntoAcc2003();
              //  LoadChartFromAcc2003();
                Refresh();
                MessageBox.Show("Done");

                //  panel14.BringToFront();
                // Perform some operation with the name
                //  panel14.BringToFront();
            }
            catch (FormatException)
            {

                // label20.Text = "Enter right input";
                MessageBox.Show("Enter the data");
            }/*
            try
            {
               con2003.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con2003;
                string query1 = "select * from patientdatabase";
                command.CommandText = query1;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["services"].Points.AddXY(reader["services"], reader[""]);
                }
                con2003.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" no" + ex);
            }


           /* InsertIntoAcc2003();
            MessageBox.Show("Done");*/
           // chart1.DataSource = LoadChartFromAcc2003();
        }
       

        

        private void textphone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string uitext = textphone.Text;//phone number
                double value = double.Parse(uitext);

            }
            catch (FormatException)
            {

                MessageBox.Show("phone only takes numbers");
            }
        }
        // Assuming you have a chart control named chart1 on your form

        /*public void LoadChartFromAcc2003()
        {
            chart1.Series.Clear(); // Clear any existing series from the chart

            con2003.Open();

            string query = "SELECT services, COUNT(*) AS Count FROM patientdatabase GROUP BY services";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string service = reader["services"].ToString();
                int count = Convert.ToInt32(reader["Count"]);

                chart1.Series.Add(service);
                chart1.Series[service].Points.AddXY(service, count);
            }

            con2003.Close();
        }*/
        private void button2_Click(object sender, EventArgs e)
        {//delete patients
            con2003.Open();
            string query = "DELETE FROM patientdatabase WHERE ID=" + dataGridView3.CurrentRow.Cells[0].Value.ToString()+"";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("Done");
            dataGridView3.DataSource = LoadDb112003();



        }

        private void bookingbutton_Click(object sender, EventArgs e)
        {
            panel5.BringToFront(); // booking page
        }

        private void buttonbook_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text;//name
                if (name.Any(char.IsDigit))
                {
                    throw new FormatException();
                }
                string uitext = textBox1.Text;//phone
                double value = double.Parse(uitext);
                InsertIntoAcc20031();// add book data
                MessageBox.Show("Done");
                
            }
            catch (FormatException)
            {

                // label20.Text = "Enter right input";
                MessageBox.Show("Enter the data");
            }
           /* InsertIntoAcc20031();// add book data
            MessageBox.Show("Done");*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string uitext = textBox1.Text;//phone number
                double value = double.Parse(uitext);

            }
            catch (FormatException)
            {

                MessageBox.Show(" phone takes numbers");

            }
        }

        private void regesterdoc_Click(object sender, EventArgs e)
        {

            try
            {
                string name = namedoc.Text;//name
                if (name.Any(char.IsDigit))
                {
                    throw new FormatException();
                }
                string uitext = phonedoc.Text;//phone
                double value = double.Parse(uitext);
                InsertIntoAcc200311();// add doctor data
                MessageBox.Show("Done");

            }
            catch (FormatException)
            {

                // label20.Text = "Enter right input";
                MessageBox.Show("Enter the data");
            }
            /* InsertIntoAcc20031();// add book data
             MessageBox.Show("Done");*/
        }
       
        

        private void interviewbutton_Click(object sender, EventArgs e)
        {
            interviewpanel.BringToFront();
        }

        private void interviewaddbutton_Click(object sender, EventArgs e)
        {
            /* InsertIntoAcc2003111();
             MessageBox.Show("Done");*/
            try
            {
                string name = nameinterv.Text;//name
                if (name.Any(char.IsDigit))
                {
                    throw new FormatException();
                }
                string uitext = phoneinterv.Text;//phone
                double value = double.Parse(uitext);
                InsertIntoAcc2003111();// interview
                MessageBox.Show("Done");

            }
            catch (FormatException)
            {

                // label20.Text = "Enter right input";
                MessageBox.Show("Enter the data");
            }
            /* InsertIntoAcc20031();// add book data
             MessageBox.Show("Done");*/
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            //search patient 
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM patientdatabase WHERE patient_name LIKE '%"+searchpatient.Text+"%' ";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView9.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {                            
                string name = textBox9.Text;//name
                if (name.Any(char.IsDigit))
                {
                    throw new FormatException();
                }
                string uitext = textBox10.Text;//price
                double value = double.Parse(uitext);
                // add services
                InsertIntoAcc2003111111();
                MessageBox.Show("done");
            }
            catch (FormatException)
            {

                // announcement message
                MessageBox.Show("Enter Right data");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//add markting media
            
            InsertIntoAcc20031111111();
            MessageBox.Show("done");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox13.Text;//name
                if (name.Any(char.IsDigit))
                {
                    throw new FormatException();
                }
                string uitext = textBox14.Text;//phone
                double value = double.Parse(uitext);
                InsertIntoAcc200311111111();// staff data
                MessageBox.Show("Done");

            }
            catch (FormatException)
            {

               // announcement message
                MessageBox.Show("Enter the data");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {// search staff
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM staffdb WHERE Name LIKE '%" + textBox17.Text + "%' ";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView11.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // delete staff
            
            con2003.Open();
            string query = "DELETE FROM staffdb WHERE ID=" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("Done");
            dataGridView2.DataSource = LoadDb12003();
        }

        private void button9_Click(object sender, EventArgs e)
        {// delete doc
            con2003.Open();
            string query = "DELETE FROM doctorstable WHERE ID=" + dataGridView5.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("Done");
            dataGridView5.DataSource = LoadDb11112003();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // search doctor
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM doctorstable WHERE doctor_name LIKE '%" + textBox18.Text + "%' ";// teaxt 18 = search doc
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView12.DataSource = dt;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox21.Text;//name
                
                if (name.Any(char.IsDigit))
                {
                    throw new FormatException();
                }
              string value = textBox22.Text;
             //  InsertIntoAcc2003111111111(medicineselect);// proscription staff
                MessageBox.Show("Done");

            }
            catch (FormatException)
            {

                // announcement message
                MessageBox.Show("Enter the data");
            }
          /*  InsertIntoAcc2003111111111();
            MessageBox.Show("Done");*/
              
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //search proscription
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM proscription WHERE Name LIKE '%" + textBox19.Text + "%' ";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView13.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // delete prosc
            con2003.Open();
            string query = "DELETE FROM proscription WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("Done");
            dataGridView1.DataSource = LoadDb2003();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // delete services
            con2003.Open();
            string query = "DELETE FROM servt WHERE ID=" + dataGridView10.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("Done");
            dataGridView10.DataSource = LoadDb1111112003();
        }

        private void button15_Click(object sender, EventArgs e)
        {//search service
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM servt WHERE name_of_service LIKE '%" + textBox22.Text + "%' ";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView14.DataSource = dt;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // search booking
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM bookingtable WHERE Patient_name LIKE '%" + textBox23.Text + "%' ";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView15.DataSource = dt;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // delete booking
            con2003.Open();
            string query = "DELETE FROM bookingtable WHERE ID=" + dataGridView4.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("Done");
            dataGridView4.DataSource = LoadDb1112003();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //search interview
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM interviewtable WHERE name LIKE '%" + textBox24.Text + "%' ";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView16.DataSource = dt;

        }

        private void button18_Click(object sender, EventArgs e)
        {// delete interview
            con2003.Open();
            string query = "DELETE FROM interviewtable WHERE ID=" + dataGridView6.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("Done");
            dataGridView6.DataSource = LoadDb111112003();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //search markting
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM martb WHERE social_media LIKE '%" + textBox25.Text + "%' ";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView8.DataSource = dt;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // delete markting 
            con2003.Open();
            string query = "DELETE FROM martb WHERE ID=" + dataGridView7.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("Done");
            dataGridView7.DataSource = LoadDb111112003();

        }

        private void button22_Click(object sender, EventArgs e)
        {// log out button
            Environment.Exit(0); // to close the system
        }

        private void dataGridView17_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dasbpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dasbttn_Click(object sender, EventArgs e)
        {
            dasbpanel.BringToFront();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // add mateeial 
            try
            {
                string name = textBox3.Text;//name
                if (name.Any(char.IsDigit))
                {
                    throw new FormatException();
                }
                string uitext = textBox6.Text;//phone
                double value = double.Parse(uitext);
                InsertIntoAcc20031111111111();
                MessageBox.Show("done");

            }
            catch (FormatException)
            {

                // label20.Text = "Enter right input";
                MessageBox.Show("Enter the data");
            }
           /* InsertIntoAcc20031111111111();
            MessageBox.Show("done");*/

        }

        /* private void button24_Click(object sender, EventArgs e)
          {// add material
           //  LoadDb111111112003();
             // InsertIntoAcc20031111();
              MessageBox.Show("Done");
          }*/

         /*private void button25_Click(object sender, EventArgs e)
          {// material search
              con2003.Open();
              DataTable dt = new DataTable();
              string query = "SELECT * FROM materials WHERE Material LIKE '%" + textBox6.Text + "%' ";
              OleDbCommand cmd = new OleDbCommand(query, con2003);
              OleDbDataAdapter da = new OleDbDataAdapter(cmd);
              da.Fill(dt);
              con2003.Close();
              dataGridView18.DataSource = dt;
          }*/

        private void button24_Click(object sender, EventArgs e)
        {
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM materials WHERE Material LIKE '%" + textBox7.Text + "%' ";
            OleDbCommand cmd = new OleDbCommand(query, con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView18.DataSource = dt;
        }
        
        private void button23_Click(object sender, EventArgs e)
        {// material button
            materialpanel.BringToFront();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
           // UpdateAcc2003();
        }

        private void upnewpat_Click(object sender, EventArgs e)
        {/*
            //  UpdateAcc2003();
            con2003.Open();
            string query = "UPDATE patientdatabase SET [patient_name] = @patient_name, [cost] = @cost, [phone] = @phone, [services] = @services, WHERE ID=" + dataGridView17.CurrentRow.Cells.ToString()+"";
            OleDbCommand cmd =new OleDbCommand(query, con2003);
            cmd.Parameters.AddWithValue("@patient_name",nametext.Text);
            cmd.Parameters.AddWithValue("@cost", textBox8.Text);
            cmd.Parameters.AddWithValue("@phone", textphone.Text);
            cmd.Parameters.AddWithValue("@services", servicestext.Text);
            cmd.ExecuteNonQuery();
            con2003.Close();
            MessageBox.Show("UPDATED");
            dataGridView17.DataSource= LoadDb112003();*/
           
                //  UpdateAcc2003();
                con2003.Open();
                string query = "UPDATE patientdatabase SET [patient_name] = @patient_name, [cost] = @cost, [phone] = @phone, [services] = @services, [time] = @time WHERE ID = @id";
                OleDbCommand cmd = new OleDbCommand(query, con2003);
                cmd.Parameters.AddWithValue("@patient_name", nametext.Text);
                cmd.Parameters.AddWithValue("@cost", textBox8.Text);
                cmd.Parameters.AddWithValue("@phone", textphone.Text);
                cmd.Parameters.AddWithValue("@services", servicestext.Text);
                cmd.Parameters.AddWithValue("@time", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView17.CurrentRow.Cells["ID"].Value));
                cmd.ExecuteNonQuery();
                con2003.Close();
                MessageBox.Show("UPDATED");
                dataGridView17.DataSource = LoadDb112003();

            ResetInputFields();

        }

        private void dataGridView17_SelectionChanged(object sender, EventArgs e)
        {
            nametext.Text= dataGridView17.CurrentRow.Cells[1].Value.ToString();
            textphone.Text = dataGridView17.CurrentRow.Cells[3].Value.ToString();
            servicestext.Text= dataGridView17.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView17.CurrentRow.Cells[2].Value.ToString();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            LoadDb11200301();
            /*
            con2003.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM patientdatabase WHERE cost=20 ";
            OleDbCommand cmd = new OleDbCommand(query,con2003);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con2003.Close();
            dataGridView19.DataSource = LoadDb112003(); ;
            //return dt;
            */

        }

        private void contextMenuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Text);
           // string selectedMedicine = e.ClickedItem.Text;

            // Insert the selected medicine into the database
         //  InsertIntoAcc2003111111111(selectedMedicine);
        }

        private void medicineselect_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(medicineselect, 0, medicineselect.Height);
        //   ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            // Insert the selected medicine into the database
        // InsertIntoAcc2003111111111(ClickedItem.Text);
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
           // contextMenuStrip3.Items.Clear();
          //  CreateMenuItems();
        }

        private void pprescription_Paint(object sender, PaintEventArgs e)
        {

        }
        /* private void PopulateMenuItems(ToolStripItemCollection items)
{
    foreach (ToolStripItem item in items)
    {
        // Check if the item is a menu item
        if (item is ToolStripMenuItem)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)item;
            // Handle click event for menu items
            menuItem.Click += menuItem_Click;
            // Recursively populate sub-items
            PopulateMenuItems(menuItem.DropDownItems);
        }
    }
}*/
        /*  private void CreateMenuItems()
        {

            // Clear existing items
            contextMenuStrip3.Items.Clear();
            // Populate menu items recursively
            PopulateMenuItems(contextMenuStrip3.Items);
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem != null)
            {
                // Insert the selected medicine into the database
                InsertIntoAcc2003111111111(clickedItem.Text);
            }
        
    }*/

    }
      
    }

