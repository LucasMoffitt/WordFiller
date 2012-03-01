namespace WordFiller
{
    partial class FrmConfig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.VideoOutputTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_header = new System.Windows.Forms.Label();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_questionmark2 = new System.Windows.Forms.Label();
            this.lbl_Note2 = new System.Windows.Forms.Label();
            this.lbl_handorientation = new System.Windows.Forms.Label();
            this.rdb_right = new System.Windows.Forms.RadioButton();
            this.rdb_left = new System.Windows.Forms.RadioButton();
            this.pnl_kinectsettings = new System.Windows.Forms.Panel();
            this.lbl_questionmark1 = new System.Windows.Forms.Label();
            this.lbl_Note1 = new System.Windows.Forms.Label();
            this.trackbar_kinecttilt = new System.Windows.Forms.TrackBar();
            this.img_kinectvideo = new System.Windows.Forms.PictureBox();
            this.checkbox_kinectstatus = new System.Windows.Forms.CheckBox();
            this.pnl_textsize = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Note3 = new System.Windows.Forms.Label();
            this.lbl_textsize = new System.Windows.Forms.Label();
            this.lbl_demotext = new System.Windows.Forms.Label();
            this.trackbar_textsize = new System.Windows.Forms.TrackBar();
            this.btn_exit = new WordFiller.Controls.ActionButton();
            this.pnl_content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_kinectsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_kinecttilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_kinectvideo)).BeginInit();
            this.pnl_textsize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_textsize)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoOutputTimer
            // 
            this.VideoOutputTimer.Tick += new System.EventHandler(this.VideoOutputTimer_Tick);
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(30, 25);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(259, 59);
            this.lbl_header.TabIndex = 15;
            this.lbl_header.Text = "settings";
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.White;
            this.pnl_content.Controls.Add(this.panel1);
            this.pnl_content.Controls.Add(this.pnl_kinectsettings);
            this.pnl_content.Controls.Add(this.pnl_textsize);
            this.pnl_content.Location = new System.Drawing.Point(25, 90);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(811, 581);
            this.pnl_content.TabIndex = 14;
            this.pnl_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_content_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.lbl_questionmark2);
            this.panel1.Controls.Add(this.lbl_Note2);
            this.panel1.Controls.Add(this.lbl_handorientation);
            this.panel1.Controls.Add(this.rdb_right);
            this.panel1.Controls.Add(this.rdb_left);
            this.panel1.Location = new System.Drawing.Point(412, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 341);
            this.panel1.TabIndex = 30;
            // 
            // lbl_questionmark2
            // 
            this.lbl_questionmark2.AutoSize = true;
            this.lbl_questionmark2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_questionmark2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionmark2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.lbl_questionmark2.Location = new System.Drawing.Point(5, 201);
            this.lbl_questionmark2.Name = "lbl_questionmark2";
            this.lbl_questionmark2.Size = new System.Drawing.Size(33, 34);
            this.lbl_questionmark2.TabIndex = 33;
            this.lbl_questionmark2.Text = "?";
            // 
            // lbl_Note2
            // 
            this.lbl_Note2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note2.Location = new System.Drawing.Point(43, 205);
            this.lbl_Note2.Name = "lbl_Note2";
            this.lbl_Note2.Size = new System.Drawing.Size(309, 144);
            this.lbl_Note2.TabIndex = 32;
            this.lbl_Note2.Text = resources.GetString("lbl_Note2.Text");
            // 
            // lbl_handorientation
            // 
            this.lbl_handorientation.AutoSize = true;
            this.lbl_handorientation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_handorientation.Location = new System.Drawing.Point(13, 21);
            this.lbl_handorientation.Name = "lbl_handorientation";
            this.lbl_handorientation.Size = new System.Drawing.Size(143, 22);
            this.lbl_handorientation.TabIndex = 28;
            this.lbl_handorientation.Text = "hand orientation";
            // 
            // rdb_right
            // 
            this.rdb_right.Checked = true;
            this.rdb_right.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_right.Image = global::WordFiller.Properties.Resources.hand_right;
            this.rdb_right.Location = new System.Drawing.Point(221, 60);
            this.rdb_right.Name = "rdb_right";
            this.rdb_right.Size = new System.Drawing.Size(104, 120);
            this.rdb_right.TabIndex = 29;
            this.rdb_right.TabStop = true;
            this.rdb_right.Text = "Right Handed";
            this.rdb_right.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rdb_right.UseVisualStyleBackColor = true;
            this.rdb_right.CheckedChanged += new System.EventHandler(this.rdb_right_CheckedChanged);
            // 
            // rdb_left
            // 
            this.rdb_left.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_left.Image = global::WordFiller.Properties.Resources.hand_left;
            this.rdb_left.Location = new System.Drawing.Point(46, 60);
            this.rdb_left.Name = "rdb_left";
            this.rdb_left.Size = new System.Drawing.Size(96, 120);
            this.rdb_left.TabIndex = 28;
            this.rdb_left.TabStop = true;
            this.rdb_left.Text = "Left Handed";
            this.rdb_left.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rdb_left.UseVisualStyleBackColor = true;
            this.rdb_left.CheckedChanged += new System.EventHandler(this.rdb_left_CheckedChanged);
            // 
            // pnl_kinectsettings
            // 
            this.pnl_kinectsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_kinectsettings.Controls.Add(this.lbl_questionmark1);
            this.pnl_kinectsettings.Controls.Add(this.lbl_Note1);
            this.pnl_kinectsettings.Controls.Add(this.trackbar_kinecttilt);
            this.pnl_kinectsettings.Controls.Add(this.img_kinectvideo);
            this.pnl_kinectsettings.Controls.Add(this.checkbox_kinectstatus);
            this.pnl_kinectsettings.Location = new System.Drawing.Point(31, 211);
            this.pnl_kinectsettings.Name = "pnl_kinectsettings";
            this.pnl_kinectsettings.Size = new System.Drawing.Size(365, 341);
            this.pnl_kinectsettings.TabIndex = 27;
            // 
            // lbl_questionmark1
            // 
            this.lbl_questionmark1.AutoSize = true;
            this.lbl_questionmark1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_questionmark1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_questionmark1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.lbl_questionmark1.Location = new System.Drawing.Point(13, 290);
            this.lbl_questionmark1.Name = "lbl_questionmark1";
            this.lbl_questionmark1.Size = new System.Drawing.Size(33, 34);
            this.lbl_questionmark1.TabIndex = 31;
            this.lbl_questionmark1.Text = "?";
            // 
            // lbl_Note1
            // 
            this.lbl_Note1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note1.Location = new System.Drawing.Point(43, 290);
            this.lbl_Note1.Name = "lbl_Note1";
            this.lbl_Note1.Size = new System.Drawing.Size(281, 43);
            this.lbl_Note1.TabIndex = 29;
            this.lbl_Note1.Text = "This is you! If your camera isn\'t right, move the slider to adjust camera tilt.";
            // 
            // trackbar_kinecttilt
            // 
            this.trackbar_kinecttilt.Location = new System.Drawing.Point(317, 60);
            this.trackbar_kinecttilt.Maximum = 27;
            this.trackbar_kinecttilt.Minimum = -27;
            this.trackbar_kinecttilt.Name = "trackbar_kinecttilt";
            this.trackbar_kinecttilt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbar_kinecttilt.Size = new System.Drawing.Size(45, 227);
            this.trackbar_kinecttilt.TabIndex = 21;
            this.trackbar_kinecttilt.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackbar_kinecttilt.Scroll += new System.EventHandler(this.trackbar_kinecttilt_Scroll);
            // 
            // img_kinectvideo
            // 
            this.img_kinectvideo.ErrorImage = global::WordFiller.Properties.Resources.microsoft_kinect;
            this.img_kinectvideo.Image = global::WordFiller.Properties.Resources.microsoft_kinect;
            this.img_kinectvideo.InitialImage = global::WordFiller.Properties.Resources.microsoft_kinect;
            this.img_kinectvideo.Location = new System.Drawing.Point(17, 60);
            this.img_kinectvideo.Name = "img_kinectvideo";
            this.img_kinectvideo.Size = new System.Drawing.Size(281, 227);
            this.img_kinectvideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_kinectvideo.TabIndex = 20;
            this.img_kinectvideo.TabStop = false;
            // 
            // checkbox_kinectstatus
            // 
            this.checkbox_kinectstatus.AutoSize = true;
            this.checkbox_kinectstatus.Font = new System.Drawing.Font("Arial", 14.25F);
            this.checkbox_kinectstatus.Location = new System.Drawing.Point(17, 21);
            this.checkbox_kinectstatus.Name = "checkbox_kinectstatus";
            this.checkbox_kinectstatus.Size = new System.Drawing.Size(162, 26);
            this.checkbox_kinectstatus.TabIndex = 17;
            this.checkbox_kinectstatus.Text = "kinect enabled?";
            this.checkbox_kinectstatus.UseVisualStyleBackColor = true;
            this.checkbox_kinectstatus.CheckedChanged += new System.EventHandler(this.checkbox_kinectstatus_CheckedChanged);
            // 
            // pnl_textsize
            // 
            this.pnl_textsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_textsize.Controls.Add(this.label1);
            this.pnl_textsize.Controls.Add(this.lbl_Note3);
            this.pnl_textsize.Controls.Add(this.lbl_textsize);
            this.pnl_textsize.Controls.Add(this.lbl_demotext);
            this.pnl_textsize.Controls.Add(this.trackbar_textsize);
            this.pnl_textsize.Location = new System.Drawing.Point(31, 45);
            this.pnl_textsize.Name = "pnl_textsize";
            this.pnl_textsize.Size = new System.Drawing.Size(746, 138);
            this.pnl_textsize.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(596, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "?";
            // 
            // lbl_Note3
            // 
            this.lbl_Note3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note3.Location = new System.Drawing.Point(502, 50);
            this.lbl_Note3.Name = "lbl_Note3";
            this.lbl_Note3.Size = new System.Drawing.Size(231, 70);
            this.lbl_Note3.TabIndex = 30;
            this.lbl_Note3.Text = "This is the size of the text you will see on the main board. If you\'re not happy " +
    "with it, move the slider to change it.";
            // 
            // lbl_textsize
            // 
            this.lbl_textsize.AutoSize = true;
            this.lbl_textsize.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textsize.Location = new System.Drawing.Point(13, 22);
            this.lbl_textsize.Name = "lbl_textsize";
            this.lbl_textsize.Size = new System.Drawing.Size(79, 22);
            this.lbl_textsize.TabIndex = 27;
            this.lbl_textsize.Text = "text size";
            // 
            // lbl_demotext
            // 
            this.lbl_demotext.BackColor = System.Drawing.Color.Transparent;
            this.lbl_demotext.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_demotext.Location = new System.Drawing.Point(128, 51);
            this.lbl_demotext.Name = "lbl_demotext";
            this.lbl_demotext.Size = new System.Drawing.Size(309, 69);
            this.lbl_demotext.TabIndex = 27;
            this.lbl_demotext.Text = "WordFiller";
            this.lbl_demotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackbar_textsize
            // 
            this.trackbar_textsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.trackbar_textsize.Location = new System.Drawing.Point(119, 14);
            this.trackbar_textsize.Maximum = 40;
            this.trackbar_textsize.Minimum = 15;
            this.trackbar_textsize.Name = "trackbar_textsize";
            this.trackbar_textsize.Size = new System.Drawing.Size(326, 45);
            this.trackbar_textsize.TabIndex = 26;
            this.trackbar_textsize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackbar_textsize.Value = 15;
            this.trackbar_textsize.Scroll += new System.EventHandler(this.trackbar_textsize_Scroll);
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
            this.btn_exit.Location = new System.Drawing.Point(752, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 84);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.BackgroundImage = global::WordFiller.Properties.Resources.header_default;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(864, 693);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.pnl_content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfig";
            this.Text = "FrmConfig";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.pnl_content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_kinectsettings.ResumeLayout(false);
            this.pnl_kinectsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_kinecttilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_kinectvideo)).EndInit();
            this.pnl_textsize.ResumeLayout(false);
            this.pnl_textsize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_textsize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer VideoOutputTimer;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.CheckBox checkbox_kinectstatus;
        private System.Windows.Forms.Panel pnl_kinectsettings;
        private System.Windows.Forms.Panel pnl_textsize;
        private System.Windows.Forms.Label lbl_textsize;
        private System.Windows.Forms.Label lbl_demotext;
        private System.Windows.Forms.TrackBar trackbar_textsize;
        private System.Windows.Forms.TrackBar trackbar_kinecttilt;
        private System.Windows.Forms.PictureBox img_kinectvideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_questionmark2;
        private System.Windows.Forms.Label lbl_Note2;
        private System.Windows.Forms.Label lbl_handorientation;
        private System.Windows.Forms.RadioButton rdb_right;
        private System.Windows.Forms.RadioButton rdb_left;
        private System.Windows.Forms.Label lbl_questionmark1;
        private System.Windows.Forms.Label lbl_Note1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Note3;
        private Controls.ActionButton btn_exit;
    }
}