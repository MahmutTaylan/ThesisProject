namespace Thesis___CSharp
{
    partial class AuthorForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_name = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_deparment = new System.Windows.Forms.Label();
            this.label_instructer = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_university = new System.Windows.Forms.ComboBox();
            this.comboBox_faculty = new System.Windows.Forms.ComboBox();
            this.comboBox_deparment = new System.Windows.Forms.ComboBox();
            this.comboBox_instructer = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.university_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.did = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.university = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.university_id,
            this.faculty_id,
            this.department_id,
            this.instructer_id,
            this.uid,
            this.fid,
            this.did,
            this.aid,
            this.name,
            this.faculty,
            this.university,
            this.department,
            this.advisor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(22, 254);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Location = new System.Drawing.Point(22, 295);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(53, 13);
            this.label_university.TabIndex = 2;
            this.label_university.Text = "University";
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Location = new System.Drawing.Point(22, 342);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(41, 13);
            this.label_faculty.TabIndex = 3;
            this.label_faculty.Text = "Faculty";
            // 
            // label_deparment
            // 
            this.label_deparment.AutoSize = true;
            this.label_deparment.Location = new System.Drawing.Point(278, 254);
            this.label_deparment.Name = "label_deparment";
            this.label_deparment.Size = new System.Drawing.Size(59, 13);
            this.label_deparment.TabIndex = 4;
            this.label_deparment.Text = "Deparment";
            // 
            // label_instructer
            // 
            this.label_instructer.AutoSize = true;
            this.label_instructer.Location = new System.Drawing.Point(278, 295);
            this.label_instructer.Name = "label_instructer";
            this.label_instructer.Size = new System.Drawing.Size(51, 13);
            this.label_instructer.TabIndex = 5;
            this.label_instructer.Text = "Instructer";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(86, 251);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(154, 20);
            this.textBox_name.TabIndex = 6;
            // 
            // comboBox_university
            // 
            this.comboBox_university.DisplayMember = "name";
            this.comboBox_university.Location = new System.Drawing.Point(86, 292);
            this.comboBox_university.Name = "comboBox_university";
            this.comboBox_university.Size = new System.Drawing.Size(154, 21);
            this.comboBox_university.TabIndex = 7;
            this.comboBox_university.ValueMember = "id";
            this.comboBox_university.SelectedIndexChanged += new System.EventHandler(this.comboBox_university_SelectedIndexChanged);
            // 
            // comboBox_faculty
            // 
            this.comboBox_faculty.DisplayMember = "name";
            this.comboBox_faculty.Location = new System.Drawing.Point(86, 334);
            this.comboBox_faculty.Name = "comboBox_faculty";
            this.comboBox_faculty.Size = new System.Drawing.Size(154, 21);
            this.comboBox_faculty.TabIndex = 8;
            this.comboBox_faculty.ValueMember = "id";
            this.comboBox_faculty.SelectedIndexChanged += new System.EventHandler(this.comboBox_faculty_SelectedIndexChanged);
            // 
            // comboBox_deparment
            // 
            this.comboBox_deparment.DisplayMember = "name";
            this.comboBox_deparment.Location = new System.Drawing.Point(356, 251);
            this.comboBox_deparment.Name = "comboBox_deparment";
            this.comboBox_deparment.Size = new System.Drawing.Size(154, 21);
            this.comboBox_deparment.TabIndex = 9;
            this.comboBox_deparment.ValueMember = "id";
            this.comboBox_deparment.SelectedIndexChanged += new System.EventHandler(this.comboBox_deparment_SelectedIndexChanged);
            // 
            // comboBox_instructer
            // 
            this.comboBox_instructer.DisplayMember = "name";
            this.comboBox_instructer.Location = new System.Drawing.Point(356, 287);
            this.comboBox_instructer.Name = "comboBox_instructer";
            this.comboBox_instructer.Size = new System.Drawing.Size(154, 21);
            this.comboBox_instructer.TabIndex = 10;
            this.comboBox_instructer.ValueMember = "id";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(281, 332);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(229, 23);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Add Author";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // university_id
            // 
            this.university_id.DataPropertyName = "university_id";
            this.university_id.HeaderText = "university_id";
            this.university_id.Name = "university_id";
            this.university_id.ReadOnly = true;
            this.university_id.Visible = false;
            // 
            // faculty_id
            // 
            this.faculty_id.DataPropertyName = "faculty_id";
            this.faculty_id.HeaderText = "faculty_id";
            this.faculty_id.Name = "faculty_id";
            this.faculty_id.ReadOnly = true;
            this.faculty_id.Visible = false;
            // 
            // department_id
            // 
            this.department_id.DataPropertyName = "department_id";
            this.department_id.HeaderText = "department_id";
            this.department_id.Name = "department_id";
            this.department_id.ReadOnly = true;
            this.department_id.Visible = false;
            // 
            // instructer_id
            // 
            this.instructer_id.DataPropertyName = "instructer_id";
            this.instructer_id.HeaderText = "instructer_id";
            this.instructer_id.Name = "instructer_id";
            this.instructer_id.ReadOnly = true;
            this.instructer_id.Visible = false;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "uid";
            this.uid.HeaderText = "uid";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Visible = false;
            // 
            // fid
            // 
            this.fid.DataPropertyName = "fid";
            this.fid.HeaderText = "fid";
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            this.fid.Visible = false;
            // 
            // did
            // 
            this.did.DataPropertyName = "did";
            this.did.HeaderText = "did";
            this.did.Name = "did";
            this.did.ReadOnly = true;
            this.did.Visible = false;
            // 
            // aid
            // 
            this.aid.DataPropertyName = "aid";
            this.aid.HeaderText = "aid";
            this.aid.Name = "aid";
            this.aid.ReadOnly = true;
            this.aid.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // faculty
            // 
            this.faculty.DataPropertyName = "faculty";
            this.faculty.HeaderText = "Faculty";
            this.faculty.Name = "faculty";
            this.faculty.ReadOnly = true;
            // 
            // university
            // 
            this.university.DataPropertyName = "university";
            this.university.HeaderText = "University";
            this.university.Name = "university";
            this.university.ReadOnly = true;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // advisor
            // 
            this.advisor.DataPropertyName = "advisor";
            this.advisor.HeaderText = "Advisor";
            this.advisor.Name = "advisor";
            this.advisor.ReadOnly = true;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 391);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_instructer);
            this.Controls.Add(this.comboBox_deparment);
            this.Controls.Add(this.comboBox_faculty);
            this.Controls.Add(this.comboBox_university);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_instructer);
            this.Controls.Add(this.label_deparment);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AuthorForm";
            this.Text = "AuthorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_deparment;
        private System.Windows.Forms.Label label_instructer;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_university;
        private System.Windows.Forms.ComboBox comboBox_faculty;
        private System.Windows.Forms.ComboBox comboBox_deparment;
        private System.Windows.Forms.ComboBox comboBox_instructer;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn university_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn did;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn university;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn advisor;
    }
}