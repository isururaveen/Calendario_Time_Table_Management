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
    public partial class ManageSession : Form
    {
        MySqlConnection con = null;
        public ManageSession()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }
        string timee;
        
        //Manage session View button click
        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `firstLec` as FIRSTLECTURE, `secondLec` as SECONDLECTURE, `tag` as TAG, `tagType` as TAGTYPE, `grp` as STUDENTGROUP, `subject` as SUBJECT, `noOfStd` as NOSTUDENT, `day` as DAY,`time` as TIME, `AllDetails` as DETAILS FROM `addsesstion`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMngeSes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        //Update button clicked
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `addsesstion` SET `firstLec`= '" + cmb1Lec.Text + "',`secondLec`= '" + cmb2Lec.Text + "',`tag`= '" + cmbTimeSlot.Text + "',`tagType`= '" + txtShowTag.Text + "',`grp`= '" + cmbGrp.Text + "',`subject`='" + cmbSubject.Text + "',`noOfStd`= '" + txtNoOfStd.Text + "',`day`= '" + cmbDay.Text + "',`room`= 'NULL',`time`= '" + cmbTime1.Text + "', `AllDetails`= '" + lblAllDetails.Text + "' WHERE day = '" + cmbSrch.Text + "' AND time = '" + cmbTime.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Update succesfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //Delete Button Clicked
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `addsesstion` WHERE day = '" + cmbSrch.Text + "' AND `time`= '" + cmbTime.Text + "'";
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

        //Clear Button Clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmb1Lec.Text = string.Empty;
            cmb2Lec.Text = string.Empty;
            cmbTimeSlot.Text = string.Empty;
            cmbGrp.Text = string.Empty;
            cmbSubject.Text = string.Empty;
            txtNoOfStd.Clear();
            cmbTime.Text = string.Empty;
            cmbTime1.Text = string.Empty;
            cmbDay.Text = string.Empty;
            cmbSrch.Text = string.Empty;           
        }

        //Delete All Button
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE * FROM `addsesstion`";
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

        private void rbnMorning_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void rbnEvening_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbnMor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbnEve_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `firstLec`, `secondLec`, `tag`, `tagType`, `grp`, `subject`, `noOfStd`, `day`, `time`, `AllDetails` FROM `addsesstion` WHERE day = '" + cmbSrch.Text + "' AND time = '" + cmbTime.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    cmb1Lec.Text = sdr.GetValue(0).ToString();
                    cmb2Lec.Text = sdr.GetValue(1).ToString();
                    cmbTimeSlot.Text = sdr.GetValue(2).ToString();
                    txtShowTag.Text = sdr.GetValue(3).ToString();
                    cmbGrp.Text = sdr.GetValue(4).ToString();
                    cmbSubject.Text = sdr.GetValue(5).ToString();
                    txtNoOfStd.Text = sdr.GetValue(6).ToString();
                    cmbDay.Text = sdr.GetValue(7).ToString();
                    cmbTime1.Text = sdr.GetValue(8).ToString();
                    lblAllDetails.Text = sdr.GetValue(9).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            string Lec1 = cmb1Lec.Text;
            string Lec2 = cmb2Lec.Text;
            string Grp = cmbGrp.Text;
            string Subject = cmbSubject.Text;
            string Tag = cmbTimeSlot.Text;
            string TagType = txtShowTag.Text;
            string Day = cmbDay.Text;
            string NoOfStd = txtNoOfStd.Text;
            
            lblAllDetails.Text = Lec1 + "," + Lec2 + "," + Grp + "," + Subject + "," + Tag + "," + TagType + "," + NoOfStd;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SessionDash SessionDash = new SessionDash();
            SessionDash.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblAllDetails_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbSrch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNoOfStd_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtShowTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb2Lec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb1Lec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvMngeSes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSession1 AddSession1 = new AddSession1();
            AddSession1.Show();
            this.Hide();
        }

        private void cmbTime_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbTime.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT `allTimes` FROM `addtime`";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbTime.Items.Add(dr["allTimes"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        
        private void cmbTime1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbTime1.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT `allTimes` FROM `addtime`";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbTime1.Items.Add(dr["allTimes"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
