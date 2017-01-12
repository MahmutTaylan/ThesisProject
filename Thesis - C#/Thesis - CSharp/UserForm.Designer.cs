namespace Thesis___CSharp
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConsultantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUniversityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addThesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchThesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateThesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.thesisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAuthorToolStripMenuItem,
            this.addConsultantToolStripMenuItem,
            this.addUniversityToolStripMenuItem,
            this.addFacultyToolStripMenuItem,
            this.addDepartmentToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // addAuthorToolStripMenuItem
            // 
            this.addAuthorToolStripMenuItem.Name = "addAuthorToolStripMenuItem";
            this.addAuthorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addAuthorToolStripMenuItem.Text = "Add Author";
            this.addAuthorToolStripMenuItem.Click += new System.EventHandler(this.addAuthorToolStripMenuItem_Click_1);
            // 
            // addConsultantToolStripMenuItem
            // 
            this.addConsultantToolStripMenuItem.Name = "addConsultantToolStripMenuItem";
            this.addConsultantToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addConsultantToolStripMenuItem.Text = "Add Advisor";
            this.addConsultantToolStripMenuItem.Click += new System.EventHandler(this.addConsultantToolStripMenuItem_Click);
            // 
            // addUniversityToolStripMenuItem
            // 
            this.addUniversityToolStripMenuItem.Name = "addUniversityToolStripMenuItem";
            this.addUniversityToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addUniversityToolStripMenuItem.Text = "Add University";
            this.addUniversityToolStripMenuItem.Click += new System.EventHandler(this.addUniversityToolStripMenuItem_Click);
            // 
            // addFacultyToolStripMenuItem
            // 
            this.addFacultyToolStripMenuItem.Name = "addFacultyToolStripMenuItem";
            this.addFacultyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addFacultyToolStripMenuItem.Text = "Add Faculty";
            this.addFacultyToolStripMenuItem.Click += new System.EventHandler(this.addFacultyToolStripMenuItem_Click);
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // thesisToolStripMenuItem
            // 
            this.thesisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addThesisToolStripMenuItem,
            this.searchThesisToolStripMenuItem,
            this.updateThesisToolStripMenuItem});
            this.thesisToolStripMenuItem.Name = "thesisToolStripMenuItem";
            this.thesisToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.thesisToolStripMenuItem.Text = "Thesis";
            // 
            // addThesisToolStripMenuItem
            // 
            this.addThesisToolStripMenuItem.Name = "addThesisToolStripMenuItem";
            this.addThesisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addThesisToolStripMenuItem.Text = "Add Thesis";
            this.addThesisToolStripMenuItem.Click += new System.EventHandler(this.addThesisToolStripMenuItem_Click);
            // 
            // searchThesisToolStripMenuItem
            // 
            this.searchThesisToolStripMenuItem.Name = "searchThesisToolStripMenuItem";
            this.searchThesisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchThesisToolStripMenuItem.Text = "Search Thesis";
            this.searchThesisToolStripMenuItem.Click += new System.EventHandler(this.searchThesisToolStripMenuItem_Click);
            // 
            // updateThesisToolStripMenuItem
            // 
            this.updateThesisToolStripMenuItem.Name = "updateThesisToolStripMenuItem";
            this.updateThesisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateThesisToolStripMenuItem.Text = "Update Thesis";
            this.updateThesisToolStripMenuItem.Click += new System.EventHandler(this.updateThesisToolStripMenuItem_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "UserFrame";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addConsultantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUniversityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFacultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thesisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addThesisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchThesisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateThesisToolStripMenuItem;
    }
}