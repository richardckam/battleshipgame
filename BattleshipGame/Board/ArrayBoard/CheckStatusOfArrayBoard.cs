using BattleshipGame.Location;

namespace BattleshipGame.Board
{
    /// <summary>
    /// Check the completion status of a board
    /// </summary>
    internal class CheckStatusOfArrayBoard
    {
        public static bool IsGameOver(IArrayBoardObject board)
        {
            bool hasUnsunkenShip = false;
            foreach (ILocation loc in board.Locations)
            {
                if (loc.IsOccupied() && loc.GetStatus() != AttackStatus.Hit)
                {
                    hasUnsunkenShip = true;
                    break;
                }
            }
            return !hasUnsunkenShip; //if all battleships have been sunk, the game is over
        }
    }
}