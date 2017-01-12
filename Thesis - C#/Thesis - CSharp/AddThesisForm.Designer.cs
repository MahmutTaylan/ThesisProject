namespace Thesis___CSharp
{
    partial class AddThesisForm
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
            this.comboBox_author = new System.Windows.Forms.ComboBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_university = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_detail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_file = new System.Windows.Forms.TextBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(15, 282);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(233, 23);
            this.button_add.TabIndex = 42;
            this.button_add.Text = "Add Thesis";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_author
            // 
            this.comboBox_author.DisplayMember = "name";
            this.comboBox_author.Location = new System.Drawing.Point(62, 120);
            this.comboBox_author.Name = "comboBox_author";
            this.comboBox_author.Size = new System.Drawing.Size(186, 21);
            this.comboBox_author.TabIndex = 41;
            this.comboBox_author.ValueMember = "id";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(62, 24);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(186, 20);
            this.textBox_name.TabIndex = 40;
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Location = new System.Drawing.Point(12, 123);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(38, 13);
            this.label_university.TabIndex = 39;
            this.label_university.Text = "Author";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 27);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 38;
            this.label_name.Text = "Name";
            // 
            // textBox_subject
            // 
            this.textBox_subject.Location = new System.Drawing.Point(62, 56);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(186, 20);
            this.textBox_subject.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Subject";
            // 
            // textBox_detail
            // 
            this.textBox_detail.Location = new System.Drawing.Point(15, 166);
            this.textBox_detail.Multiline = true;
            this.textBox_detail.Name = "textBox_detail";
            this.textBox_detail.Size = new System.Drawing.Size(233, 55);
            this.textBox_detail.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Detail";
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(263, 56);
            this.textBox_text.Multiline = true;
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(257, 249);
            this.textBox_text.TabIndex = 48;
            this.textBox_text.TextChanged += new System.EventHandler(this.textBox_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Text";
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(62, 87);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(186, 20);
            this.textBox_year.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Year";
            // 
            // textBox_file
            // 
            this.textBox_file.Location = new System.Drawing.Point(15, 256);
            this.textBox_file.Name = "textBox_file";
            this.textBox_file.Size = new System.Drawing.Size(233, 20);
            this.textBox_file.TabIndex = 84;
            // 
            // button_upload
            // 
            this.button_upload.Location = new System.Drawing.Point(15, 227);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(85, 23);
            this.button_upload.TabIndex = 83;
            this.button_upload.Text = "file upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // AddThesisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 323);
            this.Controls.Add(this.textBox_file);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.textBox_detail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_author);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_name);
            this.Name = "AddThesisForm";
            this.Text = "AddThesisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_author;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_file;
        private System.Windows.Forms.Button button_upload;
    }
}