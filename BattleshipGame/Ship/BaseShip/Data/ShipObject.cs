namespace BattleshipGame.Ship
{
    /// <summary>
    /// Data Object representing a ship
    /// </summary>
    internal class ShipObject : IShipObject
    {
        private int _length;
        private int _width;
        #region IShipObject Implementation - Properties
        int IShipObject.Length { get { return _length; } set { _length = value; } }
        int IShipObject.Width { get { return _width; } set { _width = value; } }
        #endregion

        #region Public Constructor
        public ShipObject(int length, int width)
        {
            _length = length;
            _width = width;
        }
        #endregion
    }
}
