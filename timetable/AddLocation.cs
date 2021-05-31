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
    public partial class AddLocation : Form
    {
        MySqlConnection con = null;
        public AddLocation()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }
        string roomType;
        void BuildingName()
        {
            cmbbuildingName.Items.Add("Computing Building");
            cmbbuildingName.Items.Add("Engineering Building");
            cmbbuildingName.Items.Add("Bussiness Building");
            cmbbuildingName.Items.Add("New Building");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        
        //Add Locations - insert to the db
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `addlocation`(`buildingName`, `roomName`, `roomType`, `capacity`) VALUES ('" + cmbbuildingName.Text + "','" + txtroomName.Text + "','" + roomType + "','" + cmbcap.Text + "')";
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

        //clear Button click
		private void button3_Click(object sender, EventArgs e)
        {
            cmbbuildingName.Text = string.Empty;
            txtroomName.Clear();
            roomType = string.Empty;
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Lecture Hall";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Laboratory";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageLocation ManageLocation = new ManageLocation();
            ManageLocation.Show();
            this.Hide();
        }

        private void txtcapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbbuildingName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
