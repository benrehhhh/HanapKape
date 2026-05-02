namespace HanapKafe
{
    partial class HanapKapeHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HanapKapeHome));
            this.GmailLink = new System.Windows.Forms.LinkLabel();
            this.ExploreNBtn = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GmailLink
            // 
            this.GmailLink.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.GmailLink.AutoSize = true;
            this.GmailLink.LinkColor = System.Drawing.Color.Black;
            this.GmailLink.Location = new System.Drawing.Point(654, 505);
            this.GmailLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GmailLink.Name = "GmailLink";
            this.GmailLink.Size = new System.Drawing.Size(88, 13);
            this.GmailLink.TabIndex = 2;
            this.GmailLink.TabStop = true;
            this.GmailLink.Text = "✉︎Connect Gmail";
            // 
            // ExploreNBtn
            // 
            this.ExploreNBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.ExploreNBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExploreNBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.ExploreNBtn.ForeColor = System.Drawing.Color.White;
            this.ExploreNBtn.Location = new System.Drawing.Point(527, 334);
            this.ExploreNBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExploreNBtn.Name = "ExploreNBtn";
            this.ExploreNBtn.Size = new System.Drawing.Size(137, 46);
            this.ExploreNBtn.TabIndex = 0;
            this.ExploreNBtn.Text = "📍Explore Nearby";
            this.ExploreNBtn.UseVisualStyleBackColor = false;
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.Transparent;
            this.Registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registerbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbtn.ForeColor = System.Drawing.Color.Black;
            this.Registerbtn.Location = new System.Drawing.Point(726, 334);
            this.Registerbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(142, 46);
            this.Registerbtn.TabIndex = 1;
            this.Registerbtn.Text = "✍Register your Shop";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.WelcomeLabel.Location = new System.Drawing.Point(548, 251);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(329, 32);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Welcome to HanapKape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(585, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Discover coffee near you";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(547, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // HanapKapeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1389, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.GmailLink);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.ExploreNBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HanapKapeHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HanapKape";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel GmailLink;
        private System.Windows.Forms.Button ExploreNBtn;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

