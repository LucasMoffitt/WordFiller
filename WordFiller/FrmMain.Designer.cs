using WordFiller.Controls;

namespace WordFiller
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tmr_UpdateHandPositions = new System.Windows.Forms.Timer(this.components);
            this.img_Hand = new System.Windows.Forms.PictureBox();
            this.img_header_terminator = new System.Windows.Forms.PictureBox();
            this.pnl_word_output = new System.Windows.Forms.FlowLayoutPanel();
            this.menuPanel = new WordFiller.Controls.MenuPanel();
            this.btn_library = new WordFiller.Controls.ActionButton();
            this.btn_clear = new WordFiller.Controls.ActionButton();
            this.btn_about = new WordFiller.Controls.ActionButton();
            this.btn_settings = new WordFiller.Controls.ActionButton();
            this.btn_check = new WordFiller.Controls.ActionButton();
            this.btn_exit = new WordFiller.Controls.ActionButton();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.PnlResults = new System.Windows.Forms.Panel();
            this.LblScore = new System.Windows.Forms.Label();
            this.pnl_content = new WordFiller.Controls.WordLayoutPanel();
            this.tmr_MenuAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img_Hand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_header_terminator)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.PnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "txt";
            this.OpenFileDialog.Filter = "Text File Documents (.txt)|*.txt";
            this.OpenFileDialog.Title = "Open your text document...";
            // 
            // tmr_UpdateHandPositions
            // 
            this.tmr_UpdateHandPositions.Tick += new System.EventHandler(this.tmr_UpdateHandPositions_Tick);
            // 
            // img_Hand
            // 
            this.img_Hand.BackColor = System.Drawing.Color.Transparent;
            this.img_Hand.Image = global::WordFiller.Properties.Resources.hand_default;
            this.img_Hand.Location = new System.Drawing.Point(0, 486);
            this.img_Hand.Name = "img_Hand";
            this.img_Hand.Size = new System.Drawing.Size(60, 80);
            this.img_Hand.TabIndex = 7;
            this.img_Hand.TabStop = false;
            this.img_Hand.Visible = false;
            // 
            // img_header_terminator
            // 
            this.img_header_terminator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_header_terminator.BackColor = System.Drawing.Color.Transparent;
            this.img_header_terminator.Image = global::WordFiller.Properties.Resources.header_terminator;
            this.img_header_terminator.Location = new System.Drawing.Point(959, 0);
            this.img_header_terminator.Name = "img_header_terminator";
            this.img_header_terminator.Size = new System.Drawing.Size(34, 154);
            this.img_header_terminator.TabIndex = 13;
            this.img_header_terminator.TabStop = false;
            // 
            // pnl_word_output
            // 
            this.pnl_word_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_word_output.Location = new System.Drawing.Point(30, 442);
            this.pnl_word_output.Name = "pnl_word_output";
            this.pnl_word_output.Size = new System.Drawing.Size(930, 108);
            this.pnl_word_output.TabIndex = 18;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.menuPanel.BackgroundImage = global::WordFiller.Properties.Resources.header_default;
            this.menuPanel.Controls.Add(this.btn_library);
            this.menuPanel.Controls.Add(this.btn_clear);
            this.menuPanel.Controls.Add(this.btn_about);
            this.menuPanel.Controls.Add(this.btn_settings);
            this.menuPanel.Controls.Add(this.btn_check);
            this.menuPanel.Controls.Add(this.btn_exit);
            this.menuPanel.Controls.Add(this.img_logo);
            this.menuPanel.Controls.Add(this.PnlResults);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(993, 99);
            this.menuPanel.TabIndex = 17;
            // 
            // btn_library
            // 
            this.btn_library.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_library.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.btn_library.DefaultImage = global::WordFiller.Properties.Resources.library_default;
            this.btn_library.FlatAppearance.BorderSize = 0;
            this.btn_library.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_library.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_library.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_library.ForeColor = System.Drawing.Color.White;
            this.btn_library.HoverImage = global::WordFiller.Properties.Resources.library_hover;
            this.btn_library.Image = global::WordFiller.Properties.Resources.library_default;
            this.btn_library.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_library.Location = new System.Drawing.Point(188, 188);
            this.btn_library.Name = "btn_library";
            this.btn_library.Size = new System.Drawing.Size(100, 139);
            this.btn_library.TabIndex = 19;
            this.btn_library.Text = "library";
            this.btn_library.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_library.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_library.UseVisualStyleBackColor = false;
            this.btn_library.Click += new System.EventHandler(this.btn_library_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.DefaultImage = global::WordFiller.Properties.Resources.clear_default;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.HoverImage = global::WordFiller.Properties.Resources.clear_hover;
            this.btn_clear.Image = global::WordFiller.Properties.Resources.clear_default;
            this.btn_clear.Location = new System.Drawing.Point(507, 15);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 84);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Visible = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.btn_about.DefaultImage = global::WordFiller.Properties.Resources.about_default;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.HoverImage = global::WordFiller.Properties.Resources.about_hover;
            this.btn_about.Image = global::WordFiller.Properties.Resources.about_default;
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_about.Location = new System.Drawing.Point(536, 188);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(111, 139);
            this.btn_about.TabIndex = 21;
            this.btn_about.Text = "about";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.btn_settings.DefaultImage = global::WordFiller.Properties.Resources.settings_default;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.HoverImage = global::WordFiller.Properties.Resources.settings_hover;
            this.btn_settings.Image = global::WordFiller.Properties.Resources.settings_default;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_settings.Location = new System.Drawing.Point(355, 188);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(128, 139);
            this.btn_settings.TabIndex = 20;
            this.btn_settings.Text = "settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check.BackColor = System.Drawing.Color.Transparent;
            this.btn_check.DefaultImage = global::WordFiller.Properties.Resources.checkanswers_default;
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.HoverImage = global::WordFiller.Properties.Resources.checkanswers_hover;
            this.btn_check.Image = global::WordFiller.Properties.Resources.checkanswers_default;
            this.btn_check.Location = new System.Drawing.Point(726, 7);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(140, 97);
            this.btn_check.TabIndex = 23;
            this.btn_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(139)))), ((int)(((byte)(167)))));
            this.btn_exit.DefaultImage = global::WordFiller.Properties.Resources.exit_default;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverImage = global::WordFiller.Properties.Resources.exit_hover;
            this.btn_exit.Image = global::WordFiller.Properties.Resources.exit_default;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_exit.Location = new System.Drawing.Point(712, 188);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(111, 139);
            this.btn_exit.TabIndex = 22;
            this.btn_exit.Text = "exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // img_logo
            // 
            this.img_logo.BackColor = System.Drawing.Color.Transparent;
            this.img_logo.Image = global::WordFiller.Properties.Resources.logo;
            this.img_logo.Location = new System.Drawing.Point(18, 3);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(285, 96);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logo.TabIndex = 15;
            this.img_logo.TabStop = false;
            // 
            // PnlResults
            // 
            this.PnlResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlResults.BackgroundImage = global::WordFiller.Properties.Resources.checkboard_hover;
            this.PnlResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlResults.Controls.Add(this.LblScore);
            this.PnlResults.Location = new System.Drawing.Point(643, 9);
            this.PnlResults.Name = "PnlResults";
            this.PnlResults.Size = new System.Drawing.Size(85, 90);
            this.PnlResults.TabIndex = 16;
            this.PnlResults.Visible = false;
            // 
            // LblScore
            // 
            this.LblScore.BackColor = System.Drawing.Color.Transparent;
            this.LblScore.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.ForeColor = System.Drawing.Color.Black;
            this.LblScore.Location = new System.Drawing.Point(10, 10);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(62, 73);
            this.LblScore.TabIndex = 1;
            this.LblScore.Text = "99";
            this.LblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.White;
            this.pnl_content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_content.Isfull = false;
            this.pnl_content.Location = new System.Drawing.Point(30, 107);
            this.pnl_content.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_content.Size = new System.Drawing.Size(930, 328);
            this.pnl_content.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WordFiller.Properties.Resources.header_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(991, 562);
            this.Controls.Add(this.pnl_word_output);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.img_Hand);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.img_header_terminator);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "WordFiller - Lucas Moffitt.com";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.img_Hand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_header_terminator)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.PnlResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WordLayoutPanel pnl_content;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Timer tmr_UpdateHandPositions;
        private System.Windows.Forms.PictureBox img_Hand;
        private System.Windows.Forms.PictureBox img_header_terminator;
        private MenuPanel menuPanel;
        private System.Windows.Forms.Panel PnlResults;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.PictureBox img_logo;
        private ActionButton btn_library;
        private ActionButton btn_settings;
        private ActionButton btn_exit;
        private ActionButton btn_about;
        private ActionButton btn_check;
        private System.Windows.Forms.FlowLayoutPanel pnl_word_output;
        private ActionButton btn_clear;
        private System.Windows.Forms.Timer tmr_MenuAnimation;

    }
}

