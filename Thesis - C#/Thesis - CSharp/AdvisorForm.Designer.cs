namespace Thesis___CSharp
{
    partial class AdvisorForm
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
            this.comboBox_deparment = new System.Windows.Forms.ComboBox();
            this.comboBox_faculty = new System.Windows.Forms.ComboBox();
            this.comboBox_university = new System.Windows.Forms.ComboBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_deparment = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.did = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(281, 189);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(229, 23);
            this.button_add.TabIndex = 23;
            this.button_add.Text = "Add Advisor";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_deparment
            // 
            this.comboBox_deparment.DisplayMember = "name";
            this.comboBox_deparment.Location = new System.Drawing.Point(356, 150);
            this.comboBox_deparment.Name = "comboBox_deparment";
            this.comboBox_deparment.Size = new System.Drawing.Size(154, 21);
            this.comboBox_deparment.TabIndex = 21;
            this.comboBox_deparment.ValueMember = "id";
            // 
            // comboBox_faculty
            // 
            this.comboBox_faculty.DisplayMember = "name";
            this.comboBox_faculty.Location = new System.Drawing.Point(356, 109);
            this.comboBox_faculty.Name = "comboBox_faculty";
            this.comboBox_faculty.Size = new System.Drawing.Size(154, 21);
            this.comboBox_faculty.TabIndex = 20;
            this.comboBox_faculty.ValueMember = "id";
            this.comboBox_faculty.SelectedIndexChanged += new System.EventHandler(this.comboBox_faculty_SelectedIndexChanged_1);
            // 
            // comboBox_university
            // 
            this.comboBox_university.DisplayMember = "name";
            this.comboBox_university.Location = new System.Drawing.Point(356, 70);
            this.comboBox_university.Name = "comboBox_university";
            this.comboBox_university.Size = new System.Drawing.Size(154, 21);
            this.comboBox_university.TabIndex = 19;
            this.comboBox_university.ValueMember = "id";
            this.comboBox_university.SelectedIndexChanged += new System.EventHandler(this.comboBox_university_SelectedIndexChanged_1);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(356, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(154, 20);
            this.textBox_name.TabIndex = 18;
            // 
            // label_deparment
            // 
            this.label_deparment.AutoSize = true;
            this.label_deparment.Location = new System.Drawing.Point(278, 153);
            this.label_deparment.Name = "label_deparment";
            this.label_deparment.Size = new System.Drawing.Size(59, 13);
            this.label_deparment.TabIndex = 16;
            this.label_deparment.Text = "Deparment";
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Location = new System.Drawing.Point(278, 117);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(41, 13);
            this.label_faculty.TabIndex = 15;
            this.label_faculty.Text = "Faculty";
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Location = new System.Drawing.Point(278, 73);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(53, 13);
            this.label_university.TabIndex = 14;
            this.label_university.Text = "University";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(278, 29);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 13;
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
            this.department_id,
            this.did,
            this.name,
            this.department});
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 183);
            this.dataGridView1.TabIndex = 12;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // department_id
            // 
            this.department_id.DataPropertyName = "department_id";
            this.department_id.HeaderText = "department_id";
            this.department_id.Name = "department_id";
            this.department_id.ReadOnly = true;
            this.department_id.Visible = false;
            // 
            // did
            // 
            this.did.DataPropertyName = "did";
            this.did.HeaderText = "did";
            this.did.Name = "did";
            this.did.ReadOnly = true;
            this.did.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // AdvisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 224);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_deparment);
            this.Controls.Add(this.comboBox_faculty);
            this.Controls.Add(this.comboBox_university);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_deparment);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdvisorForm";
            this.Text = "AdvisorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_deparment;
        private System.Windows.Forms.ComboBox comboBox_faculty;
        private System.Windows.Forms.ComboBox comboBox_university;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_deparment;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn did;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
    }
}