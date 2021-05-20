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
    public partial class AddLecturer : Form
    {   
        //DB Connection con variab
        MySqlConnection con = null;
        public AddLecturer()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }

        //department Drop Down
        void FacultyDep()
        {
            cmbFaculty.Items.Add("Computing");
            cmbFaculty.Items.Add("Engineering");
            cmbFaculty.Items.Add("Business");
            cmbFaculty.Items.Add("Sciences");
            string fac = this.cmbFaculty.SelectedItem.ToString();
            if (fac == "Computing")
            {
                cmbDepartment.Items.Add("Computer Sciance");
                cmbDepartment.Items.Add("Software engneering");
                cmbDepartment.Items.Add("Business studies and software engneering");
                cmbDepartment.Items.Add("Information systems");
            }
            else if (fac == "Engineering")
            {
                cmbDepartment.Items.Add("Civil Engneering");
                cmbDepartment.Items.Add("Electrical and electronic engneering");
                cmbDepartment.Items.Add("Megatronic engneering");
            }
            else if (fac == "Business")
            {
                cmbDepartment.Items.Add("Business studies and analysis");
                cmbDepartment.Items.Add("Business studies");
            }
            else if (fac == "Sciences")
            {
                cmbDepartment.Items.Add("Medicine");
                cmbDepartment.Items.Add("Vetnory");
                cmbDepartment.Items.Add("Dental Surgen");
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Home button
        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        //Add Lecturer Save Button
        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            try
            {
                string qu = "INSERT INTO `addlecture`(`LecName`, `EmpID`, `Faculty`, `Department`, `Center`, `Building`, `Level`, `Rank`) VALUES ('"+txtLecName.Text+"','"+txtEmpID.Text+"','"+cmbFaculty.Text+"','"+cmbDepartment.Text+"','"+cmbCenter.Text+"','"+cmbBuilding.Text+"','"+cmbLevel.Text+"','"+txtRank.Text+"')";
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
        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Lecturer Levels
        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

            string lev = this.cmbLevel.SelectedItem.ToString();
            if (lev == "Professor")
            {
                txtRank.Text = Convert.ToString("1");
            }
            else if (lev == "Assistant Professor")
            {
                txtRank.Text = Convert.ToString("2");
            }
            else if (lev == "Senior Lecturer(HG)")
            {
                txtRank.Text = Convert.ToString("3");
            }
            else if (lev == "Senior Lecturer")
            {
                txtRank.Text = Convert.ToString("4");
            }
            else if (lev == "Lecturer")
            {
                txtRank.Text = Convert.ToString("5");
            }
            else if (lev == "Assistant Lecturer")
            {
                txtRank.Text = Convert.ToString("6");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //Clear Button
        private void button3_Click(object sender, EventArgs e)
        {
            txtLecName.Clear();
            txtEmpID.Clear();
            txtRank.Clear();
            cmbBuilding.Text = string.Empty;
            cmbCenter.Text = string.Empty;
            cmbDepartment.Text = string.Empty;
            cmbFaculty.Text = string.Empty;
            cmbLevel.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        //Manage Lecturer Button clicked
        private void button6_Click(object sender, EventArgs e)
        {
            ManageLecturers ManageLecturers = new ManageLecturers();
            ManageLecturers.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
