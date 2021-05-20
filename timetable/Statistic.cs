using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableM
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent(); 
            loadStatDetails();
        }

        //home Button clicked in Dashboard
        private void button1_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //Load Statistics Details - Count
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
