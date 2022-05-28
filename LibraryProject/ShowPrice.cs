using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class ShowPrice : Form
    {
        public ShowPrice()
        {
            InitializeComponent();
        }

        private void ShowPrice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Document' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.documentTableAdapter.Fill(this.libraryDBDataSet.Document);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadDocument uploadDocument = new UploadDocument();
            uploadDocument.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order order = new Order();
            order.Show();
        }
    }
}
