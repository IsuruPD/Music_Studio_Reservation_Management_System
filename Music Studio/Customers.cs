﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Studio
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studioDatabaseDataSet2.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.studioDatabaseDataSet2.Customers);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
