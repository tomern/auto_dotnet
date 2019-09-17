using NUnit.Framework;

namespace tomerdotnet
{
    public class Class1
    {
        [Parallelizable]
        [TestCase("1000", Category = "test")]
            public void TestCases_Test(string num)
            {
                Assert.AreEqual(1, 1);
            }
    }
}
