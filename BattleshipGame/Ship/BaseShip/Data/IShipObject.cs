using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipGame.Ship
{
    internal interface IShipObject
    {
        /// <summary>
        /// Length of the ship
        /// </summary>
        int Length { get; set; }
        /// <summary>
        /// Width of the ship
        /// </summary>
        int Width { get; set; }
    }
}
