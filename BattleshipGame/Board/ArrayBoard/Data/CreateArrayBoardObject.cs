using BattleshipGame.Location;

namespace BattleshipGame.Board
{
    /// <summary>
    /// Creates data object (which uses an array) representing a board
    /// </summary>
    internal class CreateArrayBoardObject
    {
        public static IArrayBoardObject Create(int height, int width)
        {
            if (height < 1 || width < 1)
            {
                throw new BoardSizeException(string.Format("Height and Width of the board must both be greater than zero, not ({0}, {1}).", height, width));
            }

            // populate Board with Location objects
            ArrayBoardObject board = new ArrayBoardObject(height, width);
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    CreateLocation(board, row, col);
                }
            }
            return board;
        }

        private static void CreateLocation(IArrayBoardObject board, int row, int col)
        {
            Position position = new Position(row, col);
            ILocation location = BasicLocation.CreateLocation(position);
            board.SetLocation(location, row, col);
        }
    }
}
