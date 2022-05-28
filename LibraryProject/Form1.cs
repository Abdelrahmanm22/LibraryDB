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

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.UserSystem' table. You can move, or remove it, as needed.
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.userSystemTableAdapter.Fill(this.libraryDBDataSet.UserSystem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-4G1TI2F7;Initial Catalog=libraryDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO UserSystem VALUES('"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"',"+textBox1.Text+");";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-4G1TI2F7;Initial Catalog=libraryDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            
            sqlCommand.CommandText = "UPDATE UserSystem SET Fname = '" + textBox2.Text + "',Lname = '" + textBox3.Text + "',Phone = '" + textBox4.Text + "',Bdate = '" + textBox5.Text + "' where UserID = " + textBox1.Text + "";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
