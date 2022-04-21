using NUnit.Framework;

namespace DateFormat.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string NewDate = Program.ChangeFormat("10/11/1977");
            Assert.AreEqual(NewDate, "1977-11-10");
        }

        [Test]
        public void Test2()
        {
            string NewDate = Program.ChangeFormat("09/02/2005");
            Assert.AreEqual(NewDate, "2005-02-09");
        }
    }
}