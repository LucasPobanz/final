using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Auto
{
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {


                this.invoicesBindingSource.EndEdit();
            } catch
            {
                MessageBox.Show("error");
            }
            this.tableAdapterManager.UpdateAll(this.joesDatabaseDataSet);

        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesDatabaseDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.joesDatabaseDataSet.Invoices);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void invoicesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoicesBindingSource.Filter = "Name Like '" + textBox1.Text + "%'";
            } catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
