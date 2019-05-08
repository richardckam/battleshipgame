using BattleshipGame.Ship;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BattleshipGame.NTests")]
namespace BattleshipGame.Location
{
    internal interface ILocation
    {
        /// <summary>
        /// Place a ship on this Location
        /// </summary>
        /// <param name="ship">The ship to be placed on this location</param>
        void Occupy(IShip ship);
        /// <summary>
        /// Status showing whether this location has been attacked
        /// </summary>
        /// <returns>Has this location been attacked? (Hit, Miss, or NotAttacked)</returns>
        AttackStatus GetStatus();
        /// <summary>
        /// Check if the location is occupied
        /// </summary>
        /// <returns>Is the location occupied? (True, or False)</returns>
        bool IsOccupied();
        /// <summary>
        /// Attack this location
        /// </summary>
        /// <returns>The result of the attack (Hit, or Miss)</returns>
        AttackResult Attack();
        /// <summary>
        /// Get the ID of the Location
        /// </summary>
        /// <returns>The ID of the Location (e.g. "A1")</returns>
        string GetPositionId();
    }
}