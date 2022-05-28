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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Categorie' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.categorieTableAdapter.Fill(this.libraryDBDataSet.Categorie);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-4G1TI2F7;Initial Catalog=libraryDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO Categorie VALUES(" + textBox1.Text + ",'" + textBox2.Text + "' );";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShareComment shareComment = new ShareComment();
            shareComment.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Document view_Document = new View_Document();
            view_Document.Show();
        }
    }
}
