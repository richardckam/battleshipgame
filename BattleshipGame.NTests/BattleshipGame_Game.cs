using BattleshipGame.Board;
using BattleshipGame.Game;
using NUnit.Framework;

namespace BattleshipGame.NTests
{
    [TestFixture]
    public class BattleshipGame_Game
    {
        #region SetUp / TearDown
        private IGame _game;

        private void SetupGame()
        {
            _game = new StandardGame();
        }
        private void TearDownGame()
        {
            _game = null;
        }
        #endregion

        #region Unit Tests - Ship placement 
        [Test]
        public void CreateBoard()
        {
            SetupGame();
            IBoard board = _game.CreateBoard();
            Assert.IsTrue(board != null);
            TearDownGame();
        }
       #endregion
    }
}