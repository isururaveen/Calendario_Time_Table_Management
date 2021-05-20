namespace TimeTableM
{
    partial class ManageLocation
    {
   
        private System.ComponentModel.IContainer components = null;


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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLocation));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbbuildingName = new System.Windows.Forms.ComboBox();
            this.button_view = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtroomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtRMSearch = new System.Windows.Forms.TextBox();
            this.dgvMgLoc = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgLoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(61, 728);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(151, 28);
            label6.TabIndex = 37;
            label6.Text = "Room Name";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(61, 657);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(181, 28);
            label4.TabIndex = 35;
            label4.Text = "Building Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(720, 210);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(131, 26);
            label7.TabIndex = 44;
            label7.Text = "Room Name";
            label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cmbbuildingName);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(this.button_view);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.txtcapacity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.txtroomName);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.txtRMSearch);
            this.panel2.Controls.Add(this.dgvMgLoc);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(330, -68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 832);
            this.panel2.TabIndex = 6;
            // 
            // cmbbuildingName
            // 
            this.cmbbuildingName.FormattingEnabled = true;
            this.cmbbuildingName.Items.AddRange(new object[] {
            "Computing Building",
            "Engineering Building",
            "Business Building",
            "New Building"});
            this.cmbbuildingName.Location = new System.Drawing.Point(269, 650);
            this.cmbbuildingName.Name = "cmbbuildingName";
            this.cmbbuildingName.Size = new System.Drawing.Size(321, 35);
            this.cmbbuildingName.TabIndex = 45;
            // 
            // button_view
            // 
            this.button_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.button_view.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_view.ForeColor = System.Drawing.Color.Black;
            this.button_view.Location = new System.Drawing.Point(58, 220);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(152, 46);
            this.button_view.TabIndex = 43;
            this.button_view.Text = "Refresh";
            this.button_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_view.UseVisualStyleBackColor = false;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(1011, 656);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(161, 32);
            this.radioButton4.TabIndex = 42;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Laboratory";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(832, 656);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(174, 32);
            this.radioButton3.TabIndex = 41;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Lecture Hall";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(832, 729);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(321, 34);
            this.txtcapacity.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(638, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "Room Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtroomName
            // 
            this.txtroomName.Location = new System.Drawing.Point(269, 726);
            this.txtroomName.Name = "txtroomName";
            this.txtroomName.Size = new System.Drawing.Size(321, 34);
            this.txtroomName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(638, 731);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Capacity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(1069, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 50);
            this.button6.TabIndex = 32;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtRMSearch
            // 
            this.txtRMSearch.Location = new System.Drawing.Point(876, 201);
            this.txtRMSearch.Name = "txtRMSearch";
            this.txtRMSearch.Size = new System.Drawing.Size(158, 34);
            this.txtRMSearch.TabIndex = 31;
            this.txtRMSearch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dgvMgLoc
            // 
            this.dgvMgLoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvMgLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMgLoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMgLoc.Location = new System.Drawing.Point(58, 277);
            this.dgvMgLoc.Name = "dgvMgLoc";
            this.dgvMgLoc.RowTemplate.Height = 24;
            this.dgvMgLoc.Size = new System.Drawing.Size(946, 310);
            this.dgvMgLoc.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1020, 413);
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
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1021, 479);
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
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1021, 541);
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
            this.label1.Location = new System.Drawing.Point(48, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE LOCATIONS";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(48, 623);
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
            this.button5.Location = new System.Drawing.Point(48, 548);
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
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 1118);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 94);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Navy;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(48, 285);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(249, 46);
            this.button7.TabIndex = 8;
            this.button7.Text = "Manage Location";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Navy;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(48, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(249, 46);
            this.button8.TabIndex = 0;
            this.button8.Text = "Add Location";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ManageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageLocation";
            this.Text = "Location Manage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgLoc)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtroomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtRMSearch;
        private System.Windows.Forms.DataGridView dgvMgLoc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.ComboBox cmbbuildingName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}