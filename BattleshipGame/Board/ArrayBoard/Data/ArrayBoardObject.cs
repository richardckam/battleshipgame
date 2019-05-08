using BattleshipGame.Location;
using System.Collections.Generic;
using System.Linq;

namespace BattleshipGame.Board
{
    /// <summary>
    /// Data object (which uses an array) representing a board 
    /// </summary>
    internal class ArrayBoardObject : IArrayBoardObject
    {
        #region Private Variables
        private ILocation[,] board;
        #endregion

        #region Public Constructor
        public ArrayBoardObject(int height, int width)
        {
            board = new ILocation[height, width];
        }
        #endregion

        #region IArrayBoardObject Impementation - Properties
        int IArrayBoardObject.Height { get { return board.GetLength(0); } }
        int IArrayBoardObject.Width { get { return board.GetLength(1); } }
        IEnumerable<ILocation> IArrayBoardObject.Locations { get { return board.Cast<ILocation>(); } }
        #endregion

        #region IArrayBoardObject Impementation - Methods
        ILocation IArrayBoardObject.GetLocation(int rowIndex, int colIndex)
        {
            return board[rowIndex, colIndex];
        }

        void IArrayBoardObject.SetLocation(ILocation location, int rowIndex, int colIndex)
        {
            board[rowIndex, colIndex] = location;
        }
        #endregion
    }
}
