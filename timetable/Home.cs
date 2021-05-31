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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Add lecture click button
        private void btnAddLec_Click(object sender, EventArgs e)
        {
            AddLecturer AddLecturer = new AddLecturer();
            AddLecturer.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Add Working Days and Hours click button
        private void btnWorkingDaysAndHours_Click(object sender, EventArgs e)
        {
            AddWorking AddWorking = new AddWorking();
            AddWorking.Show();
            this.Hide();
        }

        //Add Subjects click button
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject AddSubject = new AddSubject();
            AddSubject.Show();
            this.Hide();
        }

        //Add Tags click button
        private void btnAddTags_Click(object sender, EventArgs e)
        {
            AddTag AddTag = new AddTag();
            AddTag.Show();
            this.Hide();
        }

        //Add Student groups click button
        private void btnStdGrp_Click(object sender, EventArgs e)
        {
            AddStudent AddStudent = new AddStudent();
            AddStudent.Show();
            this.Hide();
        }

        //Add Add Location click button
        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            AddLocation AddLocation = new AddLocation();
            AddLocation.Show();
            this.Hide();
        }

        //Statistics click button
        private void btnVisuStat_Click(object sender, EventArgs e)
        {
            Statistics Statistics = new Statistics();
            Statistics.Show();
            this.Hide();
        }

        //Sessions click button
        private void button1_Click_1(object sender, EventArgs e)
        {
            SessionDash SessionDash = new SessionDash();
            SessionDash.Show();
            this.Hide();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeTbl TimeTbl = new TimeTbl();
            TimeTbl.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
