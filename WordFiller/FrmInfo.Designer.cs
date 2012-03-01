namespace WordFiller
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.pnl_content = new System.Windows.Forms.Panel();
            this.lbl_UserGuide_Web = new System.Windows.Forms.Label();
            this.img_Lucas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Elise_Web = new System.Windows.Forms.Label();
            this.lbl_Elise_Twitter = new System.Windows.Forms.Label();
            this.lbl_Lucas_Web = new System.Windows.Forms.Label();
            this.lbl_Lucas_Twitter = new System.Windows.Forms.Label();
            this.lbl_about = new System.Windows.Forms.Label();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_exit = new WordFiller.Controls.ActionButton();
            this.pnl_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Lucas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.White;
            this.pnl_content.Controls.Add(this.lbl_UserGuide_Web);
            this.pnl_content.Controls.Add(this.img_Lucas);
            this.pnl_content.Controls.Add(this.pictureBox1);
            this.pnl_content.Controls.Add(this.lbl_Elise_Web);
            this.pnl_content.Controls.Add(this.lbl_Elise_Twitter);
            this.pnl_content.Controls.Add(this.lbl_Lucas_Web);
            this.pnl_content.Controls.Add(this.lbl_Lucas_Twitter);
            this.pnl_content.Controls.Add(this.lbl_about);
            this.pnl_content.Controls.Add(this.img_logo);
            this.pnl_content.Location = new System.Drawing.Point(25, 90);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(535, 518);
            this.pnl_content.TabIndex = 7;
            // 
            // lbl_UserGuide_Web
            // 
            this.lbl_UserGuide_Web.AutoSize = true;
            this.lbl_UserGuide_Web.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserGuide_Web.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.lbl_UserGuide_Web.Location = new System.Drawing.Point(99, 324);
            this.lbl_UserGuide_Web.Name = "lbl_UserGuide_Web";
            this.lbl_UserGuide_Web.Size = new System.Drawing.Size(321, 24);
            this.lbl_UserGuide_Web.TabIndex = 37;
            this.lbl_UserGuide_Web.Text = "Click here to read the User Guide";
            // 
            // img_Lucas
            // 
            this.img_Lucas.BackColor = System.Drawing.Color.Transparent;
            this.img_Lucas.Image = global::WordFiller.Properties.Resources.lucasmoffitt;
            this.img_Lucas.Location = new System.Drawing.Point(20, 395);
            this.img_Lucas.Name = "img_Lucas";
            this.img_Lucas.Size = new System.Drawing.Size(196, 54);
            this.img_Lucas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Lucas.TabIndex = 36;
            this.img_Lucas.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WordFiller.Properties.Resources.eliseboyd;
            this.pictureBox1.Location = new System.Drawing.Point(317, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Elise_Web
            // 
            this.lbl_Elise_Web.AutoSize = true;
            this.lbl_Elise_Web.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Elise_Web.Location = new System.Drawing.Point(327, 481);
            this.lbl_Elise_Web.Name = "lbl_Elise_Web";
            this.lbl_Elise_Web.Size = new System.Drawing.Size(186, 18);
            this.lbl_Elise_Web.TabIndex = 34;
            this.lbl_Elise_Web.Text = "http://www.EliseBoyd.com";
            this.lbl_Elise_Web.Click += new System.EventHandler(this.lbl_Elise_Web_Click);
            // 
            // lbl_Elise_Twitter
            // 
            this.lbl_Elise_Twitter.AutoSize = true;
            this.lbl_Elise_Twitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Elise_Twitter.Location = new System.Drawing.Point(454, 455);
            this.lbl_Elise_Twitter.Name = "lbl_Elise_Twitter";
            this.lbl_Elise_Twitter.Size = new System.Drawing.Size(59, 18);
            this.lbl_Elise_Twitter.TabIndex = 33;
            this.lbl_Elise_Twitter.Text = "@Elise";
            this.lbl_Elise_Twitter.Click += new System.EventHandler(this.lbl_Elise_Twitter_Click);
            // 
            // lbl_Lucas_Web
            // 
            this.lbl_Lucas_Web.AutoSize = true;
            this.lbl_Lucas_Web.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lucas_Web.Location = new System.Drawing.Point(17, 481);
            this.lbl_Lucas_Web.Name = "lbl_Lucas_Web";
            this.lbl_Lucas_Web.Size = new System.Drawing.Size(199, 18);
            this.lbl_Lucas_Web.TabIndex = 30;
            this.lbl_Lucas_Web.Text = "http://www.LucasMoffitt.com";
            this.lbl_Lucas_Web.Click += new System.EventHandler(this.lbl_Lucas_Web_Click);
            // 
            // lbl_Lucas_Twitter
            // 
            this.lbl_Lucas_Twitter.AutoSize = true;
            this.lbl_Lucas_Twitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lucas_Twitter.Location = new System.Drawing.Point(17, 455);
            this.lbl_Lucas_Twitter.Name = "lbl_Lucas_Twitter";
            this.lbl_Lucas_Twitter.Size = new System.Drawing.Size(108, 18);
            this.lbl_Lucas_Twitter.TabIndex = 29;
            this.lbl_Lucas_Twitter.Text = "@LucasMoffitt";
            this.lbl_Lucas_Twitter.Click += new System.EventHandler(this.lbl_Lucas_Twitter_Click);
            // 
            // lbl_about
            // 
            this.lbl_about.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_about.Location = new System.Drawing.Point(17, 14);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(376, 276);
            this.lbl_about.TabIndex = 27;
            this.lbl_about.Text = resources.GetString("lbl_about.Text");
            // 
            // img_logo
            // 
            this.img_logo.BackColor = System.Drawing.Color.Transparent;
            this.img_logo.Image = global::WordFiller.Properties.Resources.logo_small;
            this.img_logo.Location = new System.Drawing.Point(399, 4);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(128, 128);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_logo.TabIndex = 13;
            this.img_logo.TabStop = false;
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(30, 25);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(259, 59);
            this.lbl_header.TabIndex = 10;
            this.lbl_header.Text = "about";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.DefaultImage = global::WordFiller.Properties.Resources.exit_default_small;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverImage = global::WordFiller.Properties.Resources.exit_hover_small;
            this.btn_exit.Image = global::WordFiller.Properties.Resources.exit_default_small;
            this.btn_exit.Location = new System.Drawing.Point(474, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 84);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.BackgroundImage = global::WordFiller.Properties.Resources.header_default;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(588, 644);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.pnl_content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInfo";
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Lucas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.PictureBox img_logo;
        private Controls.ActionButton btn_exit;
        private System.Windows.Forms.Label lbl_about;
        private System.Windows.Forms.Label lbl_Lucas_Web;
        private System.Windows.Forms.Label lbl_Lucas_Twitter;
        private System.Windows.Forms.Label lbl_Elise_Web;
        private System.Windows.Forms.Label lbl_Elise_Twitter;
        private System.Windows.Forms.PictureBox img_Lucas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_UserGuide_Web;
    }
}