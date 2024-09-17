using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPApplication
{
    public partial class Login : Form
    {
        MTPDbContext context = new MTPDbContext();

        public Login()
        {
            InitializeComponent();
            string email = Properties.Settings.Default.LastUserID.ToString();
            if(!string.IsNullOrEmpty(email))
            {
                emailtextbox.Text = email;
                remembermecheckbox.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            var email = emailtextbox.Text.ToString();
            var password = passwordtextbox.Text.ToString();

            var employee = context.Employees.Where(x => x.Email == email).FirstOrDefault();
            try
            {
                if (employee != null)
                {
                    if (string.Compare(employee.Password, password) == 0)
                    {
                        if (remembermecheckbox.Checked == true)
                        {
                            Properties.Settings.Default.LastUserID = email;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.LastUserID = null;
                            Properties.Settings.Default.Save();
                        }

                        CommonAccess.employeeId = employee.Employee_No;
                        MessageBox.Show("Login Successful");
                        PackageManagement packageManagement = new PackageManagement();
                        packageManagement.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect email/password. Please try again.");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("An Error has occured. Please try again.");

            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void navbar1_Load(object sender, EventArgs e)
        {

        }
    }
}
