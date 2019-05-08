namespace BattleshipGame.Ship
{
    /// <summary>
    /// Concrete implementation of ShipBase abstract class
    /// </summary>
    internal class LongShip : ShipBase
    {
        #region Private Constructors
        private LongShip(int length) : base(length, 1) { }
        #endregion

        #region Public Methods
        public static IShip CreateShip(int length)
        {
            return new LongShip(length);
        }
        #endregion

    }

}
