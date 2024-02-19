using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Music_Studio
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection LoginCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuru\OneDrive\Documents\StudioDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand LoginCmnd = new SqlCommand("SELECT * FROM [LoginInfo] WHERE Username='" + UsernameTxtBx.Text + "' AND Password='" + PasswordTxtBx.Text + "' AND Account='" + AccountCmbBx.Text + "'", LoginCon);
                SqlDataAdapter LoginDtAdptr = new SqlDataAdapter(LoginCmnd);
                DataTable LoginTbl = new DataTable();
                LoginDtAdptr.Fill(LoginTbl);

                String Acctype = AccountCmbBx.SelectedItem.ToString();

                if (LoginTbl.Rows.Count > 0)
                {
                    for (int i = 0; i < LoginTbl.Rows.Count; i++)
                    {
                        if (LoginTbl.Rows[i]["Account"].ToString() == Acctype)
                        {
                            MessageBox.Show("You are logged in as " + LoginTbl.Rows[i][2]);

                            if (AccountCmbBx.SelectedIndex == 0)
                            {

                                Dashboard dashboard = new Dashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("You are logged in as a User");
                            }
                        }
                    }
                }
                else if (UsernameTxtBx.Text==""||PasswordTxtBx.Text==""||AccountCmbBx.SelectedIndex==null)
                {
                    MessageBox.Show("All fields are required!");
                }
                else
                {
                    MessageBox.Show("Invalid login details!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsernameTxtBx.Text = "";
            PasswordTxtBx.Text = "";
            AccountCmbBx.Text = "";
        }
    }
}
