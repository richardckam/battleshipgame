using BattleshipGame.Ship;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipGame.Location
{
    interface IBasicLocationObject
    {
        /// <summary>
        /// Position of the location
        /// </summary>
        Position Position { get; }
        /// <summary>
        /// Attack Status of the location (Hit, Miss, or NotAttacked)
        /// </summary>
        AttackStatus Status { get; set; }
        /// <summary>
        /// Ship which is occupying this location
        /// </summary>
        IShip Occupant { get; set; }
        /// <summary>
        /// Is this location occupied? (True, or False)
        /// </summary>
        bool IsOccupied { get; }
        /// <summary>
        /// The Position ID (e.g. "A1") of the location
        /// </summary>
        string PositionId { get; }
   }
}
