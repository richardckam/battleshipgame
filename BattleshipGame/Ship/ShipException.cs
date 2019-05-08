using System;

namespace BattleshipGame.Ship
{
    /// <summary>
    /// Invalid value of the length and/or width of the ship
    /// </summary>
    [Serializable]
    internal class ShipSizeException : Exception
    {
        public ShipSizeException() { }
        public ShipSizeException(string message) : base(message) { }
        public ShipSizeException(string message, System.Exception inner) : base(message, inner) { }
        protected ShipSizeException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
