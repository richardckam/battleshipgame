using BattleshipGame.Location;
using System.Collections.Generic;

namespace BattleshipGame.Board
{
    internal interface IArrayBoardObject
    {
        /// <summary>
        /// Height of the board
        /// </summary>
        int Height { get; }
        /// <summary>
        /// Width of the board
        /// </summary>
        int Width { get; }
        /// <summary>
        /// Locations on the board
        /// </summary>
        IEnumerable<ILocation> Locations { get; }
        /// <summary>
        /// Get the Location object at the specified Position, based on a zero-based index (e.g. [0,0])
        /// </summary>
        /// <param name="rowIndex">Zero-based index of the row</param>
        /// <param name="colIndex">Zero-based index of the column</param>
        /// <returns></returns>
        ILocation GetLocation(int rowIndex, int colIndex);
        /// <summary>
        /// Set Location object at the specified position,  based on a zero-based index (e.g. [0,0])
        /// </summary>
        /// <param name="location">Location object</param>
        /// <param name="rowIndex">Zero-based index of the row</param>
        /// <param name="colIndex">Zero-based index of the column</param>
        void SetLocation(ILocation location, int rowIndex, int colIndex);
    }
}
