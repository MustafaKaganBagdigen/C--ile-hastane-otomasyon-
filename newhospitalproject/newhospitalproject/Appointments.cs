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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");

        private void Appointments_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand bringappo = new SqlCommand("select Name, date, time from  TableAppointment " +
                "inner join TableVisitorPatient on TableAppointment.patient=TableVisitorPatient.patientid ", connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bringappo);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen;
            chosen = dataGridView1.SelectedCells[0].RowIndex;
            label2.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
      
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand bringdetail = new SqlCommand("select name, reason from TableAppointment " +
                "inner join TableDoctor on TableAppointment.doctor=TableDoctor.doctorid where date=@p1 and time=@p2", connect);
            bringdetail.Parameters.AddWithValue("@p1", Convert.ToDateTime(label2.Text));
            bringdetail.Parameters.AddWithValue("@p2", label3.Text);
            SqlDataReader dr = bringdetail.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = "DOCTOR:"+" "+ dr[0].ToString()  + "\n" +"REASON:"+ " "+  dr[1].ToString();
            }
            connect.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand txtlist = new SqlCommand("select Name, date, time from  TableAppointment " +
                "inner join TableVisitorPatient on TableAppointment.patient=TableVisitorPatient.patientid where Name like'" + textBox1.Text + "%'", connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(txtlist);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
