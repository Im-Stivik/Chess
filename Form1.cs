using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        //if the user clicks the local game button
        private void LocalGameBtn_Click(object sender, EventArgs e)
        {
            //create a new game
            GameForm game = new GameForm(ProjectEnums.GameType.Local);
            //show the game
            game.Show();
            //closes this form but not the application
            this.Hide();
        }

        private void LoadSettings()
        {
            Exception readingException = FileMennager.LoadSettings();
            if(readingException != null)
            {
                if (readingException.GetType() == typeof(FileNotFoundException))
                {
                    Console.WriteLine("Settings file not found, creating new one");
                    FileMennager.SaveSettings();
                    return;
                }
                MessageBox.Show(readingException.Message);
            }
        }
        
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Settings button clicked");
            SettingsEditForm settings = new SettingsEditForm();
            settings.Show();
        }
    }



}
