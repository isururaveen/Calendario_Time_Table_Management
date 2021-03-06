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
    public partial class AddTimeSlot : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public AddTimeSlot()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddWorking AddWorking = new AddWorking();
            AddWorking.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        //Add time slot save button
        private void button2_Click(object sender, EventArgs e)
        {
            string Start = this.txtTStartTime.Text.ToString();
            string End = this.txtTEndTime.Text.ToString();

            string all = Start + " to " + End;
            con.Open();
            try
            {
                string qu = "INSERT INTO `addtime`(`timeID`, `StartTime`, `TimeSlot`, `EndTime`, `allTimes`) VALUES ('" + txtID.Text + "','" + Start + "','" + txtTimeSlot.Text + "','" + End + "','" + all + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            string Start = this.txtTStartTime.Text.ToString();
            string End = this.txtTEndTime.Text.ToString();

            string all = Start + " to " + End;
            con.Open();
            try
            {
                string qu = "INSERT INTO `addtime`(`timeID`, `StartTime`, `TimeSlot`, `EndTime`, `allTimes`) VALUES ('" + txtID.Text + "','" + Start + "','" + txtTimeSlot.Text + "','" + End + "','" + all + "')";
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

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `timeID`, `StartTime`, `TimeSlot`, `EndTime` FROM `addtime`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTimeSlot.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtTStartTime.Clear();
            txtTimeSlot.Clear();
            txtTEndTime.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `addtime` WHERE `timeID` = '" + txtID.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
