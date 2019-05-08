using BattleshipGame.Board;
using NUnit.Framework;

namespace BattleshipGame.NTests
{
    [TestFixture]
    public class BattleshipGame_ArrayBoard
    {
        #region SetUp / TearDown
        private int _shipLength;

        private int _boardHeight;
        private int _boardWidth;
        private IBoard _board;

        private Position _shipPosition;
        private Position _nonShipPosition;
        private readonly Position A1 = new Position(0, 0);
        private readonly Position K11 = new Position(10, 10);

        private void SetupEmptyBoard()
        {
            _boardHeight = 10;
            _boardWidth = 10;
            _board = ArrayBoard.Create(_boardHeight, _boardWidth);
        }
        private void TearDownEmptyBoard()
        {
            _boardHeight = 0;
            _boardWidth = 0;
            _board = null;
        }
        private void SetupBoardWithShip()
        {
            _shipLength = 1;

            SetupEmptyBoard();

            _shipPosition = new Position("A", 1);
            _nonShipPosition = new Position("B", 2);
            _board.PositionBattleship(_shipLength, _shipPosition.RowId, _shipPosition.ColumnId, Orientation.Horizontal);
        }
        private void TearDownBoardWithShip()
        {
            _nonShipPosition = K11;
            _shipPosition = K11;

            TearDownEmptyBoard();

            _shipLength = 0;
        }
        #endregion

        //#region Unit Test - Get location
        //[Test]
        //public void GetLocationOnBoard()
        //{
        //    SetupBoardWithShip();
        //    Position onBoard = A1;
        //    TestDelegate test = () => _board.GetLocation(onBoard);
        //    Assert.DoesNotThrow(test);
        //    TearDownBoardWithShip();
        //}

        //[Test]
        //public void GetLocationOffBoard()
        //{
        //    SetupEmptyBoard();
        //    Position offBoard = K11;
        //    TestDelegate test = () => _board.GetLocation(offBoard);
        //    Assert.Throws<LocationOffBoardException>(test);
        //    TearDownEmptyBoard();
        //}
        //#endregion

        #region Unit Tests - Ship placement 
        [Test]
        public void PlaceShipOffBoard()
        {
            SetupEmptyBoard();
            int shipLength = _boardWidth;
            TestDelegate test = () =>_board.PositionBattleship(shipLength, K11.RowId, K11.ColumnId, Orientation.Horizontal);
            Assert.Throws<ShipPlacedOffBoardException>(test);
            TearDownEmptyBoard();
        }

        [Test]
        public void PlaceShipOnBoard()
        {
            SetupEmptyBoard();
            int shipLength = 1;
            TestDelegate test = () => _board.PositionBattleship(shipLength, A1.RowId, A1.ColumnId, Orientation.Horizontal);
            Assert.DoesNotThrow(test);
            TearDownEmptyBoard();
        }
        #endregion

        #region Unit Tests - Attacks
        [Test]
        public void AttackShip()
        {
            SetupBoardWithShip();
            AttackResult result = _board.AttackPosition(_shipPosition.RowId, _shipPosition.ColumnId);
            Assert.AreEqual(AttackResult.Hit, result);
            TearDownEmptyBoard();
        }

        [Test]
        public void AttackNothing()
        {
            SetupEmptyBoard();
            AttackResult result = _board.AttackPosition(_nonShipPosition.RowId, _nonShipPosition.ColumnId);
            Assert.AreEqual(AttackResult.Miss, result);
            TearDownEmptyBoard();
        }

        //[Test]
        //public void AttackShipTwice()
        //{
        //    TestDelegate test = () => _board.AttackTarget(_shipLocation);
        //    test.Invoke();
        //    Assert.Throws<LocationAlreadyAttackedException>(test);
        //}

        //[Test]
        //public void AttackNothingTwice()
        //{
        //    TestDelegate test = () => _board.AttackTarget(_nonShipLocation);
        //    test.Invoke();
        //    Assert.Throws<LocationAlreadyAttackedException>(test);
        //}
        #endregion

        #region Unit Tests - Game over
        [Test]
        public void EmptyBoardIsGameOver()
        {
            SetupEmptyBoard();
            Assert.IsTrue(_board.IsGameOver(), "Game is NOT over as there are unsunken ships on the board.");
            TearDownEmptyBoard();
        }

        [Test]
        public void UnsunkShipIsNotGameOver()
        {
            SetupBoardWithShip();
            Assert.IsFalse(_board.IsGameOver(), "Game is OVER as there are no unsunken ships on the board.");
            TearDownBoardWithShip();
        }

        [Test]
        public void SunkShipIsGameOver()
        {
            SetupBoardWithShip();
            _board.AttackPosition(_shipPosition.RowId, _shipPosition.ColumnId);
            Assert.IsTrue(_board.IsGameOver(), "Game is NOT over as there are unsunken ships on the board.");
            TearDownBoardWithShip();
        }
        #endregion
    }
}