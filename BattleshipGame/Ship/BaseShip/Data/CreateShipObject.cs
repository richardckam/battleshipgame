namespace BattleshipGame.Ship
{
    /// <summary>
    /// Create Data Object that represent a ship
    /// </summary>
    internal class CreateShipObject
    {
        public static IShipObject Create(int length, int width)
        {
            // the length and width must be greater than zero
            if (length < 1 || width < 1)
            {
                throw new ShipSizeException(string.Format("Length and Width of a ship must both be greater than zero, not ({0}, {1}).", length, width));
            }
            else
            {
                return new ShipObject(length, width);
            }
        }
    }
}
