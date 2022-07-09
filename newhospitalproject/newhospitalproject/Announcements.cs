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
    public partial class Announcements : Form
    {
        public Announcements()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUSUSA;Initial Catalog=DbNewHospital;Integrated Security=True");
        private void Announcements_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand bringannoun = new SqlCommand("select date, announcement from TableAnnouncement", connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter(bringannoun);
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            connect.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen;
            chosen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand txtlist = new SqlCommand("select date, announcement from TableAnnouncement where  announcement like'" + textBox1.Text + "%'", connect);
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
