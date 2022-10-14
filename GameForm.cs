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
    }
}