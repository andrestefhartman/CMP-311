using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventDI;


namespace EvenDITests
{
    [TestClass]
    public class EventDIUnitTests
    {
        [TestMethod]
        public void EventInfoDescription()
        {
            //arrange
            EventInfo eventinfo = new EventInfo(1, "info", 5);

            //act
            string description = eventinfo.Description;

            //assert
            Assert.AreEqual(description, "info");
        }

        [TestMethod]
        public void EventInfoID()
        {
            //arrange
            EventInfo eventinfo = new EventInfo(1, "info", 5);

            //act
            int id = eventinfo.Id;

            //assert
            Assert.AreEqual(id, 1);
        }

        [TestMethod]
        public void EventInfoAttendees()
        {
            //arrange
            EventInfo eventinfo = new EventInfo(1, "info", 5);

            //act
            int attendees = eventinfo.Attendees;

            //assert
            Assert.AreEqual(attendees, 5);
        }

        [TestMethod]
        public void BirthdayDefCost()
        {
            //arrange
            ICost birthday = new Birthday(0001, "info", 10);

            //act
            double cost = birthday.GetCost();

            //assert
            Assert.AreEqual(cost, 125);
        }

        [TestMethod]
        public void ConferenceDefCost()
        {
            //arrange
            ICost conference = new Conference(0001, "info", 10);

            //act
            double cost = conference.GetCost();

            //assert
            Assert.AreEqual(cost, 207.5);

        }

        
        [TestMethod]
        public void CharityDefCost()
        {
            //arrange
            ICost charity = new Charity(0001, "info", 10);

            //act
            double cost = charity.GetCost();

            //assert
            Assert.AreEqual(cost, 160);
        }
        

        [TestMethod]
        public void TestCode_D()
        {
            //arrange
            ICost birthday = new Birthday(0001, "info", 10);

            //act
            double cost = birthday.GetCost("D");

            //assert
            Assert.AreEqual(cost, 125 * 0.9);
        }

        [TestMethod]
        public void TestCode_d()
        {
            //arrange
            ICost birthday = new Birthday(0001, "info", 10);

            //act
            double cost = birthday.GetCost("d");

            //assert
            Assert.AreEqual(cost, 125 * 0.9);
        }

        [TestMethod]
        public void TestCode_E()
        {
            //arrange
            ICost birthday = new Birthday(0001, "info", 10);

            //act
            double cost = birthday.GetCost("E");

            //assert
            Assert.AreEqual(cost, 125 * 0.75);
        }

        [TestMethod]
        public void TestCode_e()
        {
            //arrange
            ICost birthday = new Birthday(0001, "info", 10);

            //act
            double cost = birthday.GetCost("e");

            //assert
            Assert.AreEqual(cost, 125 * 0.75);
        }

        [TestMethod]
        public void TestCode_f()
        {
            //arrange
            ICost birthday = new Birthday(0001, "info", 10);

            //act
            double cost = birthday.GetCost("f");

            //assert
            Assert.AreEqual(cost, 0);
        }

        [TestMethod]
        public void TestCode_l()
        {
            //arrange
            ICost birthday = new Birthday(0001, "info", 10);

            //act
            double cost = birthday.GetCost("l");

            //assert
            Assert.AreEqual(cost, 125 * 1.1);
        }

        [TestMethod]
        public void TestCode_INVALID()
        {
            //arrange
            ICost birthday = new Birthday(0001, "info", 10);

            //act
            double cost = birthday.GetCost("u");

            //assert
            Assert.AreEqual(cost, 125);
        }
    }
}