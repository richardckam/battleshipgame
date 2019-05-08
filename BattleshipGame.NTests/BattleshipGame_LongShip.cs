using BattleshipGame.Ship;
using NUnit.Framework;

namespace BattleshipGame.NTests
{
    [TestFixture]
    public class BattleshipGame_LongShip
    {
        #region SetUp / TearDown
        private int _shipLength;
        private IShip _ship;
        [SetUp]
        public void Setup()
        {
            _shipLength = 1;
            _ship = LongShip.CreateShip(_shipLength);
        }
        [TearDown]
        public void TearDown()
        {
            _ship = null;
        }
        #endregion
        #region Unit Tests - Create ship
        [Test]
        public void CreateZeroLengthShip()
        {
            TestDelegate test = () => LongShip.CreateShip(0);
            Assert.Throws<ShipSizeException>(test);
        }

        [Test]
        public void CreateShip()
        {
            TestDelegate test = () => LongShip.CreateShip(_shipLength);
            Assert.DoesNotThrow(test);
        }
        #endregion

        #region Unit Tests - Get length/width
        [Test]
        public void GetLength()
        {
            Assert.AreEqual(_shipLength, _ship.GetLength());
        }

        [Test]
        public void GetWidth()
        {
            Assert.AreEqual(1, _ship.GetWidth());
        }
        #endregion
    }
}
