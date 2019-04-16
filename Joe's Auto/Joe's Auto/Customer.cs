﻿using System;
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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.customerBindingSource.EndEdit();
            } catch
            {
                MessageBox.Show("error");
            }
            this.tableAdapterManager.UpdateAll(this.joesDatabaseDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesDatabaseDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.joesDatabaseDataSet.customer);

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void customerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                this.customerBindingSource.Filter = "Name LIKE '" + textBox1.Text + "%'";
            } catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
