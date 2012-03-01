using System;
using System.Drawing;
using System.Windows.Forms;
using WordFiller.Framework;
using WordFiller.Properties;

namespace WordFiller
{
    public partial class FrmLibrary : Form
    {
        public FrmLibrary()
        {
            InitializeComponent();
            Closed += (FrmLibrary_Closed);
        }
    
        void FrmLibrary_Closed(object sender, EventArgs e)
        {
            ManageWindows.Forms.Remove(this);
        }

        private  void FrmLibrary_Load(object sender, EventArgs e)
        {
            ManageWindows.Forms.Add(this);

            Library.CheckLibrarySatus();
            DisplayLibraryContents();
        }

        private void DisplayLibraryContents()
        {
            Library.LoadLibraryItemList();
            lst_collection.Items.Clear();

            foreach (var resource in Library._resourceCollection)
            {
                lst_collection.Items.Add(resource);
            }
        }
        
        private void SaveCurrentLibraryItem()
        {
            if (txt_title.Text != "")
            {
                txt_title.Enabled = false;
                txt_title.BackColor = Color.FromArgb(237, 234, 227);
                Library.SaveResource(txt_title.Text, txt_content.Text);

                DisplayLibraryContents();
                lst_collection.Enabled = true;

                return;
            }

            MessageBox.Show(Resources.Null_Resource_Title_Content,
                            Resources.Null_Resource_Title_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }    

        private void OpenResourceItem()
        {
            txt_title.Text = lst_collection.SelectedItem.ToString();
            txt_content.Text = Library.ReadResource(lst_collection.SelectedItem.ToString());
        }      

        private void CreateNewResource()
        {
            lst_collection.Enabled = false;
            txt_title.Enabled = true;
            txt_title.Clear();
            txt_title.BackColor = Color.White;
            txt_title.Focus();
            txt_content.Clear();
        }
        
        private void lst_collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_collection.SelectedItem != null)
            {
                OpenResourceItem();
            }
        }

        private void btn_add_brackets_Click(object sender, EventArgs e)
        {
            if (!Library.IsWordWrappedInBrackets(txt_content.SelectedText) && txt_content.SelectedText != "")
            {
                txt_content.SelectedText = Library.WrapInBrackets(txt_content.SelectedText);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (lst_collection.SelectedItem == null)
            {
                MessageBox.Show(Resources.No_Resource_Selected_Content, Resources.No_Resource_Selected_Title,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string fileurl = (Library.LibraryLocation + lst_collection.SelectedItem + @".txt");

            foreach (var w in ManageWindows.Forms)
            {
                if (w is FrmMain)
                {
                    (w as FrmMain).OpenGivenResource(fileurl);
                    (w as FrmMain).currentResource = fileurl;
                }
            }

            Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_title.Text != null)
            {
                Library.DeleteResource(txt_title.Text);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            CreateNewResource();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveCurrentLibraryItem();
        }

    }
}
