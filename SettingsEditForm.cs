using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chess
{
    public partial class SettingsEditForm : Form
    {
        public SettingsEditForm()
        {
            InitializeComponent();
            LoadSettings();
        }
        
        
        
        private void IgnoreNotNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void PickColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() != DialogResult.OK) return;
            Color color = colorDialog.Color;
            Control control = (Control)sender;
            control.BackColor = color;
        }
        
        private void LoadSettings()
        {
            PiesSizeTextBox.Text = GameSettings.PieceSize.ToString();
            MarginToTopTextBox.Text = GameSettings.BoardMarginTop.ToString();
            MarginToLeftTextBox.Text = GameSettings.BoardMarginLeft.ToString();
            WhiteCellColorBtn.BackColor = GameSettings.LightColor;
            BlackCellColorBtn.BackColor = GameSettings.DarkColor;
            MoveOptionColorBtn.BackColor = GameSettings.OptionsColor;
            EatOptionColorBtn.BackColor = GameSettings.EatPiesOptionColor;
            HighlightedCellColorBtn.BackColor = GameSettings.SelectedColor;
            ForwardMarginLeftTextBox.Text = GameSettings.ForwardButtonMarginLeft.ToString();
            ForwardMarginTopTextBox.Text = GameSettings.ForwardButtonMarginTop.ToString();
            ForwardWidthTextBox.Text = GameSettings.ForwardButtonWidth.ToString();
            ForwardHeightTextBox.Text = GameSettings.ForwardButtonHeight.ToString();
            BackMarginLeftTextBox.Text = GameSettings.BackButtonMarginLeft.ToString();
            BackMarginTopTextBox.Text = GameSettings.BackButtonMarginTop.ToString();
            BackWidthTextBox.Text = GameSettings.BackButtonWidth.ToString();
            BackHeightTextBox.Text = GameSettings.BackButtonHeight.ToString();
        }
        
        private void ApplySettings()
        {
            GameSettings.PieceSize = int.Parse(PiesSizeTextBox.Text);
            GameSettings.BoardMarginTop = int.Parse(MarginToTopTextBox.Text);
            GameSettings.BoardMarginLeft = int.Parse(MarginToLeftTextBox.Text);
            GameSettings.LightColor = WhiteCellColorBtn.BackColor;
            GameSettings.DarkColor = BlackCellColorBtn.BackColor;
            GameSettings.OptionsColor = MoveOptionColorBtn.BackColor;
            GameSettings.EatPiesOptionColor = EatOptionColorBtn.BackColor;
            GameSettings.SelectedColor = HighlightedCellColorBtn.BackColor;
            GameSettings.ForwardButtonMarginLeft = int.Parse(ForwardMarginLeftTextBox.Text);
            GameSettings.ForwardButtonMarginTop = int.Parse(ForwardMarginTopTextBox.Text);
            GameSettings.ForwardButtonWidth = int.Parse(ForwardWidthTextBox.Text);
            GameSettings.ForwardButtonHeight = int.Parse(ForwardHeightTextBox.Text);
            GameSettings.BackButtonMarginLeft = int.Parse(BackMarginLeftTextBox.Text);
            GameSettings.BackButtonMarginTop = int.Parse(BackMarginTopTextBox.Text);
            GameSettings.BackButtonWidth = int.Parse(BackWidthTextBox.Text);
            GameSettings.BackButtonHeight = int.Parse(BackHeightTextBox.Text);
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ApplySettings();
            bool isSaved = FileMennager.SaveSettings();
            if (!isSaved)
            {
                MessageBox.Show("Error while saving settings");
            }
            Close();
        }
        
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            ApplySettings();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Chess settings file (*.settings)|*.settings";
            saveFileDialog.Title = "Export settings";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            if(saveFileDialog.FileName == "")
            {
                MessageBox.Show("File name is empty");
                return;
            }
            bool isSaved = FileMennager.SaveSettings(saveFileDialog.FileName);
            if (!isSaved)
            {
                MessageBox.Show("Error while saving settings");
            }
            MessageBox.Show("Settings exported");
            this.Close();
        }
        
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Chess settings file (*.settings)|*.settings";
            openFileDialog.Title = "Import settings";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            if (openFileDialog.FileName == "")
            {
                MessageBox.Show("File name is empty");
                return;
            }
            Exception exception = FileMennager.LoadSettings(openFileDialog.FileName);
            if (exception != null)
            {
                MessageBox.Show("Error while loading settings");
            }
            bool isSaved = FileMennager.SaveSettings();
            if(!isSaved)
            {
                MessageBox.Show("Error while saving settings");
            }
            MessageBox.Show("Settings imported");
            this.Close();
        }
    }
}