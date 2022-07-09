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
    public partial class patiententrypanel : Form
    {
        public patiententrypanel()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");
        private void patiententrypanel_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand commandentry = new SqlCommand("select * from TableVisitorPatient where ssn=@p1 and password=@p2", connect);
            commandentry.Parameters.AddWithValue("@p1", mskssn.Text);
            commandentry.Parameters.AddWithValue("@p2", txtpsswrd.Text);
            SqlDataReader dr = commandentry.ExecuteReader();
            if (dr.Read())
            {
                VisitorPatientDetail vpd = new VisitorPatientDetail();
                vpd.patientssn = mskssn.Text;
                vpd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ssn or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegistration pr = new PatientRegistration();
            pr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
