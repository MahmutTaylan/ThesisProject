using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thesis___CSharp.Process;

namespace Thesis___CSharp
{
    public partial class ThesisForm : Form
    {
        public ThesisForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            User u = LoginChecker.login(textBox_username.Text, textBox_password.Text);

            if (u != null)
            {
                UserForm form = new UserForm();
                form.Visible = true;
            }
            else {
                MessageBox.Show("Check your password or username.");
            }
        }
    }
}
