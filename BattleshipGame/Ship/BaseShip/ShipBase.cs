namespace BattleshipGame.Ship
{
    /// <summary>
    /// Abstract implementation of the IShip interface
    /// </summary>
    internal abstract class ShipBase : IShip
    {
        #region Private Variables
        IShipObject _ship;
        #endregion

        #region Public Constructors
        public ShipBase(int length, int width)
        {
            _ship = CreateShipObject.Create(length, width);
        }
        #endregion

        #region IShip Implementation
        int IShip.GetLength()
        {
            return _ship.Length;
        }
        int IShip.GetWidth()
        {
            return _ship.Width;
        }

        int IShip.GetHeightOnBoard(Orientation orientation)
        {
            return this.GetHeightOnBoard(orientation);
        }

        int IShip.GetWidthOnBoard(Orientation orientation)
        {
            return this.GetWidthOnBoard(orientation);
        }

        Position IShip.CalculateEndPosition(Position startPosition, Orientation orientation)
        {
            return ShipBoard.GetShipEndPosition(_ship, startPosition, orientation);
        }
        #endregion

        #region Public Methods
        public int GetHeightOnBoard(Orientation orientation)
        {
            return ShipBoard.GetHeightOnBoard(_ship, orientation);
        }

        public int GetWidthOnBoard(Orientation orientation)
        {
            return ShipBoard.GetWidthOnBoard(_ship, orientation);
        }
        #endregion
    }
}
