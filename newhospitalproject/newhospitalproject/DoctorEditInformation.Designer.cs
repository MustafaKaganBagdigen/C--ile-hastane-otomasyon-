namespace newhospitalproject
{
    partial class DoctorEditInformation
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbbranch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msbssn = new System.Windows.Forms.MaskedTextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblconid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.Location = new System.Drawing.Point(123, 184);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(124, 30);
            this.btnupdate.TabIndex = 41;
            this.btnupdate.Text = " Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cmbbranch
            // 
            this.cmbbranch.FormattingEnabled = true;
            this.cmbbranch.Location = new System.Drawing.Point(123, 102);
            this.cmbbranch.Name = "cmbbranch";
            this.cmbbranch.Size = new System.Drawing.Size(124, 28);
            this.cmbbranch.TabIndex = 34;
            this.cmbbranch.SelectedIndexChanged += new System.EventHandler(this.cmbbranch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = " Branch:";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(123, 138);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(124, 26);
            this.txtpassword.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Password:";
            // 
            // msbssn
            // 
            this.msbssn.Location = new System.Drawing.Point(123, 70);
            this.msbssn.Mask = "00000000000";
            this.msbssn.Name = "msbssn";
            this.msbssn.Size = new System.Drawing.Size(124, 26);
            this.msbssn.TabIndex = 33;
            this.msbssn.ValidatingType = typeof(int);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(123, 38);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(124, 26);
            this.txtname.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = " SSN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-4, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name/Surname:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbbranch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msbssn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 224);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(38, 259);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 43;
            this.lblid.Text = "label2";
            // 
            // lblconid
            // 
            this.lblconid.AutoSize = true;
            this.lblconid.Location = new System.Drawing.Point(101, 254);
            this.lblconid.Name = "lblconid";
            this.lblconid.Size = new System.Drawing.Size(13, 13);
            this.lblconid.TabIndex = 44;
            this.lblconid.Text = "0";
            this.lblconid.TextChanged += new System.EventHandler(this.lblconid_TextChanged);
            // 
            // DoctorEditInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(280, 238);
            this.Controls.Add(this.lblconid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DoctorEditInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIT INFORMATION";
            this.Load += new System.EventHandler(this.DoctorEditInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox cmbbranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msbssn;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblconid;
    }
}