using BattleshipGame.Ship;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipGame.Location
{
    /// <summary>
    /// Data Object representing a Basic Location
    /// </summary>
    internal class BasicLocationObject : IBasicLocationObject
    {
        #region Private Variables
        private Position _position;
        private AttackStatus _status;
        private IShip _occupant;
        #endregion

        #region IBasicLocationObject Implementation - Properties
        Position IBasicLocationObject.Position { get { return _position; } }
        AttackStatus IBasicLocationObject.Status { get { return _status; } set { _status = value; } }
        IShip IBasicLocationObject.Occupant { get { return _occupant; } set { _occupant = value; } }
        bool IBasicLocationObject.IsOccupied { get { return (_occupant != null); } }
        string IBasicLocationObject.PositionId { get { return _position.Id; } }
        #endregion

        #region Public Constructors
        public BasicLocationObject(Position position)
        {
            _position = position;
            _status = AttackStatus.NotAttacked;
            _occupant = null;
        }
        #endregion
    }
}
