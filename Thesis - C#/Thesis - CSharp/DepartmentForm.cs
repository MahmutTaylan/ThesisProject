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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
            loadUniversity();
            loadDepartment();
        }
        private void loadDepartment()
        {
            String SQL = @"SELECT department.id, department.name, department.faculty_id,
                            faculty.id as 'fid', faculty.name as 'faculty'
                            FROM department 
                            INNER JOIN faculty ON department.faculty_id= faculty.id";

            DataTable data = DBConnection.selectDB(SQL);

            if (data != null)
            {
                dataGridView1.DataSource = data;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int uni = 0;
            int fac = 0;
            String name;
            if (!textBox_name.Text.Equals(""))
            {
                name = textBox_name.Text;
                if (comboBox_university.SelectedIndex >= 0)
                {
                    uni = Convert.ToInt32(comboBox_university.SelectedValue.ToString());
                    if (comboBox_faculty.SelectedIndex >= 0)
                    {
                        fac = Convert.ToInt32(comboBox_faculty.SelectedValue.ToString());

                        String SQL = "INSERT INTO department(faculty_id,name)VALUES(" + fac + ",'" + name + "')";
                        if (DBConnection.addDB(SQL))
                        {
                            MessageBox.Show("You have succesfully added!");
                            loadDepartment();
                        }
                        else
                        {
                            MessageBox.Show(SQL);
                        }

                    }
                    else
                    {
                        MessageBox.Show("You should select a faculty!");
                    }
                }
                else
                {
                    MessageBox.Show("You should select a university!");
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
                comboBox_university.DataSource = data;
            }

            comboBox_faculty.SelectedIndex = -1;

        }
        private void loadFaculty(int uni)
        {
            String SQL = "SELECT * FROM faculty WHERE university_id=" + uni;

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                comboBox_faculty.DataSource = data;
            }

        }

        private void comboBox_university_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_university.SelectedIndex >= 0)
            {
                loadFaculty(Convert.ToInt32(comboBox_university.SelectedValue));
            }
        }

    }
}
