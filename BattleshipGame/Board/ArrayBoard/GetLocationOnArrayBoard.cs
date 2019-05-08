using BattleshipGame.Location;

namespace BattleshipGame.Board
{
    /// <summary>
    /// Gets a location on a board, given the position
    /// </summary>
    internal class GetLocationOnArrayBoard
    {
        public static ILocation GetLocation(IArrayBoardObject board, Position position)
        {
            int rowIndex = position.RowIndex;
            int colIndex = position.ColumnIndex;
            if (rowIndex < 0 || rowIndex >= board.Height || colIndex < 0 || colIndex >= board.Width)
            {
                throw new LocationOffBoardException(string.Format("Location {0} is not on a board of size ({1}, {2})", position.Id, board.Height, board.Width));
            }
            return board.GetLocation(rowIndex, colIndex);
        }
    }
}
