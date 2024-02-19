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
    public partial class CreateLogins : Form
    {
        public CreateLogins()
        {
            InitializeComponent();
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void CreateLogins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studioDatabaseDataSet.LoginInfo' table. You can move, or remove it, as needed.
            this.loginInfoTableAdapter.Fill(this.studioDatabaseDataSet.LoginInfo);
            EmpIdTxt.Text = "";
            UsrNmTxt.Text = "";
            PswrdTxt.Text = "";
            AccntCmb.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                loginInfoBindingSource.AddNew();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
