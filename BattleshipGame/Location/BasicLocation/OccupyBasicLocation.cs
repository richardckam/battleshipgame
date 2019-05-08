using BattleshipGame.Ship;

namespace BattleshipGame.Location
{
    /// <summary>
    /// Occupy a Basic Location with a ship
    /// </summary>
    internal class OccupyBasicLocation
    {
        public static void PlaceShip(IBasicLocationObject location, IShip ship)
        {
            if (location.IsOccupied)
            {
                throw new LocationOccupiedException(string.Format("Location {0} is already occupied.", location.PositionId));
            }
            else
            {
                location.Occupant = ship;
            }
        }
    }
}
    