namespace newhospitalproject
{
    partial class DOCTORENTRY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOCTORENTRY));
            this.label3 = new System.Windows.Forms.Label();
            this.mskssn = new System.Windows.Forms.MaskedTextBox();
            this.txtpsswrd = new System.Windows.Forms.TextBox();
            this.labelsifre = new System.Windows.Forms.Label();
            this.lblhasta = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "DOCTOR ENTRY PANEL";
            // 
            // mskssn
            // 
            this.mskssn.Location = new System.Drawing.Point(95, 88);
            this.mskssn.Mask = "00000000000";
            this.mskssn.Name = "mskssn";
            this.mskssn.Size = new System.Drawing.Size(100, 20);
            this.mskssn.TabIndex = 14;
            this.mskssn.ValidatingType = typeof(int);
            // 
            // txtpsswrd
            // 
            this.txtpsswrd.Location = new System.Drawing.Point(95, 118);
            this.txtpsswrd.Name = "txtpsswrd";
            this.txtpsswrd.Size = new System.Drawing.Size(100, 20);
            this.txtpsswrd.TabIndex = 15;
            this.txtpsswrd.UseSystemPasswordChar = true;
            // 
            // labelsifre
            // 
            this.labelsifre.AutoSize = true;
            this.labelsifre.Location = new System.Drawing.Point(16, 121);
            this.labelsifre.Name = "labelsifre";
            this.labelsifre.Size = new System.Drawing.Size(73, 13);
            this.labelsifre.TabIndex = 18;
            this.labelsifre.Text = "PASSWORD:";
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Location = new System.Drawing.Point(50, 91);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(35, 13);
            this.lblhasta.TabIndex = 17;
            this.lblhasta.Text = " SSN:";
            // 
            // btngiris
            // 
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiris.Location = new System.Drawing.Point(95, 147);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(98, 26);
            this.btngiris.TabIndex = 16;
            this.btngiris.Text = " Entry";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(320, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(-1, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 78);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // DOCTORENTRY
            // 
            this.AcceptButton = this.btngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskssn);
            this.Controls.Add(this.txtpsswrd);
            this.Controls.Add(this.labelsifre);
            this.Controls.Add(this.lblhasta);
            this.Controls.Add(this.btngiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DOCTORENTRY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DOCTORENTRY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskssn;
        private System.Windows.Forms.TextBox txtpsswrd;
        private System.Windows.Forms.Label labelsifre;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}