using System;
using System.Windows.Forms;

namespace Chess
{
    public partial class GameForm : Form
    {
        public GameForm(ProjectEnums.GameType gameType)
        {
            InitializeComponent();
            GameSession.NewGame(gameType);
            Board.Init(this);
        }
        
        //on window close exit the application
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            //TODO: save game
            Application.Exit();
        }
    }
}