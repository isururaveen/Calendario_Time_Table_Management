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
            
            try
            {
                string qu = "SELECT `LecName` FROM `addlecture` ORDER BY `EmpID` DESC LIMIT 1;";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    lblLatestLec.Text = sdr.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `GrpID` FROM `addstudentgrp` ORDER BY `GrpID` DESC LIMIT 1;";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    lblLatestGroup.Text = sdr.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `SubjectName` FROM `addsubject` ORDER BY `SubjectCode` DESC LIMIT 1;";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    lblLatestSub.Text = sdr.GetValue(0).ToString();
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
            con.Open();
            try
            {
                string qu = "SELECT COUNT(EmpID) FROM addlecture";
                MySqlCommand cm = new MySqlCommand(qu, con);
                Int32 rcount = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();

                label6Reg.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT COUNT(GrpNo) FROM addstudentgrp";
                MySqlCommand cm = new MySqlCommand(qu, con);
                Int32 rcount = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();

                labelStudentGroups.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT COUNT(SubjectCode) FROM addsubject";
                MySqlCommand cm = new MySqlCommand(qu, con);
                Int32 rcount = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();

                labelmodules.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT COUNT(roomName) FROM addlocation";
                MySqlCommand cm = new MySqlCommand(qu, con);
                Int32 rcount = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();

                labelLocations.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
