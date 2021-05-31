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
    public partial class Statistics : Form
    {
        MySqlConnection con = null;
        public Statistics()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            loadStatDetails();
            loadLatestDetails();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }


        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6Reg_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //Load What New Section
        public void loadLatestDetails()
        {
            //Load Latest Lecturer Name
            try
            {
                string queryLatestLec_Name = "SELECT `LecName` FROM `addlecture` ORDER BY id;";
                MySqlCommand sqlCmd = new MySqlCommand(queryLatestLec_Name, con);
                MySqlDataReader sqlrdr = sqlCmd.ExecuteReader();
                while (sqlrdr.Read())
                {
                    lblLatestLec.Text = sqlrdr.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Close Connection
            con.Close();

            //Load latest Student Group
            con.Open();
            try
            {
                string queryLatestSt_Groups = "SELECT SubGrpID FROM addstudentgrp ORDER BY id;";
                MySqlCommand sqlCmd = new MySqlCommand(queryLatestSt_Groups, con);
                MySqlDataReader sqlrdr = sqlCmd.ExecuteReader();
                while (sqlrdr.Read())
                {
                    lblLatestGroup.Text = sqlrdr.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Close Connection
            con.Close();

            //Load Latest Subject Name
            con.Open();
            try
            {
                string queryLatestSub_Name= "SELECT `SubjectName` FROM `addsubject` ORDER BY id;";
                MySqlCommand sqlCmd = new MySqlCommand(queryLatestSub_Name, con);
                MySqlDataReader sqlrdr = sqlCmd.ExecuteReader();
                while (sqlrdr.Read())
                {
                    lblLatestSub.Text = sqlrdr.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //Load StatDetails
        public void loadStatDetails()
        {
            //Count Lecturers
            con.Open();
            try
            {
                string queryCountLecurers = "SELECT COUNT(EmpID) FROM addlecture";
                MySqlCommand sqlCmd = new MySqlCommand(queryCountLecurers, con);
                Int32 lecCount = Convert.ToInt32(sqlCmd.ExecuteScalar());
                sqlCmd.Dispose();

                label6Reg.Text = lecCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Count StudentGroups
            con.Open();
            try
            {
                string queryCountSt_Groups = "SELECT COUNT(GrpNo) FROM addstudentgrp";
                MySqlCommand sqlCmd = new MySqlCommand(queryCountSt_Groups, con);
                Int32 stGroupCount = Convert.ToInt32(sqlCmd.ExecuteScalar());
                sqlCmd.Dispose();

                labelStudentGroups.Text = stGroupCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Count Subjects
            con.Open();
            try
            {
                string queryCount_Sub_Groups = "SELECT COUNT(SubjectCode) FROM addsubject";
                MySqlCommand sqlCmd = new MySqlCommand(queryCount_Sub_Groups, con);
                Int32 subCount = Convert.ToInt32(sqlCmd.ExecuteScalar());
                sqlCmd.Dispose();

                labelmodules.Text = subCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            
            //Room Count
            con.Open();
            try
            {
                string queryCountRoom = "SELECT COUNT(roomName) FROM addlocation";
                MySqlCommand sqlCmd = new MySqlCommand(queryCountRoom, con);
                Int32 roomCount = Convert.ToInt32(sqlCmd.ExecuteScalar());
                sqlCmd.Dispose();

                labelLocations.Text = roomCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
