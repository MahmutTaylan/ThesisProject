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
    public partial class UniversityForm : Form
    {
        public UniversityForm( )
        {
            InitializeComponent();
            loadUniversity();
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            String name;
            if (!textBox_name.Text.Equals(""))
            {
                name = textBox_name.Text;
                String SQL = "INSERT INTO university(name)VALUES('" + name + "')";
                if (DBConnection.addDB(SQL))
                {
                    MessageBox.Show("You have succesfully added!");
                    loadUniversity();
                }
                else
                {
                    MessageBox.Show("Failed");
                }

                
               
            }
            else
            {
                MessageBox.Show("Name field can not be null!");
            }
        }
        private void loadUniversity()
        {
            String SQL = "SELECT * FROM university";

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                dataGridView1.DataSource = data;
            }

        }
    }
}
