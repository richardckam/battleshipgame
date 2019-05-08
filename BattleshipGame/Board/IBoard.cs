namespace BattleshipGame.Board
{
    public interface IBoard
    {
        /// <summary>
        /// Position a Battleship on the game board
        /// </summary>
        /// <param name="battleshipLength">The length of the Battleship</param>
        /// <param name="battleshipRow">The row where the Battleship is to be positioned (char-based index, starting from A)</param>
        /// <param name="battleshipColumn">The column where the Battleship is to be positioned (integer-based index, starting from 1)</param>
        /// <param name="battleshipOrientation">The direction which the Battleship will be oriented (Horizontal, or Vertical)</param>
        void PositionBattleship(int battleshipLength, string battleshipRow, int battleshipColumn, Orientation battleshipOrientation);
        /// <summary>
        /// Attack a position on the board
        /// </summary>
        /// <param name="attackRow">The row where the attack will take place (char-based index, starting from A)</param>
        /// <param name="attackColumn">The column where the attack will take place (integer-based index, starting from 1)</param>
        /// <returns>The result of the attack (Hit, or Miss)</returns>
        AttackResult AttackPosition(string attackRow, int attackColumn);
        /// <summary>
        /// Check if the board is completed
        /// </summary>
        /// <returns>Is the game over? (true, or false)</returns>
        bool IsGameOver();
    }
}