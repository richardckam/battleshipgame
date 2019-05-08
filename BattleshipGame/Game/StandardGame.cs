using BattleshipGame.Board;

namespace BattleshipGame.Game
{
    /// <summary>
    /// Implements a Game, using a standard (10x10) board
    /// </summary>
    public class StandardGame : IGame
    {
        #region IGame Implementation
        IBoard IGame.CreateBoard()
        {
            int defaultBoardHeight = 10;
            int defaultBoardWidth = 10;
            return ArrayBoard.Create(defaultBoardHeight, defaultBoardWidth);
        }

        AttackResult IGame.AttackPosition(IBoard board, string attackRow, int attackColumn)
        {
            return board.AttackPosition(attackRow, attackColumn);
        }

        void IGame.PositionBattleship(IBoard board, int battleshipLength, string battleshipRow, int battleshipColumn, Orientation battleshipOrientation)
        {
            board.PositionBattleship(battleshipLength, battleshipRow, battleshipColumn, battleshipOrientation);
        }

        bool IGame.IsGameOver(IBoard board)
        {
            return board.IsGameOver();
        }
        #endregion
    }
}
