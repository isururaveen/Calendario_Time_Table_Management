namespace TimeTableM
{
    partial class ManageTag
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTag));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonview = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRelatedTag = new System.Windows.Forms.ComboBox();
            this.txtSubjectTagCode = new System.Windows.Forms.TextBox();
            this.txtSubjectTagName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtSubCodeSearch = new System.Windows.Forms.TextBox();
            this.dgvMgTag = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgTag)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(65, 678);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(151, 28);
            label6.TabIndex = 37;
            label6.Text = "Related Tag";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(65, 614);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(217, 28);
            label4.TabIndex = 35;
            label4.Text = "Subject Tag Code";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonview);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbRelatedTag);
            this.panel2.Controls.Add(this.txtSubjectTagCode);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.txtSubjectTagName);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.txtSubCodeSearch);
            this.panel2.Controls.Add(this.dgvMgTag);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.SpringGreen;
            this.panel2.Location = new System.Drawing.Point(322, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 832);
            this.panel2.TabIndex = 5;
            // 
            // buttonview
            // 
            this.buttonview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.buttonview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonview.ForeColor = System.Drawing.Color.Black;
            this.buttonview.Location = new System.Drawing.Point(58, 154);
            this.buttonview.Name = "buttonview";
            this.buttonview.Size = new System.Drawing.Size(152, 46);
            this.buttonview.TabIndex = 41;
            this.buttonview.Text = "Refresh";
            this.buttonview.UseVisualStyleBackColor = false;
            this.buttonview.Click += new System.EventHandler(this.buttonview_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(556, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 27);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tag Code";
            // 
            // cmbRelatedTag
            // 
            this.cmbRelatedTag.FormattingEnabled = true;
            this.cmbRelatedTag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab"});
            this.cmbRelatedTag.Location = new System.Drawing.Point(338, 672);
            this.cmbRelatedTag.Name = "cmbRelatedTag";
            this.cmbRelatedTag.Size = new System.Drawing.Size(443, 35);
            this.cmbRelatedTag.TabIndex = 39;
            // 
            // txtSubjectTagCode
            // 
            this.txtSubjectTagCode.Location = new System.Drawing.Point(338, 605);
            this.txtSubjectTagCode.Name = "txtSubjectTagCode";
            this.txtSubjectTagCode.Size = new System.Drawing.Size(443, 34);
            this.txtSubjectTagCode.TabIndex = 38;
            this.txtSubjectTagCode.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSubjectTagName
            // 
            this.txtSubjectTagName.Location = new System.Drawing.Point(338, 544);
            this.txtSubjectTagName.Name = "txtSubjectTagName";
            this.txtSubjectTagName.Size = new System.Drawing.Size(443, 34);
            this.txtSubjectTagName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(65, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Subject Tag Name";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(897, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 46);
            this.button6.TabIndex = 32;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtSubCodeSearch
            // 
            this.txtSubCodeSearch.Location = new System.Drawing.Point(690, 159);
            this.txtSubCodeSearch.Name = "txtSubCodeSearch";
            this.txtSubCodeSearch.Size = new System.Drawing.Size(189, 34);
            this.txtSubCodeSearch.TabIndex = 31;
            this.txtSubCodeSearch.TextChanged += new System.EventHandler(this.txtSubCodeSearch_TextChanged);
            // 
            // dgvMgTag
            // 
            this.dgvMgTag.BackgroundColor = System.Drawing.Color.White;
            this.dgvMgTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMgTag.Location = new System.Drawing.Point(61, 212);
            this.dgvMgTag.Name = "dgvMgTag";
            this.dgvMgTag.RowTemplate.Height = 24;
            this.dgvMgTag.Size = new System.Drawing.Size(988, 283);
            this.dgvMgTag.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(70, 741);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 46);
            this.button3.TabIndex = 19;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(230, 741);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 46);
            this.button2.TabIndex = 18;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(388, 741);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE TAG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(45, 661);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "HOME";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(45, 585);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(249, 44);
            this.button5.TabIndex = 0;
            this.button5.Text = "BACK";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 1118);
            this.panel1.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Navy;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(45, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(249, 46);
            this.button7.TabIndex = 8;
            this.button7.Text = "Manage Tag";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Navy;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(45, 212);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(249, 46);
            this.button8.TabIndex = 0;
            this.button8.Text = "Add Tag";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 94);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ManageTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 820);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageTag";
            this.Text = " Tag Manage";
            this.Load += new System.EventHandler(this.ManageTag_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgTag)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtSubCodeSearch;
        private System.Windows.Forms.DataGridView dgvMgTag;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmbRelatedTag;
        private System.Windows.Forms.TextBox txtSubjectTagCode;
        private System.Windows.Forms.TextBox txtSubjectTagName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}