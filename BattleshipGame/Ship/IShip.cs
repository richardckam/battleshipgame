using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BattleshipGame.NTests")]
namespace BattleshipGame.Ship
{
    internal interface IShip
    {
        /// <summary>
        /// Get the length of the ship
        /// </summary>
        /// <returns>Length of the ship</returns>
        int GetLength();
        /// <summary>
        /// Get the width of the ship
        /// </summary>
        /// <returns>Width of the ship</returns>
        int GetWidth();
        /// <summary>
        /// The number of rows the ship will span across a board
        /// </summary>
        /// <param name="orientation">The orientation of the ship on the board (Horizontal, or Vertical)</param>
        /// <returns>The height of the ship on the board</returns>
        int GetHeightOnBoard(Orientation orientation);
        /// <summary>
        /// The number of columns the ship will span across a board
        /// </summary>
        /// <param name="orientation">The orientation of the ship on the board (Horizontal, or Vertical)</param>
        /// <returns>The width of the ship on the board</returns>
        int GetWidthOnBoard(Orientation orientation);
        /// <summary>
        /// Calculate the end position of the ship on the board
        /// </summary>
        /// <param name="startPosition">The start position of the ship, as it appears on the board</param>
        /// <param name="orientation">The orientation of the ship on the board (Horizontal, or Vertical)</param>
        /// <returns>The end position of the ship, as it appears on the board</returns>
        Position CalculateEndPosition(Position startPosition, Orientation orientation);
    }
}