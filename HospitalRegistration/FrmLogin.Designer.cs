namespace HospitalRegistration
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnPat = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPat
            // 
            this.btnPat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPat.BackgroundImage")));
            this.btnPat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPat.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPat.Location = new System.Drawing.Point(11, 175);
            this.btnPat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPat.Name = "btnPat";
            this.btnPat.Size = new System.Drawing.Size(223, 171);
            this.btnPat.TabIndex = 0;
            this.btnPat.UseVisualStyleBackColor = true;
            this.btnPat.Click += new System.EventHandler(this.btnPat_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoc.BackgroundImage")));
            this.btnDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoc.Location = new System.Drawing.Point(277, 175);
            this.btnDoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(223, 171);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSec.BackgroundImage")));
            this.btnSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSec.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(536, 175);
            this.btnSec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(223, 171);
            this.btnSec.TabIndex = 2;
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tough Steel Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(327, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(565, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(770, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnPat);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Tough Steel Hospital Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPat;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

