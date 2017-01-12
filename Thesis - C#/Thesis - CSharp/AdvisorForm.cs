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
    public partial class AdvisorForm : Form
    {
        public AdvisorForm()
        {
            InitializeComponent();
            loadUniversity();
            loadAdvisor();
        }

        private void loadAdvisor()
        {
            String SQL = @"SELECT instructer.id, instructer.name, instructer.deparment_id,
                            department.id as 'did', department.name as 'department'
                            FROM instructer 
                            INNER JOIN department ON instructer.deparment_id= department.id";

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
            int dep = 0;
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
                        if (comboBox_deparment.SelectedIndex >= 0)
                        {
                            dep = Convert.ToInt32(comboBox_deparment.SelectedValue.ToString());
                            

                                String SQL = "INSERT INTO instructer(deparment_id,name)VALUES(" + dep + ",'" + name + "')";
                                if (DBConnection.addDB(SQL))
                                {
                                    MessageBox.Show("You have succesfully added!");
                                    loadAdvisor();
                                }
                                else
                                {
                                    MessageBox.Show(SQL);
                                }
                           
                        }
                        else
                        {
                            MessageBox.Show("You should select a department!");
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
            comboBox_deparment.SelectedIndex = -1;

        }
        private void loadFaculty(int uni)
        {
            String SQL = "SELECT * FROM faculty WHERE university_id=" + uni;

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                comboBox_faculty.DataSource = data;
            }

            comboBox_deparment.SelectedIndex = -1;
        }
        private void loadDeparment(int fac)
        {
            String SQL = "SELECT * FROM department WHERE faculty_id=" + fac;

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                comboBox_deparment.DataSource = data;
            }

        }




        private void comboBox_university_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_university.SelectedIndex >= 0)
            {
                loadFaculty(Convert.ToInt32(comboBox_university.SelectedValue));
            }
        }

        private void comboBox_faculty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_faculty.SelectedIndex >= 0)
            {
                loadDeparment(Convert.ToInt32(comboBox_faculty.SelectedValue));
            }
        }


    }
}
