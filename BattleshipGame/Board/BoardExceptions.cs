using System;

namespace BattleshipGame.Board
{
    /// <summary>
    /// Invalid value of the height and/or width of the board
    /// </summary>
    [Serializable]
    public class BoardSizeException : Exception
    {
        public BoardSizeException() { }
        public BoardSizeException(string message) : base(message) { }
        public BoardSizeException(string message, System.Exception inner) : base(message, inner) { }
        protected BoardSizeException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// Accessing location which does not exist on the board
    /// </summary>
    [Serializable]
    public class LocationOffBoardException : Exception
    {
        public LocationOffBoardException() { }
        public LocationOffBoardException(string message) : base(message) { }
        public LocationOffBoardException(string message, System.Exception inner) : base(message, inner) { }
        protected LocationOffBoardException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// Placing a ship which will not fit on the board
    /// </summary>
    [Serializable]
    public class ShipPlacedOffBoardException : Exception
    {
        public ShipPlacedOffBoardException() { }
        public ShipPlacedOffBoardException(string message) : base(message) { }
        public ShipPlacedOffBoardException(string message, System.Exception inner) : base(message, inner) { }
        protected ShipPlacedOffBoardException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// Placing a ship on the board which will overlap an already-placed ship
    /// </summary>
    [Serializable]
    public class OverlappingShipsException : Exception
    {
        public OverlappingShipsException() { }
        public OverlappingShipsException(string message) : base(message) { }
        public OverlappingShipsException(string message, System.Exception inner) : base(message, inner) { }
        protected OverlappingShipsException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// Attempt to attack a position on the board which has already been attacked
    /// </summary>
    [Serializable]
    public class PositionAlreadyAttackedException : Exception
    {
        public PositionAlreadyAttackedException() { }
        public PositionAlreadyAttackedException(string message) : base(message) { }
        public PositionAlreadyAttackedException(string message, System.Exception inner) : base(message, inner) { }
        protected PositionAlreadyAttackedException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
