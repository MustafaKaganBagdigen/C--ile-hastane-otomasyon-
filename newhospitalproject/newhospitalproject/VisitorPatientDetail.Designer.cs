namespace newhospitalproject
{
    partial class VisitorPatientDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorPatientDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lnkinfo = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblssn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupAccess = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblapid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbbranch = new System.Windows.Forms.ComboBox();
            this.richcomplaint = new System.Windows.Forms.RichTextBox();
            this.cmbdctr = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupAccess.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.lnkinfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lblssn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(389, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(82, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(17, 16);
            this.lblid.TabIndex = 5;
            this.lblid.Text = " 0";
            // 
            // lnkinfo
            // 
            this.lnkinfo.AutoSize = true;
            this.lnkinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkinfo.Location = new System.Drawing.Point(84, 106);
            this.lnkinfo.Name = "lnkinfo";
            this.lnkinfo.Size = new System.Drawing.Size(98, 16);
            this.lnkinfo.TabIndex = 26;
            this.lnkinfo.TabStop = true;
            this.lnkinfo.Text = "Edit Information";
            this.lnkinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkinfo_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.Location = new System.Drawing.Point(85, 79);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 3;
            this.lblname.Text = " NULL";
            // 
            // lblssn
            // 
            this.lblssn.AutoSize = true;
            this.lblssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblssn.Location = new System.Drawing.Point(86, 55);
            this.lblssn.Name = "lblssn";
            this.lblssn.Size = new System.Drawing.Size(84, 16);
            this.lblssn.TabIndex = 2;
            this.lblssn.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "SSN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = " NAME:";
            // 
            // groupAccess
            // 
            this.groupAccess.Controls.Add(this.textBox1);
            this.groupAccess.Controls.Add(this.maskedTextBox2);
            this.groupAccess.Controls.Add(this.btncreate);
            this.groupAccess.Controls.Add(this.label6);
            this.groupAccess.Controls.Add(this.lblapid);
            this.groupAccess.Controls.Add(this.label5);
            this.groupAccess.Controls.Add(this.label8);
            this.groupAccess.Controls.Add(this.label9);
            this.groupAccess.Controls.Add(this.cmbbranch);
            this.groupAccess.Controls.Add(this.richcomplaint);
            this.groupAccess.Controls.Add(this.cmbdctr);
            this.groupAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupAccess.Location = new System.Drawing.Point(386, 158);
            this.groupAccess.Name = "groupAccess";
            this.groupAccess.Size = new System.Drawing.Size(309, 189);
            this.groupAccess.TabIndex = 10;
            this.groupAccess.TabStop = false;
            this.groupAccess.Text = "Create Appointment";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(211, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 22);
            this.textBox1.TabIndex = 31;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox2.Location = new System.Drawing.Point(211, 68);
            this.maskedTextBox2.Mask = "90:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(70, 22);
            this.maskedTextBox2.TabIndex = 30;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbranch.Location = new System.Drawing.Point(701, 207);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(20, 18);
            this.lblbranch.TabIndex = 28;
            this.lblbranch.Text = " 0";
            this.lblbranch.Visible = false;
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldoctor.Location = new System.Drawing.Point(701, 227);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(20, 18);
            this.lbldoctor.TabIndex = 27;
            this.lbldoctor.Text = " 0";
            this.lbldoctor.Visible = false;
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncreate.Location = new System.Drawing.Point(98, 163);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(183, 26);
            this.btncreate.TabIndex = 25;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "COMPLAINT:";
            // 
            // lblapid
            // 
            this.lblapid.AutoSize = true;
            this.lblapid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblapid.Location = new System.Drawing.Point(97, 22);
            this.lblapid.Name = "lblapid";
            this.lblapid.Size = new System.Drawing.Size(17, 16);
            this.lblapid.TabIndex = 23;
            this.lblapid.Text = " 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "BRANCH:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(23, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "DOCTOR:";
            // 
            // cmbbranch
            // 
            this.cmbbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbranch.FormattingEnabled = true;
            this.cmbbranch.Location = new System.Drawing.Point(98, 41);
            this.cmbbranch.Name = "cmbbranch";
            this.cmbbranch.Size = new System.Drawing.Size(107, 24);
            this.cmbbranch.TabIndex = 15;
            this.cmbbranch.SelectedIndexChanged += new System.EventHandler(this.cmbbranch_SelectedIndexChanged);
            // 
            // richcomplaint
            // 
            this.richcomplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richcomplaint.Location = new System.Drawing.Point(98, 98);
            this.richcomplaint.Name = "richcomplaint";
            this.richcomplaint.Size = new System.Drawing.Size(183, 55);
            this.richcomplaint.TabIndex = 17;
            this.richcomplaint.Text = "";
            // 
            // cmbdctr
            // 
            this.cmbdctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbdctr.FormattingEnabled = true;
            this.cmbdctr.Location = new System.Drawing.Point(100, 68);
            this.cmbdctr.Name = "cmbdctr";
            this.cmbdctr.Size = new System.Drawing.Size(105, 24);
            this.cmbdctr.TabIndex = 16;
            this.cmbdctr.SelectedIndexChanged += new System.EventHandler(this.cmbdctr_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 150);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 125);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(4, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 189);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(375, 164);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(671, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // VisitorPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbldoctor);
            this.Controls.Add(this.lblbranch);
            this.Controls.Add(this.groupAccess);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisitorPatientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitorPatientDetail";
            this.Load += new System.EventHandler(this.VisitorPatientDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAccess.ResumeLayout(false);
            this.groupAccess.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblssn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupAccess;
        private System.Windows.Forms.RichTextBox richcomplaint;
        private System.Windows.Forms.ComboBox cmbdctr;
        private System.Windows.Forms.ComboBox cmbbranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblapid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lnkinfo;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}