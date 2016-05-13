using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestClass()]
    public class BattleShipTests
    {

        [TestMethod()]
        public void HitTest()
        {
            Ship testShip = new Ship(ShipName.AircraftCarrier);

            testShip.Hit();
            testShip.Hit();

            Assert.IsTrue(testShip.Hits == 2);
        }

        [TestMethod()]
        public void AddPlayerTest()
        {
            BattleShipsGame testGame = new BattleShipsGame();
            Player p1 = new Player(testGame);
            testGame.AddDeployedPlayer(p1);
            Assert.AreEqual(p1, testGame.Player);
        }

        [TestMethod()]
        public void IsDestroyedTest()
        {
            Ship testShip = new Ship(ShipName.AircraftCarrier);
            for (int i = 0; i < 5; i++) { testShip.Hit(); }
            bool expected = true;
            bool actual = testShip.IsDestroyed;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShipMove()
        {
            var shipDic = new Dictionary<ShipName, Ship>();
            var testShip = new Ship(ShipName.AircraftCarrier);
            shipDic.Add(ShipName.AircraftCarrier, testShip);
            SeaGrid testGrid = new SeaGrid(shipDic);
            //Ship testShip = new Ship(ShipName.AircraftCarrier);
            testGrid.MoveShip(5, 5, ShipName.AircraftCarrier, Direction.UpDown);
            int expectedRow = 5;
            int expectedCol = 5;
            Direction expectedDir = Direction.UpDown;

            int actualRow = testShip.Row;
            int actualCol = testShip.Column;
            Direction actualDir = testShip.Direction;
            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
            Assert.AreEqual(expectedDir, actualDir);
        }


        [TestMethod()]
        public void ShipSize()
        {
            var testship = new Ship(ShipName.AircraftCarrier);
            int expectedSize = 5;
            int actualSize = testship.Size;
            Assert.AreEqual(expectedSize, actualSize);
        }

        [TestMethod()]
        public void AddShip()
        {
            var shipDictonary = new Dictionary<ShipName, Ship>();
            var testShip = new Ship(ShipName.AircraftCarrier);
            shipDictonary.Add(ShipName.AircraftCarrier, testShip);
            SeaGrid testGrid = new SeaGrid(shipDictonary);
            testGrid.MoveShip(3, 4, ShipName.AircraftCarrier, Direction.UpDown);
            int expectedRow = 3;
            int expectedCol = 4;
            Direction expectedDirection = Direction.UpDown;
            int actualRow = testShip.Row;
            int actualCol = testShip.Column;
            Direction actualDirection = testShip.Direction;

            Assert.AreEqual(expectedRow, actualRow);
            Assert.AreEqual(expectedCol, actualCol);
            Assert.AreEqual(expectedDirection, actualDirection);
        }

    }
}