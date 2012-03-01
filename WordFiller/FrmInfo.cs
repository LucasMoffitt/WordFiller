using System.Windows.Forms;
using WordFiller.Framework;

namespace WordFiller
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
            Closed += (FrmInfo_Closed);
        }

        void FrmInfo_Closed(object sender, System.EventArgs e)
        {
            ManageWindows.Forms.Remove(this);
        }

        private void FrmInfo_Load(object sender, System.EventArgs e)
        {
            ManageWindows.Forms.Add(this);
        }

        private void btn_exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void lbl_Lucas_Twitter_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/lucasmoffitt");
        }

        private void lbl_Lucas_Web_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://www.lucasmoffitt.com/?utm_source=WordFiller&utm_medium=Application&utm_campaign=Version2");
        }

        private void lbl_Elise_Twitter_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/elise");
        }

        private void lbl_Elise_Web_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://www.eliseboyd.com/?utm_source=WordFiller&utm_medium=Application&utm_campaign=Version2");
        }
    }
}
