using BattleshipGame.Ship;

namespace BattleshipGame.Board
{
    /// <summary>
    /// Implementation (which uses an array) of the IBoard interface
    /// </summary>
    public class ArrayBoard : IBoard
    {
        #region Private Variables
        private IArrayBoardObject _board;
        #endregion

        #region Private Constructors
        private ArrayBoard(int height, int width)
        {
            _board = CreateArrayBoardObject.Create(height, width);
        }
        #endregion

        #region Public Static constructor
        public static IBoard Create(int height, int width)
        {
            return new ArrayBoard(height, width);
        }
        #endregion

        #region IBoard Implementation
        void IBoard.PositionBattleship(int battleshipLength, string battleshipRow, int battleshipColumn, Orientation battleshipOrientation)
        {
            //this.PositionBattleship(LongShip.CreateShip(battleshipLength), new Position(battleshipRow, battleshipColumn), battleshipOrientation);
            PositionShipOnArrayBoard.PositionShip(_board, LongShip.CreateShip(battleshipLength), new Position(battleshipRow, battleshipColumn), battleshipOrientation);
        }

        AttackResult IBoard.AttackPosition(string attackRow, int attackColumn)
        {
            //return this.AttackPosition(new Position(attackRow, attackColumn));
            return AttackPositionOnArrayBoard.Attack(_board, new Position(attackRow, attackColumn));
        }

        bool IBoard.IsGameOver()
        {
            return CheckStatusOfArrayBoard.IsGameOver(_board);
        }
        #endregion

        #region Internal methods
        //TODO : tidy
        //internal void PositionBattleship(IShip ship, Position battleshipLocation, Orientation battleshipOrientation)
        //{
        //    PositionShipOnArrayBoard.PositionShip(_board, ship, battleshipLocation, battleshipOrientation);
        //}

        //internal AttackResult AttackPosition(Position attackLocation)
        //{
        //    return AttackPositionOnArrayBoard.Attack(_board, attackLocation);
        //}
        #endregion
    }

}