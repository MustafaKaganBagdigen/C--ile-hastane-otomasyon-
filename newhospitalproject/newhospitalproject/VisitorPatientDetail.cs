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
    public partial class VisitorPatientDetail : Form
    {
        public VisitorPatientDetail()
        {
            InitializeComponent();
        }
        public string patientssn;
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True; MultipleActiveResultSets=True");
        
        private void VisitorPatientDetail_Load(object sender, EventArgs e)
        {
            lblssn.Text = patientssn.ToString();
            connect.Open();
            SqlCommand bringinfopatient=new SqlCommand("select patientid, Name from TableVisitorPatient where Ssn=@p1",connect);
            bringinfopatient.Parameters.AddWithValue("@p1", lblssn.Text);
            SqlDataReader dr = bringinfopatient.ExecuteReader();
            while (dr.Read())
            {
                lblid.Text = dr[0].ToString();
                lblname.Text = dr[1].ToString();
            }
          
            connect.Close();
            connect.Open();
            SqlCommand commandappointments = new SqlCommand("select  name , reason, date, time from TableAppointment " +
                "inner join TableDoctor on TableAppointment.doctor=TableDoctor.doctorid where patient=@p1", connect);
            commandappointments.Parameters.AddWithValue("@p1",lblid.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandappointments);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();

            //branch combobox loaading
            connect.Open();
            SqlCommand commandcmbbox = new SqlCommand("select namebranch from TableBranch", connect);
            SqlDataReader dr2 = commandcmbbox.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranch.Items.Add(dr2[0]);
            }
            connect.Close();

        }
        //doctor cmbbox loading
        private void cmbbranch_SelectedIndexChanged(object sender, EventArgs e)
        {

            connect.Open();
            cmbdctr.Items.Clear();

            SqlCommand commandlblbranch = new SqlCommand("select id from TableBranch where namebranch=@p1", connect);
            commandlblbranch.Parameters.AddWithValue("@p1", cmbbranch.Text);
            SqlDataReader dr2 = commandlblbranch.ExecuteReader();
            while (dr2.Read())
            {
                lblbranch.Text = dr2[0].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand commanddoctor = new SqlCommand("select name from TableDoctor where branch=@p1", connect);
            commanddoctor.Parameters.AddWithValue("@p1", lblbranch.Text);
            SqlDataReader dr3 = commanddoctor.ExecuteReader();
            while (dr3.Read())
            {
                cmbdctr.Items.Add(dr3[0]);
            }
           
           
            connect.Close();
        }

        private void cmbdctr_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Open(); 
            SqlCommand commanddoctorlbl = new SqlCommand("select doctorid from TableDoctor where name=@p1", connect);
            commanddoctorlbl.Parameters.AddWithValue("@p1", cmbdctr.Text);
            SqlDataReader dr4 = commanddoctorlbl.ExecuteReader();
            while (dr4.Read())
            {
                lbldoctor.Text = dr4[0].ToString();
                if (lbldoctor.Text !=0.ToString())
                {
                    SqlCommand command10 = new SqlCommand("select Date, Time from TableAppointmentDate where Doctor=@p3 ", connect);
                    command10.Parameters.AddWithValue("@p3", lbldoctor.Text);
                    DataTable dt10 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command10);
                    da.Fill(dt10);
                    dataGridView2.DataSource = dt10;         
                }
            }
            connect.Close();
            MessageBox.Show("You can select the time and date by clicking on the desired field in the appointment table.");        
        }

        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen;
            chosen = dataGridView2.SelectedCells[0].RowIndex;      
            textBox1.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
            maskedTextBox2.Text = dataGridView2.Rows[chosen].Cells[1].Value.ToString();
            connect.Open();
            SqlCommand bringid = new SqlCommand("select ID from TableAppointmentDate where Doctor=@p1 and Date=@p2 and Time=@p3", connect);
            bringid.Parameters.AddWithValue("@p1", lbldoctor.Text);
            bringid.Parameters.AddWithValue("@p2", Convert.ToDateTime(textBox1.Text));
            bringid.Parameters.AddWithValue("@p3", maskedTextBox2.Text);
            SqlDataReader dr22 = bringid.ExecuteReader();
            while (dr22.Read())
            {
                lblapid.Text = dr22[0].ToString();
            }
            connect.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand commandinsert = new SqlCommand("insert into TableAppointment (patient, branch, doctor, date, time, reason) values (" +
                "@p1,@p2,@p3,@p4,@p5,@p6) ", connect);
            commandinsert.Parameters.AddWithValue("@p1", lblid.Text);
            commandinsert.Parameters.AddWithValue("@p2", lblbranch.Text);
            commandinsert.Parameters.AddWithValue("@p3", lbldoctor.Text);
            commandinsert.Parameters.AddWithValue("@p4", Convert.ToDateTime( textBox1.Text));
            commandinsert.Parameters.AddWithValue("@p5", maskedTextBox2.Text);
            commandinsert.Parameters.AddWithValue("@p6", richcomplaint.Text);
            commandinsert.ExecuteNonQuery();

            SqlCommand commanddelete = new SqlCommand("delete from TableAppointmentDate where ID=@p7", connect);
            commanddelete.Parameters.AddWithValue("@p7", lblapid.Text);
            commanddelete.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Appointment created");

            connect.Open();
            SqlCommand commandupdate = new SqlCommand("select  doctor , reason, date, time from TableAppointment where patient=@p1", connect);
            commandupdate.Parameters.AddWithValue("@p1", lblid.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandupdate);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
       
            connect.Close();

        }

        private void lnkinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientEditInformation pei = new PatientEditInformation();
            pei.id2 = lblid.Text;
            pei.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }
    }
}
