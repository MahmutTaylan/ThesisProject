using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thesis___CSharp.Process;


namespace Thesis___CSharp
{
    public partial class SearchThesis : Form
    {

        int thesisId = 0;
        public SearchThesis()
        {
            InitializeComponent();
            list();
            loadAuthor();
            loadAdvisor();
            loadUniversity();
        }

        public void list() 
        {
            String SQL = @"SELECT thesis.id, thesis.name, thesis.subjects, thesis.years, thesis.texts, thesis.detail, thesis.author_id, 
							author.university_id, author.instructer_id, author.id as 'aid', author.name as author, 
                            university.id as 'uid', university.name as'university',
                            instructer.id as 'iid', instructer.name as 'advisor' 
                            FROM thesis 
                            INNER JOIN author ON thesis.author_id= author.id 
                            INNER JOIN university ON author.university_id= university.id 
                            INNER JOIN instructer ON author.instructer_id= instructer.id";
   
            DataTable table = DBConnection.selectDB(SQL);

            if (table != null)
            {
                dataGridView1.DataSource = table;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {

            String name = textBox_name.Text;
            String subject = textBox_subject.Text;
            String year = textBox_year.Text;
            int authorID = Convert.ToInt32(comboBox_author.SelectedValue);
            int advisorID = Convert.ToInt32(comboBox_advisor.SelectedValue);
            int universityID = Convert.ToInt32(comboBox_university.SelectedValue);

            

            String SQL = @"SELECT thesis.id, thesis.name, thesis.subjects, thesis.years, thesis.texts, thesis.detail, thesis.author_id, 
							author.university_id, author.instructer_id, author.id as 'aid', author.name as author, 
                            university.id as 'uid', university.name as'university',
                            instructer.id as 'iid', instructer.name as 'advisor' 
                            FROM thesis 
                            INNER JOIN author ON thesis.author_id= author.id 
                            INNER JOIN university ON author.university_id= university.id 
                            INNER JOIN instructer ON author.instructer_id= instructer.id 
                            WHERE thesis.name like '%" + name +
                            "%' AND thesis.subjects like '%" + subject +
                            "%' AND thesis.years like '%" + year +
                            "%' AND author.id =" + authorID +
                            " AND author.university_id =" + universityID +
                            " AND author.instructer_id =" + advisorID;


            DataTable table = DBConnection.selectDB(SQL);

            if (table != null) {
                dataGridView1.DataSource = table;
            }
        }


        private void loadAdvisor()
        {
            String SQL = "SELECT * FROM instructer";

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                comboBox_advisor.DataSource = data;
            }
        }
        private void loadAuthor()
        {
            String SQL = "SELECT * FROM author";

            DataTable data = DBConnection.selectDB(SQL);
            if (data != null)
            {
                comboBox_author.DataSource = data;
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

        private void button_listall_Click(object sender, EventArgs e)
        {
            list();
        }

        

    }
}
