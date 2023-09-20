using _1._2Uzduotis_Foreach;

namespace TestPositivenumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPositiveNumbers()
        {
            int[] input = { -1, -2, -3, -4 };
            int[] expected = { 0, 0, 0, 0, };

            int[] actual = Program.GetPositiveNumbers(input);
            CollectionAssert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestPositiveNumber()
        {

            int[] input = { 1, 2, 3, 4 };
            int[] expected = { 1 ,2 ,3 ,4 };

            int[] actual = Program.GetPositiveNumbers(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

}