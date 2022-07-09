namespace newhospitalproject
{
    partial class SecreteryEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecreteryEntry));
            this.label3 = new System.Windows.Forms.Label();
            this.mskssn = new System.Windows.Forms.MaskedTextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.labelsifre = new System.Windows.Forms.Label();
            this.lblhasta = new System.Windows.Forms.Label();
            this.btnentry = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 78);
            this.label3.TabIndex = 18;
            this.label3.Text = "SECRETERY \r\nENTRY PANEL";
            // 
            // mskssn
            // 
            this.mskssn.Location = new System.Drawing.Point(107, 91);
            this.mskssn.Mask = "00000000000";
            this.mskssn.Name = "mskssn";
            this.mskssn.Size = new System.Drawing.Size(100, 20);
            this.mskssn.TabIndex = 13;
            this.mskssn.ValidatingType = typeof(int);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(107, 122);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 14;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // labelsifre
            // 
            this.labelsifre.AutoSize = true;
            this.labelsifre.Location = new System.Drawing.Point(9, 124);
            this.labelsifre.Name = "labelsifre";
            this.labelsifre.Size = new System.Drawing.Size(73, 13);
            this.labelsifre.TabIndex = 17;
            this.labelsifre.Text = "PASSWORD:";
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Location = new System.Drawing.Point(50, 93);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(32, 13);
            this.lblhasta.TabIndex = 16;
            this.lblhasta.Text = "SSN:";
            // 
            // btnentry
            // 
            this.btnentry.Location = new System.Drawing.Point(107, 152);
            this.btnentry.Name = "btnentry";
            this.btnentry.Size = new System.Drawing.Size(98, 26);
            this.btnentry.TabIndex = 15;
            this.btnentry.Text = "Entry";
            this.btnentry.UseVisualStyleBackColor = true;
            this.btnentry.Click += new System.EventHandler(this.btnentry_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 78);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // SecreteryEntry
            // 
            this.AcceptButton = this.btnentry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(355, 200);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskssn);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.labelsifre);
            this.Controls.Add(this.lblhasta);
            this.Controls.Add(this.btnentry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecreteryEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecreteryEntry";
            this.Load += new System.EventHandler(this.SecreteryEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskssn;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label labelsifre;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.Button btnentry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}