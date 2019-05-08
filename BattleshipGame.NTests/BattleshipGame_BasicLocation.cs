using BattleshipGame.Location;
using BattleshipGame.Ship;
using NUnit.Framework;

namespace BattleshipGame.NTests
{
    [TestFixture]
    public class BattleshipGame_BasicLocation
    {
        #region SetUp / TearDown
        private int _shipLength;
        private IShip _ship;

        private AttackStatus _defaultStatus;
        private Position _position;
        private ILocation _location;
        private void Setup()
        {
            _shipLength = 1;
            _ship = LongShip.CreateShip(_shipLength);

            _defaultStatus = AttackStatus.NotAttacked;
            _position = new Position("A", 1);
            _location = BasicLocation.CreateLocation(_position);
        }
        private void TearDown()
        {
            _location = null;
            _ship = null;
        }
        #endregion

        #region Unit Tests
        [Test]
        public void OccupyLocation()
        {
            Setup();
            TestDelegate test = () => _location.Occupy(_ship);
            Assert.DoesNotThrow(test);
            TearDown();
        }

        [Test]
        public void OccupyLocationTwice()
        {
            Setup();
            IShip ship = LongShip.CreateShip(_shipLength);
            _location.Occupy(ship);
            TestDelegate test = () => _location.Occupy(_ship);
            Assert.Throws<LocationOccupiedException>(test);
            TearDown();
        }

        [Test]
        public void CheckStatus()
        {
            Setup();
            Assert.AreEqual(_defaultStatus, _location.GetStatus());
            TearDown();
        }

        [Test]
        public void AttackEmptyLocation()
        {
            Setup();
            AttackResult result = _location.Attack();
            Assert.AreEqual(AttackResult.Miss, result);
            TearDown();
        }

        [Test]
        public void AttackEmptyLocationTwice()
        {
            Setup();
            TestDelegate test = () => _location.Attack();
            test.Invoke();
            Assert.Throws<LocationAlreadyAttackedException>(test);
            TearDown();
        }

        [Test]
        public void AttackOccupiedLocation()
        {
            Setup();
            _location.Occupy(_ship);
            AttackResult result = _location.Attack();
            Assert.AreEqual(AttackResult.Hit, result);
            TearDown();
        }

        [Test]
        public void AttackOccupiedLocationTwice()
        {
            Setup();
            _location.Occupy(_ship);
            TestDelegate test = () => _location.Attack();
            test.Invoke();
            Assert.Throws<LocationAlreadyAttackedException>(test);
            TearDown();
        }

        [Test]
        public void GetLocationId()
        {
            Setup();
            Assert.AreEqual("A1", _location.GetPositionId());
            TearDown();
        }
        #endregion
    }
}
