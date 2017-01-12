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
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
            loadUniversity();
            loadUniversityGrid();
        }
        private void loadUniversityGrid()
        {
            String SQL = @"SELECT faculty.id, faculty.name, faculty.university_id,
                            university.id as 'uid', university.name as 'university'
                            FROM faculty 
                            INNER JOIN university ON faculty.university_id= university.id";

            DataTable data = DBConnection.selectDB(SQL);

            if (data != null)
            {
                dataGridView1.DataSource = data;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int uni = 0;
            String name;
            if (!textBox_name.Text.Equals(""))
            {
                name = textBox_name.Text;
                if (comboBox_university.SelectedIndex >= 0)
                {
                    uni = Convert.ToInt32(comboBox_university.SelectedValue.ToString());

                    String SQL = "INSERT INTO faculty(university_id,name)VALUES(" + uni + ",'" + name + "')";
                    if (DBConnection.addDB(SQL))
                    {
                        MessageBox.Show("You have succesfully added!");
                        loadUniversityGrid();
                    }
                    else
                    {
                        MessageBox.Show(SQL);
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


        }
    }
}
