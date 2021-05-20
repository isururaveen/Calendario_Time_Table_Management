namespace TimeTableM
{
    partial class AddTimeSlot
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimeSlot));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimeSlot = new System.Windows.Forms.TextBox();
            this.txtTEndTime = new System.Windows.Forms.TextBox();
            this.txtTStartTime = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTimeSlot = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlot)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(84, 254);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(132, 28);
            label6.TabIndex = 12;
            label6.Text = "Start Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label5.Location = new System.Drawing.Point(56, 498);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 31);
            label5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(84, 194);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 28);
            label4.TabIndex = 4;
            label4.Text = "Time Slot";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(84, 314);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 28);
            label7.TabIndex = 24;
            label7.Text = "End Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtTimeSlot);
            this.panel2.Controls.Add(this.txtTEndTime);
            this.panel2.Controls.Add(this.txtTStartTime);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.dgvTimeSlot);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(349, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 788);
            this.panel2.TabIndex = 5;
            // 
            // txtTimeSlot
            // 
            this.txtTimeSlot.Location = new System.Drawing.Point(257, 191);
            this.txtTimeSlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimeSlot.Name = "txtTimeSlot";
            this.txtTimeSlot.Size = new System.Drawing.Size(340, 34);
            this.txtTimeSlot.TabIndex = 43;
            // 
            // txtTEndTime
            // 
            this.txtTEndTime.Location = new System.Drawing.Point(257, 310);
            this.txtTEndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTEndTime.Name = "txtTEndTime";
            this.txtTEndTime.Size = new System.Drawing.Size(340, 34);
            this.txtTEndTime.TabIndex = 42;
            // 
            // txtTStartTime
            // 
            this.txtTStartTime.Location = new System.Drawing.Point(257, 250);
            this.txtTStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTStartTime.Name = "txtTStartTime";
            this.txtTStartTime.Size = new System.Drawing.Size(340, 34);
            this.txtTStartTime.TabIndex = 41;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(836, 123);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(152, 46);
            this.btnView.TabIndex = 40;
            this.btnView.Text = "Refresh";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(836, 310);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 46);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTimeSlot
            // 
            this.dgvTimeSlot.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimeSlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeSlot.Location = new System.Drawing.Point(91, 372);
            this.dgvTimeSlot.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTimeSlot.Name = "dgvTimeSlot";
            this.dgvTimeSlot.Size = new System.Drawing.Size(897, 230);
            this.dgvTimeSlot.TabIndex = 38;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(836, 254);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 46);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(836, 179);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 46);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(257, 135);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(340, 34);
            this.txtID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(84, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD TIME SLOT";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(57, 558);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button5.Location = new System.Drawing.Point(57, 476);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(249, 41);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 1118);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 94);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(57, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Time Slot";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddTimeSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 722);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTimeSlot";
            this.Text = "Add Time Slot";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlot)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvTimeSlot;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTEndTime;
        private System.Windows.Forms.TextBox txtTStartTime;
        private System.Windows.Forms.TextBox txtTimeSlot;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}