namespace Thesis___CSharp
{
    partial class DepartmentForm
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
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_faculty = new System.Windows.Forms.ComboBox();
            this.comboBox_university = new System.Windows.Forms.ComboBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(281, 156);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(229, 23);
            this.button_add.TabIndex = 31;
            this.button_add.Text = "Add Department";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_faculty
            // 
            this.comboBox_faculty.DisplayMember = "name";
            this.comboBox_faculty.Location = new System.Drawing.Point(356, 101);
            this.comboBox_faculty.Name = "comboBox_faculty";
            this.comboBox_faculty.Size = new System.Drawing.Size(154, 21);
            this.comboBox_faculty.TabIndex = 30;
            this.comboBox_faculty.ValueMember = "id";
            // 
            // comboBox_university
            // 
            this.comboBox_university.DisplayMember = "name";
            this.comboBox_university.Location = new System.Drawing.Point(356, 53);
            this.comboBox_university.Name = "comboBox_university";
            this.comboBox_university.Size = new System.Drawing.Size(154, 21);
            this.comboBox_university.TabIndex = 29;
            this.comboBox_university.ValueMember = "id";
            this.comboBox_university.SelectedIndexChanged += new System.EventHandler(this.comboBox_university_SelectedIndexChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(356, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(154, 20);
            this.textBox_name.TabIndex = 28;
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Location = new System.Drawing.Point(278, 109);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(41, 13);
            this.label_faculty.TabIndex = 27;
            this.label_faculty.Text = "Faculty";
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Location = new System.Drawing.Point(278, 56);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(53, 13);
            this.label_university.TabIndex = 26;
            this.label_university.Text = "University";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(278, 15);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 25;
            this.label_name.Text = "Name";
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
            this.faculty_id,
            this.fid,
            this.name,
            this.faculty});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 167);
            this.dataGridView1.TabIndex = 24;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // faculty_id
            // 
            this.faculty_id.DataPropertyName = "faculty_id";
            this.faculty_id.HeaderText = "department_id";
            this.faculty_id.Name = "faculty_id";
            this.faculty_id.ReadOnly = true;
            this.faculty_id.Visible = false;
            // 
            // fid
            // 
            this.fid.DataPropertyName = "fid";
            this.fid.HeaderText = "did";
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            this.fid.Visible = false;
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
            this.faculty.HeaderText = "Department";
            this.faculty.Name = "faculty";
            this.faculty.ReadOnly = true;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 198);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_faculty);
            this.Controls.Add(this.comboBox_university);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_faculty;
        private System.Windows.Forms.ComboBox comboBox_university;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculty;
    }
}