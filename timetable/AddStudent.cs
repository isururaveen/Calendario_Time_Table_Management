using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TimeTableM
{
    public partial class AddStudent : Form
    {
        MySqlConnection con = null;
        public AddStudent()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }
        string acedemic;
        string prog;
        string grpNo;
        string subNo;

        //Academic year
        void Academic()
        {
            cmbAcademicSemYear.Items.Add("Y1 S1");
            cmbAcademicSemYear.Items.Add("Y1 S2");
            cmbAcademicSemYear.Items.Add("Y2 S1");
            cmbAcademicSemYear.Items.Add("Y2 S2");
            cmbAcademicSemYear.Items.Add("Y3 S1");
            cmbAcademicSemYear.Items.Add("Y3 S2");
            cmbAcademicSemYear.Items.Add("Y4 S1");
            cmbAcademicSemYear.Items.Add("Y4 S2");
        }

        //Group Number
        void GroupNo()
        {
            cmbGrpNo.Items.Add("01");
            cmbGrpNo.Items.Add("02");
            cmbGrpNo.Items.Add("03");
            cmbGrpNo.Items.Add("04");
            cmbGrpNo.Items.Add("05");
            cmbGrpNo.Items.Add("06");
            cmbGrpNo.Items.Add("07");
            cmbGrpNo.Items.Add("08");
        }

        //add subjects save button
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `addsubject`(`department`,`dep2`,`OfferdYear`, `OfferedSem`, `SubjectName`, `SubjectCode`, `NoOfLecHours`, `NoOfTuHours`, `NoOfLabHours`, `NoOfEveHours`) VALUES ('" + cmbDepartment.Text + "','" + cmbDep2.Text + "','" + cmbYear.Text + "','" + sem + "','" + txtSubName.Text + "','" + txtSubCode.Text + "','" + noUpDwnLecHours.Text + "','" + noUpDwnNoOfTuteHours.Text + "','" + noUpDwnLabHours.Text + "','" + noUpDwnEvaHours.Text + "')";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //Sub Groups
        void SubGroup()
        {
            cmbSubGrpNum.Items.Add("S1");
            cmbSubGrpNum.Items.Add("S2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Add Student Groups - Save
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `addstudentgrp`(`Fac`, `Dep`,`AcademicSemYear`, `Programme`, `GrpNo`, `SubGrpNum`, `GrpID`, `SubGrpID`) VALUES ('" + cmbFac.Text + "','" + cmbDep.Text + "','" + cmbAcademicSemYear.Text + "','" + txtProgramme.Text + "','" + cmbGrpNo.Text + "','" + cmbSubGrpNum.Text + "','" + txtGrpID.Text + "','" + txtSubGrpID.Text + "')";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        
        private void cmbAcademicSemYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Academic();
        }

        private void cmbProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbGrpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupNo();
        }

        private void cmbSubGrpNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubGroup();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Home Button
        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        //Clear Button
        private void button3_Click(object sender, EventArgs e)
        {

            cmbAcademicSemYear.Text = string.Empty;
            txtProgramme.Text = string.Empty;
            cmbGrpNo.Text = string.Empty;
            cmbSubGrpNum.Text = string.Empty;
            txtGrpID.Clear();
            txtSubGrpID.Clear();
        }

        //generate IDs Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            string acedemic = this.cmbAcademicSemYear.SelectedItem.ToString();
            string prog = this.txtProgramme.Text.ToString();
            string grpNo = this.cmbGrpNo.SelectedItem.ToString();
            string subNo = this.cmbSubGrpNum.SelectedItem.ToString();

            txtGrpID.Text = acedemic + "." + prog + "." + grpNo;
            txtSubGrpID.Text = acedemic + "." + prog + "." + grpNo + "." + subNo;
        }

        //Department DropDown
        private void cmbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fac = this.cmbFac.SelectedItem.ToString();
            if (fac == "Computing")
            {
                cmbDep.Items.Add("Computer Science");
                cmbDep.Items.Add("Software Engineering");
                cmbDep.Items.Add("Business studies And Software Engineering");
                cmbDep.Items.Add("Information Systems");
            }
            else if (fac == "Engineering")
            {
                cmbDep.Items.Add("Civil Engineering");
                cmbDep.Items.Add("Electrical and Electronic Engineering");
                cmbDep.Items.Add("Megatronic Engineering");
            }
            else if (fac == "Bussiness")
            {
                cmbDep.Items.Add("Bussiness Studies and Analysis");
                cmbDep.Items.Add("Bussiness Studies");
            }
            else if (fac == "Sciences")
            {
                cmbDep.Items.Add("Medicine");
                cmbDep.Items.Add("Vetnory");
                cmbDep.Items.Add("Dental Surgen");
            }
        }

        private void cmbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dep = this.cmbDep.SelectedItem.ToString();
            if (dep == "Computer Science")
            {
                txtProgramme.Text = "CS";
            }
            else if (dep == "Software Engineering")
            {
                txtProgramme.Text = "SE";
            }
            else if (dep == "Bussiness Studies And Software Engineering")
            {
                txtProgramme.Text = "BS&SE";
            }
            else if (dep == "Information Systems")
            {
                txtProgramme.Text = "IS";
            }
            else if (dep == "Civil Engineering")
            {
                txtProgramme.Text = "CE";
            }
            else if (dep == "Electrical and Electronic Engineering")
            {
                txtProgramme.Text = "EEE";
            }
            else if (dep == "Megatronic Engineering")
            {
                txtProgramme.Text = "ME";
            }
            else if (dep == "Business Studies And Analysis")
            {
                txtProgramme.Text = "BSA";
            }
            else if (dep == "Business Studies")
            {
                txtProgramme.Text = "BS";
            }
            else if (dep == "Dental Surgen")
            {
                txtProgramme.Text = "DENTAL";
            }
            else if (dep == "Vetnory")
            {
                txtProgramme.Text = "VET";
            }
            else if (dep == "Medicine")
            {
                txtProgramme.Text = "MED";
            }
        }

        private void cmbDep_Click(object sender, EventArgs e)
        {
            
        }

        //Manage Student Button
        private void button6_Click(object sender, EventArgs e)
        {
            ManageStudent ManageStudent = new ManageStudent();
            ManageStudent.Show();
            this.Hide();
        }
    }
}
