using NUnit.Framework;
using ConsoleApp22;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(12345, 54321)]
        [TestCase(123, 321)]
        [TestCase(789, 987)]
        [TestCase(1, 1)]

        public void Test_Revers(int num, int expected)
        {
            int actual = Program.Revers(num);
            Assert.AreEqual(expected, actual);
        }

    }
}