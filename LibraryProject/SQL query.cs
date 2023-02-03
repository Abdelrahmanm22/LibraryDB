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
    public partial class SQL_query : Form
    {

        SqlConnection con = new SqlConnection(Properties.Settings.Default.libraryDBConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        public SQL_query()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = textQuery.Text;
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if(ds.Tables[0].Rows.Count !=0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Document view_Document = new View_Document();
            view_Document.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
