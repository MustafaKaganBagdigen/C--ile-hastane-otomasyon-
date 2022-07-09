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
    public partial class SecreteryEntry : Form
    {
        public SecreteryEntry()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");
        private void SecreteryEntry_Load(object sender, EventArgs e)
        {

        }

        private void btnentry_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand commandsecentry=new SqlCommand("select * from TableSecretery where Ssn=@p1 and Password=@p2",connect);
            commandsecentry.Parameters.AddWithValue("@p1", mskssn.Text);
            commandsecentry.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = commandsecentry.ExecuteReader();
            if (dr.Read())
            {
                SecreteryDetail sd = new SecreteryDetail();
                sd.secreteryid = mskssn.Text;
                sd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ssn or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
