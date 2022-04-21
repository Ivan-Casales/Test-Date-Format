using NUnit.Framework;

namespace DateFormat.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestChangeFormat1_1()
        {
            string NewDate = Program.ChangeFormat1("10/11/1977");
            Assert.AreEqual(NewDate, "1977-11-10");
        }

        [Test]
        public void TestChangeFormat1_2()
        {
            string NewDate = Program.ChangeFormat1("09/02/2005");
            Assert.AreEqual(NewDate, "2005-02-09");
        }

        [Test]
        public void TestChangeFormat2_1()
        {
            string NewDate = Program.ChangeFormat2("10/11/1977");
            Assert.AreEqual(NewDate, "10-11-1977");
        }

        [Test]
        public void TestChangeFormat2_2()
        {
            string NewDate = Program.ChangeFormat2("09/02/2005");
            Assert.AreEqual(NewDate, "09-02-2005");
        }

    }
}