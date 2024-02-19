using System;
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
    public partial class Instruments : Form
    {
        public Instruments()
        {
            InitializeComponent();
        }

        private void Instruments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'instrumentTable.Instruments' table. You can move, or remove it, as needed.
            this.instrumentsTableAdapter.Fill(this.instrumentTable.Instruments);
            // TODO: This line of code loads data into the 'employeeTable.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeTable.Employees);
            NmeTxt.Text = "";
            TypCmb.Text = "";
            BrndTxt.Text = "";
            CstTxt.Text = "";
            RtTxt.Text = "";
            DtPkr.Text = "";
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try {
                instrumentsBindingSource.EndEdit();
                instrumentsTableAdapter.Update(instrumentTable.Instruments);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Row_Click(object sender, EventArgs e)
        {
            try
            {
                instrumentsBindingSource.AddNew();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
