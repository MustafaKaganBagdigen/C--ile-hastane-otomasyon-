using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace newhospitalproject
{
    public partial class DoctorEditInformation : Form
    {
        public DoctorEditInformation()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");
        public string id;
        private void DoctorEditInformation_Load(object sender, EventArgs e)
        {
            lblid.Text = id.ToString();
            connect.Open();
            SqlCommand bringinfo = new SqlCommand("select name, ssn, branch, password from TableDoctor where doctorid=@p1", connect);
            bringinfo.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr = bringinfo.ExecuteReader();
            while (dr.Read())
            {
                txtname.Text = dr[0].ToString();
                msbssn.Text = dr[1].ToString();
                txtpassword.Text = dr[3].ToString();
                lblconid.Text = dr[2].ToString();
            }
            connect.Close();
            if (lblconid.Text != 0.ToString())
            {
                dr.Close();
                connect.Open();
                SqlCommand cmmd2 = new SqlCommand("select namebranch from TableBranch where id=@p1", connect);
                cmmd2.Parameters.AddWithValue("@p1", lblconid.Text);
                SqlDataReader dr5 = cmmd2.ExecuteReader();
                if (dr5.Read())
                {
                    cmbbranch.Text = dr5[0].ToString();
                }
                connect.Close();

            }

            connect.Open();
            SqlCommand branch = new SqlCommand("select namebranch from TableBranch", connect);
            SqlDataReader dr2 = branch.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranch.Items.Add(dr2[0]);
            }
            connect.Close();

        }

        private void lblconid_TextChanged(object sender, EventArgs e)
        {

        }
        private void cmbbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmmd = new SqlCommand("select id from TableBranch where namebranch=@p1", connect);
            cmmd.Parameters.AddWithValue("@p1", cmbbranch.Text);
            SqlDataReader dr = cmmd.ExecuteReader();
            while (dr.Read())
            {
                lblconid.Text = dr[0].ToString();
            }
            connect.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand dctrupdate = new SqlCommand("update TableDoctor set name=@p1, ssn=@p2, branch=@p3, password=@p4 where doctorid=@p5", connect);
            dctrupdate.Parameters.AddWithValue("@p1", txtname.Text);
            dctrupdate.Parameters.AddWithValue("@p2", msbssn.Text);
            dctrupdate.Parameters.AddWithValue("@p3", lblconid.Text);
            dctrupdate.Parameters.AddWithValue("@p4", txtpassword.Text);
            dctrupdate.Parameters.AddWithValue("@p5", lblid.Text);

            if (msbssn.Text.Length == 11)
            {
                dctrupdate.ExecuteNonQuery();
                MessageBox.Show("Information updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }   
            if (msbssn.Text.Length!=11)
            {
                MessageBox.Show("Please check the ssn ");
            }
            connect.Close();
          
    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
