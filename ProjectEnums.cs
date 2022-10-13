namespace Chess
{
    public class ProjectEnums
    {
        public enum PieceType
        {
            Pawn,
            Rook,
            Knight,
            Bishop,
            Queen,
            King,
            Option,
            None,
        }

        public enum Team
        {
            WhiteTeam,
            BlackTeam
        }
        
        public enum SelectionState
        {
            Selected,
            NotSelected,
            SelectedByMove,
        }

        public enum GameType
        {
            Local,
            Lan,
            Online,
        }
        
        public static Team GetOppositeTeam(Team team)
        {
            if (team == Team.WhiteTeam)
                return Team.BlackTeam;
            else
                return Team.WhiteTeam;
        }
        
        public const int PLAYER = 0;
        public const int OPPONENT = 1;
    }
}