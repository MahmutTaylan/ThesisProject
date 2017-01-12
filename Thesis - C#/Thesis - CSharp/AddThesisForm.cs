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
    public partial class AddThesisForm : Form
    {
        public AddThesisForm()
        {
            InitializeComponent();
            loadAuthor();
        }

        public void loadAuthor() {
            String SQL = "SELECT * FROM author";
            DataTable data = DBConnection.selectDB(SQL);

            if (data != null) {
                comboBox_author.DataSource = data;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            String name;
            String subject;
            String year;
            String detail;
            String text;
            int author_id = 0;
            String file;

            if (!textBox_name.Text.Equals(""))
            {
                name = textBox_name.Text;
                if (!textBox_subject.Text.Equals(""))
                {
                    subject = textBox_subject.Text;
                    if (!textBox_year.Text.Equals(""))
                    {
                        year = textBox_year.Text;
                        if (!textBox_detail.Text.Equals(""))
                        {
                            detail = textBox_detail.Text;
                            if (!textBox_text.Text.Equals(""))
                            {
                                text = textBox_text.Text;
                                if (comboBox_author.SelectedIndex >= 0)
                                {
                                    if (!textBox_file.Text.Equals(""))
                                    {
                                        file = textBox_file.Text;
                                        author_id = Convert.ToInt32(comboBox_author.SelectedValue.ToString());

                                        String SQL = "INSERT INTO thesis(name,subjects,years,detail,texts,author_id,paths)VALUES('" + name + "','" + subject + "','" + year + "','" + detail + "','" + text + "'," + author_id + ",'" + file + "')";
                                        if (DBConnection.addDB(SQL))
                                        {
                                            MessageBox.Show("Thesis succesfully added.!");
                                        }
                                        else
                                        {
                                            MessageBox.Show(SQL);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Select a file!");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Author can not be null!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Text can not be null!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Detail can not be null!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Year can not be null!");
                    }
                }
                else
                {
                    MessageBox.Show("Subject can not be null!");
                }
            }
            else {
                MessageBox.Show("Name can not be null!");
            }
        }


        private void textBox_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            String input = string.Empty;
            String strFileName = "";

            OpenFileDialog dialog = new OpenFileDialog();


            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";



            dialog.InitialDirectory = "C:";
            dialog.Title = "Select a text file";


            if (dialog.ShowDialog() == DialogResult.OK)
                strFileName = dialog.FileName;

            if (strFileName == String.Empty)
                return;
            textBox_file.Text = strFileName;
        }

    }
}
