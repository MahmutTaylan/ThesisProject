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
    public partial class AuthorForm : Form
    {

        public AuthorForm()
        {
            InitializeComponent();
            loadUniversity();
            loadAuthor();
        }

        private void loadAuthor()
        {
            String SQL = @"SELECT author.id, author.university_id, author.faculty_id, author.department_id, author.instructer_id, author.name, 
                            university.id as 'uid', university.name as 'university', 
                            faculty.id as 'fid', faculty.name as 'faculty', 
                            department.id as 'did', department.name as 'department', 
                            instructer.id as 'aid', instructer.name as 'advisor' 
                            FROM author 
                            INNER JOIN university ON author.university_id= university.id 
                            INNER JOIN faculty ON author.faculty_id= faculty.id 
                            INNER JOIN department ON author.department_id= department.id 
                            INNER JOIN instructer ON author.instructer_id= instructer.id";
            

            DataTable data = DBConnection.selectDB(SQL);
            
            if(data != null){
                dataGridView1.DataSource = data;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            int uni = 0;
            int fac = 0;
            int dep = 0;
            int ins = 0;
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
                            if (comboBox_instructer.SelectedIndex >= 0)
                            {
                                ins = Convert.ToInt32(comboBox_instructer.SelectedValue.ToString());

                                String SQL = "INSERT INTO author(university_id,faculty_id,department_id,instructer_id,name)VALUES(" + uni + "," + fac + "," + dep + "," + ins + ",'" + name + "')";
                                if (DBConnection.addDB(SQL))
                                {
                                    MessageBox.Show("You have succesfully added!");
                                    loadAuthor();
                                }
                                else {
                                    MessageBox.Show("Failed");
                                }
                            }
                            else
                            {
                               
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
                else {
                    MessageBox.Show("You should select a university!");
                }
            }
            else {
                MessageBox.Show("Name field can not be null!");
            }
            
        }

        private void loadUniversity() {
            String SQL = "SELECT * FROM university";

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null) {
                comboBox_university.DataSource = data;
            }

            comboBox_faculty.SelectedIndex = -1;
            comboBox_deparment.SelectedIndex = -1;
            comboBox_instructer.SelectedIndex = -1;

        }
        private void loadFaculty(int uni) {
            String SQL = "SELECT * FROM faculty WHERE university_id=" + uni;

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                comboBox_faculty.DataSource = data;
            }

            comboBox_deparment.SelectedIndex = -1;
            comboBox_instructer.SelectedIndex = -1;
        }
        private void loadDeparment(int fac) {
            String SQL = "SELECT * FROM department WHERE faculty_id=" + fac;

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                comboBox_deparment.DataSource = data;
            }

            comboBox_instructer.SelectedIndex = -1;
        }
        private void loadInstrcuter(int dep) {
            String SQL = "SELECT * FROM instructer WHERE deparment_id=" + dep;

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                comboBox_instructer.DataSource = data;
            }
        }

        private void comboBox_university_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_university.SelectedIndex >= 0) {
                loadFaculty(Convert.ToInt32(comboBox_university.SelectedValue));
            }
        }

        private void comboBox_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_faculty.SelectedIndex >= 0)
            {
                loadDeparment(Convert.ToInt32(comboBox_faculty.SelectedValue));
            }
        }

        private void comboBox_deparment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_deparment.SelectedIndex >= 0)
            {
                loadInstrcuter(Convert.ToInt32(comboBox_deparment.SelectedValue));
            }
        }
    }
}
