using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventIFace;

namespace EventUnitTests
{
    [TestClass]
    public class EventTests
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
            IBirthday birthday = new Event(0001, "info", 10);

            //act
            birthday.PrintCost();

            //assert
            Assert.AreEqual(birthday.Cost(),125);
        }

        [TestMethod]
        public void ConferenceDefCost()
        {
            //arrange
            IConference conference = new Event(0001, "info", 10);

            //act
            conference.PrintCost();

            //assert
            Assert.AreEqual(conference.Cost(), 207.5);

        }

        [TestMethod]
        public void CharityDefCost()
        {
            //arrange
            ICharity charity = new Event(0001, "info", 10);

            //act
            charity.PrintCost();

            //assert
            Assert.AreEqual(charity.Cost(), 160);
        }

        [TestMethod]
        public void TestCode_D()
        {
            //arrange
            IBirthday birthday = new Event(0001, "info", 10);

            //act
            birthday.PrintCostCode("D");

            //assert
            Assert.AreEqual(birthday.Cost(), 125 * 0.9);
        }

        [TestMethod]
        public void TestCode_d()
        {
            //arrange
            IBirthday birthday = new Event(0001, "info", 10);

            //act
            birthday.PrintCostCode("d");

            //assert
            Assert.AreEqual(birthday.Cost(), 125 * 0.9);
        }

        [TestMethod]
        public void TestCode_E()
        {
            //arrange
            IBirthday birthday = new Event(0001, "info", 10);

            //act
            birthday.PrintCostCode("E");

            //assert
            Assert.AreEqual(birthday.Cost(), 125 * 0.75);
        }

        [TestMethod]
        public void TestCode_e()
        {
            //arrange
            IBirthday birthday = new Event(0001, "info", 10);

            //act
            birthday.PrintCostCode("e");

            //assert
            Assert.AreEqual(birthday.Cost(), 125 * 0.75);
        }

        [TestMethod]
        public void TestCode_f()
        {
            //arrange
            IBirthday birthday = new Event(0001, "info", 10);

            //act
            birthday.PrintCostCode("f");

            //assert
            Assert.AreEqual(birthday.Cost(), 0);
        }

        [TestMethod]
        public void TestCode_l()
        {
            //arrange
            IBirthday birthday = new Event(0001, "info", 10);

            //act
            birthday.PrintCostCode("l");

            //assert
            Assert.AreEqual(birthday.Cost(), 125 * 1.1);
        }

        [TestMethod]
        public void TestCode_INVALID()
        {
            //arrange
            IBirthday birthday = new Event(0001, "info", 10);

            //act
            birthday.PrintCostCode("u");

            //assert
            Assert.AreEqual(birthday.Cost(), 125);
        }
    }
}