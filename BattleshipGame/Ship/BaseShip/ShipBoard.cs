namespace BattleshipGame.Ship
{
    /// <summary>
    /// Calculate the dimensions of the ship on a board based on it's orientation
    /// </summary>
    internal class ShipBoard
    {
        public static int GetHeightOnBoard(IShipObject ship, Orientation orientation)
        {
            return (orientation == Orientation.Horizontal) ? ship.Width : ship.Length;
        }

        public static int GetWidthOnBoard(IShipObject ship, Orientation orientation)
        {
            return (orientation == Orientation.Horizontal) ? ship.Length : ship.Width;
        }
        public static Position GetShipEndPosition(IShipObject ship, Position startPosition, Orientation orientation)
        {
            int positionRow = startPosition.RowIndex;
            int positionColumn = startPosition.ColumnIndex;
            int shipEndRow = positionRow + ShipBoard.GetHeightOnBoard(ship, orientation) - 1;
            int shipEndColumn = positionColumn + ShipBoard.GetWidthOnBoard(ship, orientation) - 1;
            return new Position(shipEndRow, shipEndColumn);
        }
    }
}
