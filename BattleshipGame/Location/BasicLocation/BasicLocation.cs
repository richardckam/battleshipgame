using BattleshipGame.Ship;

namespace BattleshipGame.Location
{
    /// <summary>
    /// Implementation of the ILocation interface
    /// </summary>
    internal class BasicLocation : ILocation
    {
        #region Private Variables
        private IBasicLocationObject _location;
        #endregion

        #region Private Constructors
        private BasicLocation(Position position) {
            _location = new BasicLocationObject(position);
        }
        #endregion

        #region Public Static constructors
        public static ILocation CreateLocation(Position position)
        {
            return new BasicLocation(position);
        }
        #endregion

        #region ILocation implementation
        void ILocation.Occupy(IShip ship)
        {
            OccupyBasicLocation.PlaceShip(_location, ship);
        }

        AttackStatus ILocation.GetStatus()
        {
            return _location.Status;
        }

        bool ILocation.IsOccupied()
        {
            return _location.IsOccupied;
        }

        AttackResult ILocation.Attack()
        {
            return AttackBasicLocation.Attack(_location);
        }

        string ILocation.GetPositionId()
        {
            return _location.PositionId;
        }
        #endregion
    }
}