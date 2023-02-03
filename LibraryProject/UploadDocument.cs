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
    public partial class UploadDocument : Form
    {
        public UploadDocument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-4G1TI2F7;Initial Catalog=libraryDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO Document VALUES(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'"+ textBox4.Text+"',"+textBox5.Text+","+textBox6.Text+","+textBox7.Text+");";

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.documentTableAdapter.Fill(this.libraryDBDataSet.Document);
        }

        private void UploadDocument_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Document' table. You can move, or remove it, as needed.
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowPrice showPrice = new ShowPrice();
            showPrice.Show();
        }
    }
}
