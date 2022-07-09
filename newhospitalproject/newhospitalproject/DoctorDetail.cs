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
    public partial class DoctorDetail : Form
    {
        public DoctorDetail()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");

        public string ssn;
        private void DoctorDetail_Load(object sender, EventArgs e)
        {
    
            lblssn.Text = ssn;
            connect.Open();
            SqlCommand viewinfo = new SqlCommand("select doctorid, name from TableDoctor where ssn=@p1", connect);
            viewinfo.Parameters.AddWithValue("@p1", lblssn.Text);
            SqlDataReader dr = viewinfo.ExecuteReader();
            if (dr.Read())
            {
                lblid.Text = dr[0].ToString();
                lblname.Text=dr[1].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand dtload = new SqlCommand("select id, Name, date, time, reason from TableAppointment " +
                "inner join TableVisitorPatient on TableAppointment.patient=TableVisitorPatient.patientid where doctor=@p7", connect);
            dtload.Parameters.AddWithValue("@p7", lblid.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(dtload);
            da.Fill(dt);
            dataGridView2.DataSource= dt;
            connect.Close();

            connect.Open();
            SqlCommand dtload2 = new SqlCommand("select id, Name, date, time, reason from TableAppointment " +
                "inner join TableVisitorPatient on TableAppointment.patient=TableVisitorPatient.patientid where doctor=@p8 and datesetting=@p6", connect);
            dtload2.Parameters.AddWithValue("@p6", true);
            dtload2.Parameters.AddWithValue("@p8", lblid.Text);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(dtload2);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            connect.Close();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen;
            chosen = dataGridView2.SelectedCells[0].RowIndex;
            richTextBox1.Text=dataGridView2.Rows[chosen].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorEditInformation dei = new DoctorEditInformation();
            dei.id = lblid.Text;
            dei.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Announcements a = new Announcements();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 entry = new Form1();
            entry.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
