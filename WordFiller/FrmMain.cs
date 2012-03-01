using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WordFiller.Controls;
using WordFiller.Framework;
using WordFiller.Kinect;

namespace WordFiller
{
    public partial class FrmMain : Form
    {
        private readonly Regex _regex = new Regex("<[^>]*>");

        private bool _isphrase;
        public string currentResource;

        private int _fontsize;
        private StringBuilder phrasebuilder = new StringBuilder();
        private List<string> InputText = new List<string>();
        private List<List<Label>> LabelsList = new List<List<Label>>();

        public FrmMain()
        {
            InitializeComponent();
            Closing += (FrmMain_Closing);
        }

        private void FrmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            KinectSettings.DisableKinect();
            ManageWindows.Forms.Remove(this);
        }

        public void CloseMenu()
        {
            menuPanel.CloseMenu();
        }

        public void OpenMenu()
        {
            menuPanel.OpenMenu();
        }

        private void StartupCheck_Settings()
        {
            if (!Settings.DoSettingsExist)
            {
                Settings.CreateSettingsXMLFile();
            }
        }

        public void StartupCheck_Kinect()
        {
            if (Settings.GetKinectStatus())
            {
                KinectSettings.EnableKinect();

                img_Hand.Visible = true;
                tmr_UpdateHandPositions.Enabled = true;
                return;
            }

            KinectSettings.DisableKinect();
            img_Hand.Visible = false;
            tmr_UpdateHandPositions.Enabled = false;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            menuPanel.MakeReady();

            StartupCheck_Settings();
         
            StartupCheck_Kinect();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            KinectSettings.DisableKinect();
        }

        public void OpenGivenResource(string textfile)
        {
            using (StreamReader reader = new StreamReader(textfile))
            {
                string line;

                ClearLabelsAndRemoveFromBoard();
                LabelsList.Clear();

                while ((line = reader.ReadLine()) != null)
                {
                    InputText.Add(line);
                }
            }

            UpdateTextSize();
            OpenDocument();

            pnl_content.SendToBack();
        }

        private void OpenDocument()
        {
            ResetPhraseBuilder();

            foreach (string[] words in InputText.Select(line => line.Split(' ')))
            {
                foreach (var word in words)
                {
                    if (pnl_content.Isfull)
                        break;

                    if (_regex.IsMatch(word))
                    {
                        ShowReadyLabelSetsOnBoard(word);
                        continue;
                    }

                    if (IsThisPartOfAPhrase(word))
                    {
                        continue;
                    }

                    ShowReadyRegularLabelOnBoard(word);
                }

                pnl_content.StartNewContentLine(_fontsize);
            }

            ShuffleLabels();

            pnl_word_output.SuspendLayout();
        }

        private void ShuffleLabels()
        {
            var randomNumber = new Random();
            foreach (Control pnlContents in pnl_word_output.Controls)
            {
                pnl_word_output.Controls.SetChildIndex(pnlContents, randomNumber.Next());
            }
        }

        private bool IsThisPartOfAPhrase(string word)
        {
            if (word.Length >= 2)
            {
                if (word[0] == '<' & word[word.Length - 1] != '>')
                {
                    phrasebuilder.Append(word + " ");
                    _isphrase = true;
                    return true;
                }

                if (_isphrase)
                {
                    if (word[0] != '<' & word[word.Length - 1] != '>')
                    {
                        phrasebuilder.Append(word + " ");
                        return true;
                    }
                    if (word[0] != '<' & word[word.Length - 1] == '>')
                    {
                        phrasebuilder.Append(word);
                        _isphrase = false;
                        ShowReadyLabelSetsOnBoard(phrasebuilder.ToString());
                        phrasebuilder.Clear();
                        return true;
                    }
                }
            }
            return false;
        }

        private void ShowReadyLabelSetsOnBoard(string word)
        {
            List<Label> labelSets = new List<Label>();

            var dragablelabel = CreateDragLabel(word);
            pnl_word_output.Controls.Add(dragablelabel);
            labelSets.Add(dragablelabel);

            var dragtolabel = LabelMaker.DragToLabel(dragablelabel.Text, _fontsize);
            pnl_content.Controls.Add(dragtolabel);
            labelSets.Add(dragtolabel);

            LabelsList.Add(labelSets);
        }

        private void ShowReadyRegularLabelOnBoard(string word)
        {
            var regularLabel = LabelMaker.RegularLabel(word, _fontsize);
            pnl_content.Controls.Add(regularLabel);
        }

        private void ResetPhraseBuilder()
        {
            phrasebuilder.Clear();
            _isphrase = false;
        }

        private void ValidateAnswers()
        {
            var correct = 0;

            foreach (List<Label> labels in LabelsList)
            {
                var border = labels[1].Bounds;
                border.Offset(pnl_content.Location);

                if (border.IntersectsWith(labels[0].Bounds))
                {
                    correct++;
                    labels[1].ForeColor = Color.Green;
                }
                else
                {
                    labels[1].ForeColor = Color.Red;
                }
            }

            LblScore.Text = correct.ToString();
            PnlResults.Visible = true;
        }

        private void UpdateTextSize()
        {
            _fontsize = Settings.GetFontSize();
        }

        private void ClearLabelsAndRemoveFromBoard()
        {
            foreach (List<Label> labels in LabelsList)
            {
                labels[0].Dispose();
                labels[1].Dispose();
            }

            pnl_content.Controls.Clear();
            InputText.Clear();
            PnlResults.Visible = false;
            pnl_word_output.ResumeLayout();
        }

        private DraggableLabel CreateDragLabel(string labeltext)
        {
            DraggableLabel newDragLabel = LabelMaker.DraggableLabel(labeltext, _fontsize);
            return newDragLabel;
        }

        public void UserRequestCurrentMark()
        {
            if (LabelsList.Count != 0)
            {
                ValidateAnswers();
                btn_clear.Visible = true;
            }
            else
            {
                MessageBox.Show(@"You have to open a resource first!", @"Not Ready!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void UpdateHandPositions()
        {
            img_Hand.BringToFront();
            var handposition = new Point((int)KinectSettings.movement.HandX, (int)KinectSettings.movement.HandY);
            img_Hand.Visible = true;
            img_Hand.Location = handposition;
           
            img_Hand.Image = Movement.Dragging ? Properties.Resources.hand_grab : Properties.Resources.hand_default;
        }

        private void ResetBoard()
        {
            ClearLabelsAndRemoveFromBoard();
            OpenGivenResource(currentResource);
            btn_clear.Visible = false;
        }

        private void tmr_UpdateHandPositions_Tick(object sender, EventArgs e)
        {
            UpdateHandPositions();
        }

        private void btn_library_Click(object sender, EventArgs e)
        {
            var frmLibrary = new FrmLibrary();
            frmLibrary.Show();
            CloseMenu();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            var frmConfig = new FrmConfig();
            frmConfig.Show();
            CloseMenu();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            var frmInfo = new FrmInfo();
            frmInfo.Show();
            CloseMenu();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            UserRequestCurrentMark();
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            KinectSettings.movement.ViewHeight = Height + Location.Y;
            KinectSettings.movement.ViewWidth = Width + Location.X;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }
    }
}