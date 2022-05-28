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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-4G1TI2F7;Initial Catalog=libraryDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO Orderr VALUES('" + textBox1.Text + "'," + textBox2.Text + "," + textBox3.Text + ");";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Orderr' table. You can move, or remove it, as needed.
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.orderrTableAdapter.Fill(this.libraryDBDataSet.Orderr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowPrice showPrice = new ShowPrice();
            showPrice.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShareComment shareComment = new ShareComment();
            shareComment.Show();
        }
    }
}
