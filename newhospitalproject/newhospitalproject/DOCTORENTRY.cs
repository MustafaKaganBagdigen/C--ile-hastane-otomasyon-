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
    public partial class DOCTORENTRY : Form
    {
        public DOCTORENTRY()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");
        private void btngiris_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand commandentry = new SqlCommand("select * from TableDoctor where ssn=@p1 and password=@p2", connect);
            commandentry.Parameters.AddWithValue("@p1", mskssn.Text);
            commandentry.Parameters.AddWithValue("@p2", txtpsswrd.Text);
            SqlDataReader dr=commandentry.ExecuteReader();
            if (dr.Read())
            {
                DoctorDetail dd = new DoctorDetail();
                dd.ssn = mskssn.Text;
                dd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ssn or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();
        }

        private void DOCTORENTRY_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
            
        }
    }
}
