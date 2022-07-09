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
    public partial class PatientEditInformation : Form
    {
        public PatientEditInformation()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");
        public string id2;
        private void PatientEditInformation_Load(object sender, EventArgs e)
        {
            lblid2.Text = id2.ToString();
            connect.Open();
            SqlCommand bringinfo = new SqlCommand("select Name, Ssn, Phone, Password from TableVisitorPatient where patientid=@p1", connect);
            bringinfo.Parameters.AddWithValue("@p1", lblid2.Text);
            SqlDataReader dr = bringinfo.ExecuteReader();
            if (dr.Read())
            {
                txtname.Text = dr[0].ToString();
                msbssn.Text = dr[1].ToString();
                mskphone.Text = dr[2].ToString();
                txtpassword.Text = dr[3].ToString();
            }
            connect.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand patientupdate = new SqlCommand("update TableVisitorPatient set Name=@p1, Ssn=@p2, Phone=@p3, Password=@p4 where patientid=@p5", connect);
            patientupdate.Parameters.AddWithValue("@p1", txtname.Text);
            patientupdate.Parameters.AddWithValue("@p2", msbssn.Text);
            patientupdate.Parameters.AddWithValue("@p3", mskphone.Text);
            patientupdate.Parameters.AddWithValue("@p4", txtpassword.Text);
            patientupdate.Parameters.AddWithValue("@p5", lblid2.Text);
            patientupdate.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Information updated");
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
