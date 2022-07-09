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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");
        private void btnkayıt_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand commandregister = new SqlCommand("insert into TableVisitorPatient (Name, Ssn, Phone, Password) values (@p1,@p2,@p3,@p4)", connect);
                commandregister.Parameters.AddWithValue("@p1", txtname.Text);
                commandregister.Parameters.AddWithValue("@p2", mskssn.Text);
                commandregister.Parameters.AddWithValue("@p3", mskphone.Text);
                if (txtpassword.Text.Length<=8)
                {
                    commandregister.Parameters.AddWithValue("@p4", txtpassword.Text);
                }
                commandregister.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Registered in the system.");
            }
            catch 
            {

                MessageBox.Show("Fill in the information completely and your password should not be more than 8 char.");
            }
            
        }
    }
}
