namespace HR_Departments
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpList = new System.Windows.Forms.ListBox();
            this.DepartmentsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Experience = new System.Windows.Forms.TextBox();
            this.Add_but = new System.Windows.Forms.Button();
            this.Edit_but = new System.Windows.Forms.Button();
            this.Del_but = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EmpList);
            this.groupBox1.Controls.Add(this.DepartmentsList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сотрудники";
            // 
            // EmpList
            // 
            this.EmpList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmpList.FormattingEnabled = true;
            this.EmpList.ItemHeight = 20;
            this.EmpList.Location = new System.Drawing.Point(3, 82);
            this.EmpList.Name = "EmpList";
            this.EmpList.ScrollAlwaysVisible = true;
            this.EmpList.Size = new System.Drawing.Size(240, 464);
            this.EmpList.TabIndex = 2;
            this.EmpList.SelectedIndexChanged += new System.EventHandler(this.EmpList_SelectedIndexChanged);
            // 
            // DepartmentsList
            // 
            this.DepartmentsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DepartmentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentsList.FormattingEnabled = true;
            this.DepartmentsList.Location = new System.Drawing.Point(3, 43);
            this.DepartmentsList.Name = "DepartmentsList";
            this.DepartmentsList.Size = new System.Drawing.Size(240, 28);
            this.DepartmentsList.TabIndex = 1;
            this.DepartmentsList.SelectedIndexChanged += new System.EventHandler(this.DepartmentsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подразделения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(246, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(163, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Система управления отделом кадров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "HR_DEPARTMENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Del_but);
            this.groupBox3.Controls.Add(this.Edit_but);
            this.groupBox3.Controls.Add(this.Add_but);
            this.groupBox3.Controls.Add(this.Experience);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Position);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Birthday);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.LName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.FName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(732, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 414);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Photo);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(246, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(486, 414);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Photo";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Photo
            // 
            this.Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Photo.Image = global::HR_Departments.Properties.Resources.unnamed_768x768;
            this.Photo.Location = new System.Drawing.Point(3, 23);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(480, 388);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "First name:";
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(10, 78);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(230, 27);
            this.FName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Last Name:";
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(10, 131);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(230, 27);
            this.LName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Birth Date:";
            // 
            // Birthday
            // 
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.Location = new System.Drawing.Point(10, 190);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(230, 21);
            this.Birthday.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Position:";
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(110, 227);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(130, 27);
            this.Position.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Experience:";
            // 
            // Experience
            // 
            this.Experience.Location = new System.Drawing.Point(110, 260);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(130, 27);
            this.Experience.TabIndex = 9;
            // 
            // Add_but
            // 
            this.Add_but.Location = new System.Drawing.Point(10, 310);
            this.Add_but.Name = "Add_but";
            this.Add_but.Size = new System.Drawing.Size(93, 37);
            this.Add_but.TabIndex = 10;
            this.Add_but.Text = "Add";
            this.Add_but.UseVisualStyleBackColor = true;
            this.Add_but.Click += new System.EventHandler(this.Add_but_Click);
            // 
            // Edit_but
            // 
            this.Edit_but.Location = new System.Drawing.Point(110, 310);
            this.Edit_but.Name = "Edit_but";
            this.Edit_but.Size = new System.Drawing.Size(95, 37);
            this.Edit_but.TabIndex = 11;
            this.Edit_but.Text = "Edit";
            this.Edit_but.UseVisualStyleBackColor = true;
            // 
            // Del_but
            // 
            this.Del_but.Location = new System.Drawing.Point(55, 353);
            this.Del_but.Name = "Del_but";
            this.Del_but.Size = new System.Drawing.Size(93, 35);
            this.Del_but.TabIndex = 12;
            this.Del_but.Text = "Delete";
            this.Del_but.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 549);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox DepartmentsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox EmpList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Del_but;
        private System.Windows.Forms.Button Edit_but;
        private System.Windows.Forms.Button Add_but;
        private System.Windows.Forms.TextBox Experience;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Label label7;
    }
}

