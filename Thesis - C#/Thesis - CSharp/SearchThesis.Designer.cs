namespace Thesis___CSharp
{
    partial class SearchThesis
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.university = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.university_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_author = new System.Windows.Forms.ComboBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_university = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.comboBox_advisor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_university = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_listall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.university,
            this.advisor,
            this.aid,
            this.author_id,
            this.university_id,
            this.instructer_id,
            this.uid,
            this.iid,
            this.name,
            this.author,
            this.subject,
            this.year,
            this.detail,
            this.text});
            this.dataGridView1.Location = new System.Drawing.Point(16, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(848, 159);
            this.dataGridView1.TabIndex = 75;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // university
            // 
            this.university.DataPropertyName = "university";
            this.university.HeaderText = "university";
            this.university.Name = "university";
            // 
            // advisor
            // 
            this.advisor.DataPropertyName = "advisor";
            this.advisor.HeaderText = "advisor";
            this.advisor.Name = "advisor";
            // 
            // aid
            // 
            this.aid.DataPropertyName = "aid";
            this.aid.HeaderText = "aid";
            this.aid.Name = "aid";
            this.aid.Visible = false;
            // 
            // author_id
            // 
            this.author_id.DataPropertyName = "author_id";
            this.author_id.HeaderText = "author_id";
            this.author_id.Name = "author_id";
            this.author_id.Visible = false;
            // 
            // university_id
            // 
            this.university_id.DataPropertyName = "university_id";
            this.university_id.HeaderText = "university_id";
            this.university_id.Name = "university_id";
            this.university_id.Visible = false;
            // 
            // instructer_id
            // 
            this.instructer_id.DataPropertyName = "instructer_id";
            this.instructer_id.HeaderText = "instructer_id";
            this.instructer_id.Name = "instructer_id";
            this.instructer_id.Visible = false;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "uid";
            this.uid.HeaderText = "uid";
            this.uid.Name = "uid";
            this.uid.Visible = false;
            // 
            // iid
            // 
            this.iid.DataPropertyName = "iid";
            this.iid.HeaderText = "iid";
            this.iid.Name = "iid";
            this.iid.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            // 
            // subject
            // 
            this.subject.DataPropertyName = "subject";
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            // 
            // detail
            // 
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "detail";
            this.detail.Name = "detail";
            // 
            // text
            // 
            this.text.DataPropertyName = "text";
            this.text.HeaderText = "text";
            this.text.Name = "text";
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(59, 60);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(154, 20);
            this.textBox_year.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Year";
            // 
            // textBox_subject
            // 
            this.textBox_subject.Location = new System.Drawing.Point(414, 30);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(154, 20);
            this.textBox_subject.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Subject";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(650, 25);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(214, 49);
            this.button_search.TabIndex = 70;
            this.button_search.Text = "Search Thesis";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox_author
            // 
            this.comboBox_author.DisplayMember = "name";
            this.comboBox_author.Location = new System.Drawing.Point(414, 64);
            this.comboBox_author.Name = "comboBox_author";
            this.comboBox_author.Size = new System.Drawing.Size(154, 21);
            this.comboBox_author.TabIndex = 69;
            this.comboBox_author.ValueMember = "id";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(59, 26);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(154, 20);
            this.textBox_name.TabIndex = 68;
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Location = new System.Drawing.Point(356, 67);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(38, 13);
            this.label_university.TabIndex = 67;
            this.label_university.Text = "Author";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(13, 32);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 66;
            this.label_name.Text = "Name";
            // 
            // comboBox_advisor
            // 
            this.comboBox_advisor.DisplayMember = "name";
            this.comboBox_advisor.Location = new System.Drawing.Point(59, 98);
            this.comboBox_advisor.Name = "comboBox_advisor";
            this.comboBox_advisor.Size = new System.Drawing.Size(154, 21);
            this.comboBox_advisor.TabIndex = 77;
            this.comboBox_advisor.ValueMember = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Advisor";
            // 
            // comboBox_university
            // 
            this.comboBox_university.DisplayMember = "name";
            this.comboBox_university.Location = new System.Drawing.Point(414, 99);
            this.comboBox_university.Name = "comboBox_university";
            this.comboBox_university.Size = new System.Drawing.Size(154, 21);
            this.comboBox_university.TabIndex = 79;
            this.comboBox_university.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "University";
            // 
            // button_listall
            // 
            this.button_listall.Location = new System.Drawing.Point(650, 80);
            this.button_listall.Name = "button_listall";
            this.button_listall.Size = new System.Drawing.Size(214, 50);
            this.button_listall.TabIndex = 80;
            this.button_listall.Text = "List All Thesis";
            this.button_listall.UseVisualStyleBackColor = true;
            this.button_listall.Click += new System.EventHandler(this.button_listall_Click);
            // 
            // SearchThesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 332);
            this.Controls.Add(this.button_listall);
            this.Controls.Add(this.comboBox_university);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_advisor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.comboBox_author);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_name);
            this.Name = "SearchThesis";
            this.Text = "SearchThesis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_author;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ComboBox comboBox_advisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_university;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn university;
        private System.Windows.Forms.DataGridViewTextBoxColumn advisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn university_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.Button button_listall;
    }
}