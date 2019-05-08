using System;

namespace BattleshipGame.Location
{
    /// <summary>
    /// Location cannot be occupied by multiple ships
    /// </summary>
    [Serializable]
    internal class LocationOccupiedException : Exception
    {
        public LocationOccupiedException() { }
        public LocationOccupiedException(string message) : base(message) { }
        public LocationOccupiedException(string message, System.Exception inner) : base(message, inner) { }
        protected LocationOccupiedException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// Location cannot be attacked multiple times
    /// </summary>
    [Serializable]
    internal class LocationAlreadyAttackedException : Exception
    {
        public LocationAlreadyAttackedException() { }
        public LocationAlreadyAttackedException(string message) : base(message) { }
        public LocationAlreadyAttackedException(string message, System.Exception inner) : base(message, inner) { }
        protected LocationAlreadyAttackedException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
