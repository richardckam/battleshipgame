using BattleshipGame.Board;

namespace BattleshipGame.Game
{
    public interface IGame
    {
        /// <summary>
        /// Create a board
        /// </summary>
        /// <returns>An IBoard object</returns>
        IBoard CreateBoard();
        /// <summary>
        /// Position a Battleship on the game board
        /// </summary>
        /// <param name="board">Board on which the ship is to be placed</param>
        /// <param name="battleshipLength">The length of the Battleship</param>
        /// <param name="battleshipRow">The row where the Battleship is to be positioned (char-based index, starting from A)</param>
        /// <param name="battleshipColumn">The column where the Battleship is to be positioned (integer-based index, starting from 1)</param>
        /// <param name="battleshipOrientation">The direction which the Battleship will be oriented (Horizontal, or Vertical)</param>
        void PositionBattleship(IBoard board, int battleshipLength, string battleshipRow, int battleshipColumn, Orientation battleshipOrientation);
        /// <summary>
        /// Attack a position on the board
        /// </summary>
        /// <param name="board">Board which is to be attacked</param>
        /// <param name="attackRow">The row where the attack will take place (char-based index, starting from A)</param>
        /// <param name="attackColumn">The column where the attack will take place (integer-based index, starting from 1)</param>
        /// <returns>The result of the attack (Hit, or Miss)</returns>
        AttackResult AttackPosition(IBoard board, string attackRow, int attackColumn);
        /// <summary>
        /// Check if the board is completed
        /// </summary>
        /// <param name="board">Board which is being checked</param>
        /// <returns>Is the game over? (true, or false)</returns>
        bool IsGameOver(IBoard board);
    }
}
