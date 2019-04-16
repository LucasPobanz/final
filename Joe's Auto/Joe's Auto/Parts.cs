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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.partsBindingSource.EndEdit();
            } catch
            {
                MessageBox.Show("error");
            }
            this.tableAdapterManager.UpdateAll(this.joesDatabaseDataSet);

        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesDatabaseDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.joesDatabaseDataSet.Parts);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.partsBindingSource.Filter = "Name Like '" + textBox1.Text + "%'";
            } catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
