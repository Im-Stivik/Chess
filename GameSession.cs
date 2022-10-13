using System;
using System.Collections;
using System.Collections.Generic;
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
        }

        public static void MakeChess(ProjectEnums.Team team)
        {
            Console.WriteLine("Chess made by " + currentTurn);
            if (Board.CheckForCheckMate())
            {
                Console.WriteLine("Checkmate!");
            }
            else
            {
                Console.WriteLine("Not checkmate!");
            }
        }
    }
}