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
    public partial class UpdateThesisForm : Form
    {

        int thesisId = 0;
        public UpdateThesisForm()
        {
            InitializeComponent();
            loadThesis();
        }

        public void loadAuthor()
        {
            String SQL = "SELECT * FROM author";
            DataTable data = DBConnection.selectDB(SQL);

            if (data != null)
            {
                comboBox_author.DataSource = data;
            }
        }

        private void loadThesis() {
            String SQL = @"SELECT thesis.id, thesis.name, thesis.subject, thesis.year, thesis.detail, thesis.text, author.id as aid, author.name as 'author' FROM thesis
                            INNER JOIN author ON thesis.author_id= author.id ";

            DataTable data = DBConnection.selectDB(SQL);

            if (data != null)
            {
                dataGridView1.DataSource = data;
            }
            else {
                MessageBox.Show("null");
            }

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            thesisId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show(thesisId.ToString());
            load(thesisId);
        }

        private void load(int id) {
            String SQL = "SELECT * FROM thesis WHERE id=" + id;
            DataTable data = DBConnection.selectDB(SQL);
            loadAuthor();
            if (data != null) {
                textBox_name.Text = data.Rows[0][2].ToString();
                textBox_subject.Text = data.Rows[0][6].ToString();
                textBox_detail.Text = data.Rows[0][4].ToString();
                textBox_year.Text = data.Rows[0][3].ToString();
                textBox_text.Text = data.Rows[0][5].ToString();

                comboBox_author.SelectedValue = data.Rows[0][1].ToString();
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            String SQLDELETE = "DELETE FROM thesis WHERE id = " + thesisId;
            DBConnection.deleteDB(SQLDELETE);

            String name = textBox_name.Text;
            String year = textBox_year.Text;
            String subject = textBox_subject.Text;
            String detail = textBox_detail.Text;
            String text = textBox_text.Text;
            int author_id = Convert.ToInt32(comboBox_author.SelectedValue);

            String SQL = "INSERT INTO thesis(id,name,subjects,years,detail,texts,author_id)VALUES(" + thesisId + ",'" + name + "','" + subject + "','" + year + "','" + detail + "','" + text + "'," + author_id + ")";
            if (DBConnection.addDB(SQL))
            {
                MessageBox.Show("Thesis succesfully updated.!");
                loadThesis();
            }
            else
            {
                MessageBox.Show(SQL);
            }
        }



    }
}
