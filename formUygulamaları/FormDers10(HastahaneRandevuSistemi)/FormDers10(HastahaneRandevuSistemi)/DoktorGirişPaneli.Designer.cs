namespace FormDers10_HastahaneRandevuSistemi_
{
    partial class DoktorGirişPaneli
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
            this.label3 = new System.Windows.Forms.Label();
            this.ÜyeLink = new System.Windows.Forms.LinkLabel();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.SifreBox = new System.Windows.Forms.TextBox();
            this.maskTC = new System.Windows.Forms.MaskedTextBox();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.TClabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doktor Giriş Paneli";
            // 
            // ÜyeLink
            // 
            this.ÜyeLink.AutoSize = true;
            this.ÜyeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÜyeLink.Location = new System.Drawing.Point(397, 160);
            this.ÜyeLink.Name = "ÜyeLink";
            this.ÜyeLink.Size = new System.Drawing.Size(66, 20);
            this.ÜyeLink.TabIndex = 12;
            this.ÜyeLink.TabStop = true;
            this.ÜyeLink.Text = "Üye Ol\r\n";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.Location = new System.Drawing.Point(294, 151);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(86, 29);
            this.BtnGirisYap.TabIndex = 11;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            // 
            // SifreBox
            // 
            this.SifreBox.Location = new System.Drawing.Point(253, 123);
            this.SifreBox.Name = "SifreBox";
            this.SifreBox.Size = new System.Drawing.Size(127, 22);
            this.SifreBox.TabIndex = 10;
            // 
            // maskTC
            // 
            this.maskTC.Location = new System.Drawing.Point(253, 69);
            this.maskTC.Mask = "00000000000";
            this.maskTC.Name = "maskTC";
            this.maskTC.Size = new System.Drawing.Size(127, 22);
            this.maskTC.TabIndex = 9;
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreLabel.Location = new System.Drawing.Point(112, 123);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(55, 20);
            this.SifreLabel.TabIndex = 8;
            this.SifreLabel.Text = "Şifre:";
            // 
            // TClabel
            // 
            this.TClabel.AutoSize = true;
            this.TClabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TClabel.Location = new System.Drawing.Point(112, 71);
            this.TClabel.Name = "TClabel";
            this.TClabel.Size = new System.Drawing.Size(135, 20);
            this.TClabel.TabIndex = 7;
            this.TClabel.Text = "T.C. Kimlik No:";
            // 
            // DoktorGirişPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ÜyeLink);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.SifreBox);
            this.Controls.Add(this.maskTC);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.TClabel);
            this.Name = "DoktorGirişPaneli";
            this.Text = "DoktorGirişPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ÜyeLink;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.TextBox SifreBox;
        private System.Windows.Forms.MaskedTextBox maskTC;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.Label TClabel;
    }
}