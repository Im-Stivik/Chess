using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace Chess
{
    public class GameSession
    {
        public static ProjectEnums.Team playerTeam = ProjectEnums.Team.WhiteTeam;
        public static Stack<ICommand> movesDone = new Stack<ICommand>();
        
        public static ProjectEnums.Team currentTurn = ProjectEnums.Team.WhiteTeam;
        public static ProjectEnums.GameType gameType = ProjectEnums.GameType.Local;

        public static void NewGame(ProjectEnums.GameType gameType)
        {
            GameSession.gameType = gameType;
            GameSession.currentTurn = ProjectEnums.Team.WhiteTeam;
            GameSession.movesDone.Clear();
            GameSession.playerTeam = ProjectEnums.Team.WhiteTeam;
        }
        
        public static void ExecuteCommand(ICommand command)
        {
            movesDone.Push(command);
            command.Execute();
            Board.ClearOptions();
            Board.UpdateMoves();
            ChangeTurn();
        }

        public static void CancleLastCommand()
        {
            ICommand command = movesDone.Pop();
            command.Cancle();
        }
        
        public static bool IsPlayerTurn()
        {
            return currentTurn == playerTeam;
        }
        
        public static void ChangeTurn()
        {
            currentTurn = currentTurn == ProjectEnums.Team.WhiteTeam ? ProjectEnums.Team.BlackTeam : ProjectEnums.Team.WhiteTeam;
            Board.FilterMovesForTeam(currentTurn);
            if (Board.CheckForCheck(currentTurn))
            {
                Console.WriteLine("Check!");
                if (Board.CheckForCheckMate(currentTurn))
                {
                    Mate();
                    return;
                }
            }
        }

        public static void Mate()
        {
            //TODO: implement mate
            Console.WriteLine("Mate!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }
}