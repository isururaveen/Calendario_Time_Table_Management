namespace TimeTableM
{
    partial class AddStudent
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label Faculty;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProgramme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.cmbSubGrpNum = new System.Windows.Forms.ComboBox();
            this.cmbGrpNo = new System.Windows.Forms.ComboBox();
            this.cmbAcademicSemYear = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubGrpID = new System.Windows.Forms.TextBox();
            this.txtGrpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            Faculty = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(31, 385);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(149, 28);
            label4.TabIndex = 4;
            label4.Text = "Programme";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(31, 536);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(235, 28);
            label5.TabIndex = 11;
            label5.Text = "Sub Group Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(31, 460);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(184, 28);
            label6.TabIndex = 12;
            label6.Text = "Group Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(31, 692);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(168, 28);
            label7.TabIndex = 13;
            label7.Text = "Sub Group ID";
            label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(31, 617);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(117, 28);
            label8.TabIndex = 14;
            label8.Text = "Group ID";
            // 
            // Faculty
            // 
            Faculty.AutoSize = true;
            Faculty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Faculty.ForeColor = System.Drawing.Color.Black;
            Faculty.Location = new System.Drawing.Point(31, 156);
            Faculty.Name = "Faculty";
            Faculty.Size = new System.Drawing.Size(96, 28);
            Faculty.TabIndex = 29;
            Faculty.Text = "Faculty";
            Faculty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtProgramme);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(Faculty);
            this.panel2.Controls.Add(this.cmbDep);
            this.panel2.Controls.Add(this.cmbFac);
            this.panel2.Controls.Add(this.cmbSubGrpNum);
            this.panel2.Controls.Add(this.cmbGrpNo);
            this.panel2.Controls.Add(this.cmbAcademicSemYear);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtSubGrpID);
            this.panel2.Controls.Add(this.txtGrpID);
            this.panel2.Controls.Add(label8);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 963);
            this.panel2.TabIndex = 1;
            // 
            // txtProgramme
            // 
            this.txtProgramme.Location = new System.Drawing.Point(372, 383);
            this.txtProgramme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProgramme.Name = "txtProgramme";
            this.txtProgramme.Size = new System.Drawing.Size(364, 34);
            this.txtProgramme.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 28);
            this.label9.TabIndex = 30;
            this.label9.Text = "Department";
            // 
            // cmbDep
            // 
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Location = new System.Drawing.Point(372, 233);
            this.cmbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(364, 35);
            this.cmbDep.TabIndex = 28;
            this.cmbDep.SelectedIndexChanged += new System.EventHandler(this.cmbDep_SelectedIndexChanged);
            this.cmbDep.Click += new System.EventHandler(this.cmbDep_Click);
            // 
            // cmbFac
            // 
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Sciences"});
            this.cmbFac.Location = new System.Drawing.Point(372, 155);
            this.cmbFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(364, 35);
            this.cmbFac.TabIndex = 27;
            this.cmbFac.SelectedIndexChanged += new System.EventHandler(this.cmbFac_SelectedIndexChanged);
            // 
            // cmbSubGrpNum
            // 
            this.cmbSubGrpNum.FormattingEnabled = true;
            this.cmbSubGrpNum.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.cmbSubGrpNum.Location = new System.Drawing.Point(372, 535);
            this.cmbSubGrpNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubGrpNum.Name = "cmbSubGrpNum";
            this.cmbSubGrpNum.Size = new System.Drawing.Size(364, 35);
            this.cmbSubGrpNum.TabIndex = 26;
            // 
            // cmbGrpNo
            // 
            this.cmbGrpNo.FormattingEnabled = true;
            this.cmbGrpNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08"});
            this.cmbGrpNo.Location = new System.Drawing.Point(372, 459);
            this.cmbGrpNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGrpNo.Name = "cmbGrpNo";
            this.cmbGrpNo.Size = new System.Drawing.Size(364, 35);
            this.cmbGrpNo.TabIndex = 25;
            // 
            // cmbAcademicSemYear
            // 
            this.cmbAcademicSemYear.FormattingEnabled = true;
            this.cmbAcademicSemYear.Items.AddRange(new object[] {
            "Y1 S1",
            "Y1 S2",
            "Y2 S1",
            "Y2 S2",
            "Y3 S1",
            "Y3 S2",
            "Y4 S1",
            "Y4 S2"});
            this.cmbAcademicSemYear.Location = new System.Drawing.Point(372, 310);
            this.cmbAcademicSemYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAcademicSemYear.Name = "cmbAcademicSemYear";
            this.cmbAcademicSemYear.Size = new System.Drawing.Size(364, 35);
            this.cmbAcademicSemYear.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(731, 779);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(560, 778);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(372, 778);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generate IDs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtSubGrpID
            // 
            this.txtSubGrpID.Location = new System.Drawing.Point(372, 689);
            this.txtSubGrpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubGrpID.Name = "txtSubGrpID";
            this.txtSubGrpID.Size = new System.Drawing.Size(364, 34);
            this.txtSubGrpID.TabIndex = 16;
            // 
            // txtGrpID
            // 
            this.txtGrpID.Location = new System.Drawing.Point(372, 614);
            this.txtGrpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrpID.Name = "txtGrpID";
            this.txtGrpID.Size = new System.Drawing.Size(364, 34);
            this.txtGrpID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Academic Year Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD STUDENT GROUPS";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(57, 631);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 53);
            this.button4.TabIndex = 7;
            this.button4.Text = "HOME";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 1118);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 94);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Navy;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(57, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(249, 46);
            this.button6.TabIndex = 8;
            this.button6.Text = "Manage Student Group";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Navy;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(57, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(249, 46);
            this.button7.TabIndex = 0;
            this.button7.Text = "Add Student Group";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSubGrpID;
        private System.Windows.Forms.TextBox txtGrpID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSubGrpNum;
        private System.Windows.Forms.ComboBox cmbGrpNo;
        private System.Windows.Forms.ComboBox cmbAcademicSemYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.ComboBox cmbFac;
        private System.Windows.Forms.TextBox txtProgramme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}