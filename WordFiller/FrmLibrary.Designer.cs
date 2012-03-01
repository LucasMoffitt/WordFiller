namespace WordFiller
{
    partial class FrmLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibrary));
            this.pnl_content = new System.Windows.Forms.Panel();
            this.lbl_editingtools = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.BtnAddBrackets = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.lst_collection = new System.Windows.Forms.ListBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_exit = new WordFiller.Controls.ActionButton();
            this.pnl_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.White;
            this.pnl_content.Controls.Add(this.lbl_editingtools);
            this.pnl_content.Controls.Add(this.btn_delete);
            this.pnl_content.Controls.Add(this.lbl_title);
            this.pnl_content.Controls.Add(this.btn_open);
            this.pnl_content.Controls.Add(this.BtnAddBrackets);
            this.pnl_content.Controls.Add(this.btn_new);
            this.pnl_content.Controls.Add(this.txt_title);
            this.pnl_content.Controls.Add(this.btn_save);
            this.pnl_content.Controls.Add(this.txt_content);
            this.pnl_content.Controls.Add(this.lst_collection);
            this.pnl_content.Location = new System.Drawing.Point(25, 90);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(774, 418);
            this.pnl_content.TabIndex = 0;
            // 
            // lbl_editingtools
            // 
            this.lbl_editingtools.AutoSize = true;
            this.lbl_editingtools.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editingtools.Location = new System.Drawing.Point(295, 311);
            this.lbl_editingtools.Name = "lbl_editingtools";
            this.lbl_editingtools.Size = new System.Drawing.Size(96, 18);
            this.lbl_editingtools.TabIndex = 26;
            this.lbl_editingtools.Text = "editing tools:";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::WordFiller.Properties.Resources.deletebutton;
            this.btn_delete.Location = new System.Drawing.Point(190, 352);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(79, 62);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(295, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(101, 18);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "resource title:";
            // 
            // btn_open
            // 
            this.btn_open.FlatAppearance.BorderSize = 0;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Image = global::WordFiller.Properties.Resources.openresource;
            this.btn_open.Location = new System.Drawing.Point(628, 326);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(121, 88);
            this.btn_open.TabIndex = 23;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // BtnAddBrackets
            // 
            this.BtnAddBrackets.BackColor = System.Drawing.Color.White;
            this.BtnAddBrackets.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAddBrackets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.BtnAddBrackets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.BtnAddBrackets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBrackets.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBrackets.Location = new System.Drawing.Point(298, 332);
            this.BtnAddBrackets.Name = "BtnAddBrackets";
            this.BtnAddBrackets.Size = new System.Drawing.Size(105, 29);
            this.BtnAddBrackets.TabIndex = 22;
            this.BtnAddBrackets.Text = "Brackets";
            this.BtnAddBrackets.UseVisualStyleBackColor = false;
            this.BtnAddBrackets.Click += new System.EventHandler(this.btn_add_brackets_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Transparent;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = global::WordFiller.Properties.Resources.newbutton;
            this.btn_new.Location = new System.Drawing.Point(16, 351);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(78, 63);
            this.btn_new.TabIndex = 21;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.txt_title.Enabled = false;
            this.txt_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(298, 38);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(451, 35);
            this.txt_title.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::WordFiller.Properties.Resources.savebutton;
            this.btn_save.Location = new System.Drawing.Point(102, 351);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 63);
            this.btn_save.TabIndex = 19;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_content
            // 
            this.txt_content.BackColor = System.Drawing.Color.White;
            this.txt_content.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txt_content.Location = new System.Drawing.Point(298, 79);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_content.Size = new System.Drawing.Size(451, 228);
            this.txt_content.TabIndex = 2;
            // 
            // lst_collection
            // 
            this.lst_collection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.lst_collection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_collection.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_collection.FormattingEnabled = true;
            this.lst_collection.ItemHeight = 22;
            this.lst_collection.Location = new System.Drawing.Point(16, 18);
            this.lst_collection.Name = "lst_collection";
            this.lst_collection.Size = new System.Drawing.Size(253, 332);
            this.lst_collection.TabIndex = 17;
            this.lst_collection.SelectedIndexChanged += new System.EventHandler(this.lst_collection_SelectedIndexChanged);
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(30, 25);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(259, 59);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "library";
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
            this.btn_exit.Location = new System.Drawing.Point(716, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 72);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FrmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.BackgroundImage = global::WordFiller.Properties.Resources.header_default;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(827, 544);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.pnl_content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLibrary";
            this.Text = "FrmLibrary";
            this.Load += new System.EventHandler(this.FrmLibrary_Load);
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button BtnAddBrackets;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.ListBox lst_collection;
        private System.Windows.Forms.Label lbl_header;
        private Controls.ActionButton btn_exit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_editingtools;

    }
}