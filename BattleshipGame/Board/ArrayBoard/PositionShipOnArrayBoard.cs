using BattleshipGame.Location;
using BattleshipGame.Ship;
using System.Collections.Generic;
using System.Linq;

namespace BattleshipGame.Board
{
    /// <summary>
    /// Positions a ship on a board
    /// </summary>
    internal class PositionShipOnArrayBoard
    {
        public static void PositionShip(IArrayBoardObject board, IShip battleship, Position battleshipPosition, Orientation battleshipOrientation)
        {
            // collate positional information
            Position shipEndPosition = battleship.CalculateEndPosition(battleshipPosition, battleshipOrientation);

            // traverse in reverse order, to immediately throw an exception if the ship is not entirely on the board
            List<ILocation> shipLocations = new List<ILocation>();
            List<ILocation> occupiedLocations = new List<ILocation>();
            try
            {
                for (int r = shipEndPosition.RowIndex; r >= battleshipPosition.RowIndex; r--)
                {
                    for (int c = shipEndPosition.ColumnIndex; c >= battleshipPosition.ColumnIndex; c--)
                    {
                        ILocation foundLocation = GetLocationOnArrayBoard.GetLocation(board, new Position(r, c));
                        shipLocations.Add(foundLocation);
                        if (foundLocation.IsOccupied())
                        {
                            occupiedLocations.Add(foundLocation);
                        }
                    }
                }
            }
            catch (LocationOffBoardException ex)
            {
                throw new ShipPlacedOffBoardException("Ship is not entirely on the board.", ex);
            }

            // if any of the Locations are already occupied, we cannot place the ship on the board
            if (occupiedLocations.Count > 0)
            {
                ThrowOverlappingShipException(occupiedLocations);
            }

            // occupy each of the Locations where the ship belongs
            foreach (ILocation locations in shipLocations)
            {
                locations.Occupy(battleship);
            }
        }

        private static void ThrowOverlappingShipException(List<ILocation> overlappingLocations)
        {
            IEnumerable<string> listOfPositions = overlappingLocations.Select(loc => loc.GetPositionId());
            string listOfLocations = listOfPositions.Aggregate((x, y) => x + ", " + y);
            throw new OverlappingShipsException(string.Format("The following locations on the board are already occupied: {0}", listOfLocations));
        }
    }
}
