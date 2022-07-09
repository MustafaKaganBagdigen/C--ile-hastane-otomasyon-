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
    public partial class SecreteryDetail : Form
    {
        public SecreteryDetail()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");
        public string secreteryid;
        private void SecreteryDetail_Load(object sender, EventArgs e)
        {
            lblssn.Text = secreteryid;
            connect.Open();
            SqlCommand bringname = new SqlCommand("select Id, Name from TableSecretery where Ssn=@p1", connect);
            bringname.Parameters.AddWithValue("@p1",lblssn.Text);
            SqlDataReader dr = bringname.ExecuteReader();
            while (dr.Read())
            {
                lblid.Text = dr[0].ToString();
                lblname.Text = dr[1].ToString();
            }
            connect.Close();

            //branch
            connect.Open();
            SqlCommand bringbranch = new SqlCommand("select namebranch from TableBranch", connect);            
            DataTable dt = new DataTable();            
            SqlDataAdapter da = new SqlDataAdapter(bringbranch);            
            da.Fill(dt);            
            dataGridView1.DataSource = dt;            
            connect.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen;
            chosen = dataGridView1.SelectedCells[0].RowIndex;
            lblbranch.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtbranch.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
        }

        private void lblbranch_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand bringid = new SqlCommand("select id from TableBranch where namebranch=@p1", connect);
            bringid.Parameters.AddWithValue("@p1", lblbranch.Text);
            SqlDataReader dr = bringid.ExecuteReader();
            while (dr.Read())
            {
                labelbrid.Text = dr[0].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand bringdoctor = new SqlCommand("select name from TableDoctor where doctorid=@p1", connect);
            bringdoctor.Parameters.AddWithValue("@p1", labelbrid.Text);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(bringdoctor);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;    
            connect.Close();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen2;
            chosen2 = dataGridView2.SelectedCells[0].RowIndex;
            lbldoctor.Text = dataGridView2.Rows[chosen2].Cells[0].Value.ToString();
            txtdoctor.Text = dataGridView2.Rows[chosen2].Cells[0].Value.ToString();
        }

        private void lbldoctor_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand bringdctr = new SqlCommand("select doctorid from TableDoctor where name=@p1", connect);
            bringdctr.Parameters.AddWithValue("@p1", lbldoctor.Text);
            SqlDataReader dr = bringdctr.ExecuteReader();
            while (dr.Read())
            {
                labeldctrid.Text = dr[0].ToString();     

            }
            dr.Close();
            SqlCommand bringappointment = new SqlCommand("select Date, Time from TableAppointmentDate where Doctor=@p1", connect);
            bringappointment.Parameters.AddWithValue("@p1", labeldctrid.Text);
            DataTable dt3 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bringappointment);
            da.Fill(dt3);
            dataGridView3.DataSource = dt3;
            connect.Close();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen3;
            chosen3 = dataGridView3.SelectedCells[0].RowIndex;
            txtdate.Text = dataGridView3.Rows[chosen3].Cells[0].Value.ToString();
            msktime.Text = dataGridView3.Rows[chosen3].Cells[1].Value.ToString();
                      
        }

        private void msktime_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand commandID = new SqlCommand("select ID from TableAppointmentDate where Doctor=@p8 and Date=@p9 and Time=@p10", connect);
            commandID.Parameters.AddWithValue("@p8", labeldctrid.Text);
            commandID.Parameters.AddWithValue("@p9", Convert.ToDateTime(txtdate.Text));
            commandID.Parameters.AddWithValue("@p10", msktime.Text);
            SqlDataReader dr = commandID.ExecuteReader();
            while (dr.Read())
            {
                AppoID.Text = dr[0].ToString();
            }
            connect.Close();
        }

        private void btncreateappo_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand bringidpt = new SqlCommand("select patientid from TableVisitorPatient where Ssn=@p1", connect);
            bringidpt.Parameters.AddWithValue("@p1", msbssn.Text);
            SqlDataReader dr = bringidpt.ExecuteReader();
            while (dr.Read())
            {
                lblpatientid.Text = dr[0].ToString();
            }
            dr.Close();
            try
            {
                SqlCommand commandcreate = new SqlCommand("insert into TableAppointment (patient, branch, doctor, date, time,reason) values (@p2,@p3,@p4,@p5,@p6,@p7)", connect);
                commandcreate.Parameters.AddWithValue("@p2", lblpatientid.Text);
                commandcreate.Parameters.AddWithValue("@p3", labelbrid.Text);
                commandcreate.Parameters.AddWithValue("@p4", labeldctrid.Text);
                commandcreate.Parameters.AddWithValue("@p5", Convert.ToDateTime(txtdate.Text));
                commandcreate.Parameters.AddWithValue("@p6", msktime.Text);
                commandcreate.Parameters.AddWithValue("@p7", richreason.Text);
                commandcreate.ExecuteNonQuery();   
                connect.Close();
                MessageBox.Show("Appointment created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msbssn.Text = "";
                richreason.Text = "";
               

                connect.Open();
                SqlCommand commanddelete = new SqlCommand("delete from TableAppointmentDate where ID=@p1", connect);
                commanddelete.Parameters.AddWithValue("@p1", AppoID.Text);
                commanddelete.ExecuteNonQuery();
                connect.Close();
            }
            catch 
            {
                MessageBox.Show("No such patient registered in the system was found.Please register in the system to make an appointment.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }                   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegistration pr = new PatientRegistration();
            pr.Show();
        }

        private void btncreateannoun_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand commandannoun = new SqlCommand("insert into TableAnnouncement (date, announcement) values (@p1,@p2)", connect);
            commandannoun.Parameters.AddWithValue("@p1", Convert.ToDateTime( dateTimePicker1.Text));
            commandannoun.Parameters.AddWithValue("@p2", richTextBox1.Text);
            commandannoun.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Announcement has been created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Announcements announ = new Announcements();
            announ.Show();
        }

        private void btnappointments_Click(object sender, EventArgs e)
        {
            Appointments frappo = new Appointments();
            frappo.Show();
        }

        
    }
}
