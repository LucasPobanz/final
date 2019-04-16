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
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.vehicleBindingSource.EndEdit();
            } catch
            {
                MessageBox.Show("error");

            }
            this.tableAdapterManager.UpdateAll(this.joesDatabaseDataSet);

        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesDatabaseDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.joesDatabaseDataSet.Vehicle);

        }

        private void date_ReturnedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vehicleBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.vehicleBindingSource.Filter = "Name Like '" + textBox1.Text + "%'";
            } catch
            {
                MessageBox.Show("error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            new Customer().Show();
        }
    }
}
