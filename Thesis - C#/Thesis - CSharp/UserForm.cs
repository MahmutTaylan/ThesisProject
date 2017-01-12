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
    public partial class UserForm : Form
    {

        public UserForm()
        {
            InitializeComponent();
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAuthorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AuthorForm author = new AuthorForm();
            author.Visible = true;
        }

        private void addConsultantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvisorForm author = new AdvisorForm();
            author.Visible = true;
        }

        private void addUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversityForm author = new UniversityForm();
            author.Visible = true;
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentForm author = new DepartmentForm();
            author.Visible = true;
        }

        private void addFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyForm author = new FacultyForm();
            author.Visible = true;
        }

        private void addThesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddThesisForm add = new AddThesisForm();
            add.Visible = true;
        }

        private void updateThesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateThesisForm add = new UpdateThesisForm();
            add.Visible = true;
        }

        private void searchThesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchThesis add = new SearchThesis();
            add.Visible = true;
        }
    }
}
