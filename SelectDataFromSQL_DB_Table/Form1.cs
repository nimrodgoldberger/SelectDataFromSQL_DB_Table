using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SelectDataFromSQL_DB_Table
{
    public partial class Form1 : Form
    {
        //USED FOR ENTERING STRINGS TO THE DATAGRIDVIEW
        //public class StringValue
        //{
        //    public StringValue(string s)
        //    {
        //        _value = s;
        //    }
        //    public string Value { get { return _value; } set { _value = value; } }
        //    string _value;
        //}
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable GetDataTable(string connectionString, string cmd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(cmd, conn);
                DataTable table = new DataTable("MyTable");
                table.Load(command.ExecuteReader());
                return table;
            }
        }

        private DataTable EditDataTable(string connectionString, string newValue, string editCMD, string selectCMD)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                //string cmd = "UPDATE User3 SET Username = @newName Where Age<5";

                SqlCommand command = new SqlCommand(editCMD, conn);
                DataTable table = new DataTable("MyTable");
                command.Parameters.AddWithValue("@newName", newValue);
                command.ExecuteNonQuery();

                table = GetDataTable(ConnectionString, selectCMD);
                return table;
            }
        }



        public string ConnectionString { get; set; } = @"Server=.\AccessLayers;Database=Nimrod;Trusted_Connection=yes";
        // 2 ways to get data:
        // Data reader (leaves connection open and is readonly, works row by row) and
        // data set (closes connection, put all data at once into the object, and works disconnected)


        private void button1_Click(object sender, EventArgs e)
        {
            //MISSION 1 :grid show with string that shows all usernames concatenated by comma string

            try
            {
                DataTable user3table = GetDataTable(ConnectionString, @"select Username from User3");

                _dataGridViewSqlResult.DataSource = user3table;

                /*
                //USED FOR ENTERING STRINGS TO THE DATAGRIDVIEW
                List<StringValue> userNamesList = new List<StringValue>();
                userNamesList.Add(new StringValue("Nimrod"));
                userNamesList.Add(new StringValue("Nir"));
                userNamesList.Add(new StringValue("Yiftach"));
                userNamesList.Add(new StringValue("Racheli"));
                _dataGridViewSqlResult.DataSource = userNamesList;
                //
                //
                //USED FOR ENTERING OBJECT TO THE DATAGRIDVIEW
                List<object> points = new List<object>();
                points.Add(new Point(1, 1));
                points.Add(new Point(2, 2));
                points.Add(new Point(3, 3));
                _dataGridViewSqlResult.DataSource = points;
                */
            }
            //catch(SqlException se)
            //{

            //}
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MISSION 2 : textbox named 'age' put all older than age users with the Stored Procedure concadenated the names in another text box

            Application.DoEvents();

            if (String.IsNullOrEmpty(_numericUpDownAGE.Text))
            {
                _numericUpDownAGE.Value = 0;
            }

            string cmd = @"select Username from User3 where age >" + _numericUpDownAGE.Value;
            DataTable user3table = GetDataTable(ConnectionString, cmd);
            List<string> lines = new List<string>();
            int i = 1;

            foreach (DataRow row in user3table.Select())
            {
                lines.Add((i++) + ". " + row[0] as string);
            }
            _textBoxResult.Text = String.Join(Environment.NewLine, lines);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //BONUS : all young users change name to kid and print concadenated
            if (String.IsNullOrEmpty(_textBoxNewName.Text))
            {
                MessageBox.Show("The Name CANNOT be empty, please choose a new name!");
            }
            else
            {
                try
                {
                    //string cmd = "UPDATE User3 SET Username = @newName Where Age<5";

                    DataTable table = EditDataTable(ConnectionString, _textBoxNewName.Text, $"UPDATE User3 SET Username = @newName Where Age<{_numericUpDownYoungerThan.Value}", "SELECT * From User3");
                    _dataGridViewSqlResult.DataSource = table;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BONUS 2 : read the connection string from app.config

            string connectionStringAsString = ConfigurationManager.ConnectionStrings[0].ToString();
            MessageBox.Show(connectionStringAsString);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MISSION 4 : GRID to be continued





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _buttonGetAllUsersToMSGbox_Click(object sender, EventArgs e)
        {
            //MISSION 1.1 : message box.show with string that shows all usernames concatenated by comma string

            try
            {
                //string connectionString = @"Password=tanin123;Persist Security Info=True;User ID=portnoxadmin;Initial Catalog=Nimrod;Data Source=.\AccessLayers";
                string connectionString2 = @"Server=.\AccessLayers;Database=Nimrod;Trusted_Connection=yes";

                using (SqlConnection conn = new SqlConnection(connectionString2))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"select Username from User3", conn);

                    DataTable user3table = new DataTable("MyTable");
                    StringBuilder stringBuilder = new StringBuilder(@"Usernames are:
");
                    int i = 1;
                    user3table.Load(cmd.ExecuteReader());

                    List<string> lines = new List<string>();

                    foreach (var item in user3table.Select())
                    {
                        //Option A:
                        lines.Add((i++) + ". " + item[0] as string);

                        //Option B:
                        //stringBuilder.AppendLine((i++) + ". " + (string)item[0]);
                    }
                    //Option A:
                    MessageBox.Show(String.Join(Environment.NewLine, lines));

                    //Option B:
                    //MessageBox.Show(String.Join(Environment.NewLine, stringBuilder.ToString()));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        private void _textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void _numericUpDownAGE_ValueChanged(object sender, EventArgs e)
        {

        }
        private void _numericUpDownAGE_LeftFocus(object sender, EventArgs e)
        {
            //if(_numericUpDownAGE.Value.)
        }

        private void _textBoxNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void _buttonChangeNameOK_Click(object sender, EventArgs e)
        {

        }

        private void _numericUpDownYoungerThan_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
