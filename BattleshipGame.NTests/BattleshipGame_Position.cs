using NUnit.Framework;

namespace BattleshipGame.NTests
{
    [TestFixture]
    public class BattleshipGame_Position
    {
        #region SetUp / TearDown
        private Position _position;

        [SetUp]
        public void Setup()
        {
            _position = new Position("A", 1);
        }
        [TearDown]
        public void TearDown()
        {
        }
        #endregion

        #region Unit Tests
        [Test]
        public void TestGetRow()
        {
            Assert.AreEqual("A", _position.RowId);
        }

        [Test]
        public void TestGetColumn()
        {
            Assert.AreEqual(1, _position.ColumnId);
        }

        [Test]
        public void TestId()
        {
            Assert.AreEqual("A1", _position.Id);
        }
        #endregion
    }
}
