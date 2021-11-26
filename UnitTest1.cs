using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestISBN2
{
    [TestClass]
    public class VerificarISBN
    {
        [TestMethod]
        public void TestMethodValidarISBN10()
        {
            int ISBN10 = 0;
            bool ISBNvalid = false;
            int[] digit10 = { 0, 7, 1, 6, 7, 0, 3, 4, 4, 0 };

            ISBN10 = ((digit10[0]*10)+ (digit10[1] * 9) + (digit10[2] * 8) + (digit10[3] * 7) + (digit10[4] * 6) + (digit10[5] * 5) + (digit10[6] * 4) + (digit10[7] * 3) + (digit10[8] * 2) + (digit10[9] * 1));
            ISBNvalid = (ISBN10 % 11 == 0);

            if (ISBN10 == 0)
            {
                Assert.IsTrue(ISBNvalid);
            }
        }

        [TestMethod]
        public void TestMethodInvalidarISBN10()
        {
            int ISBN10 = 0;
            bool ISBNinvalid = false;
            int[] digit10 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ISBN10 = ((digit10[0] * 10) + (digit10[1] * 9) + (digit10[2] * 8) + (digit10[3] * 7) + (digit10[4] * 6) + (digit10[5] * 5) + (digit10[6] * 4) + (digit10[7] * 3) + (digit10[8] * 2) + (digit10[9] * 1));
            ISBNinvalid = (ISBN10 % 11 == 0);

            if (ISBN10 == 0)
            {
                Assert.IsFalse(ISBNinvalid);
            }
        }

        [TestMethod]
        public void TestMethodValidarISBN13()
        {
            int ISBN13 = 0;
            bool ISBNvalid = false;
            int[] digit13 = { 9, 7, 8, 0, 7, 1, 6, 7, 0, 3, 4, 4, 0 };

            ISBN13 = ((digit13[0] * 1) + (digit13[1] * 3) + (digit13[2] * 1) + (digit13[3] * 3) + (digit13[4] * 1) + (digit13[5] * 3) + (digit13[6] * 1) + (digit13[7] * 3) + (digit13[8] * 1) + (digit13[9] * 3) + (digit13[10] * 1) + (digit13[11] * 3) + (digit13[12] * 1));
            ISBNvalid = (ISBN13 % 10 == 0);

            if (ISBN13 == 0)
            {
                Assert.IsTrue(ISBNvalid);
            }
        }

        [TestMethod]
        public void TestMethodInalidarISBN13()
        {
            int ISBN13 = 0;
            bool ISBNinvalid = false;
            int[] digit13 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 2, 1 };

            ISBN13 = ((digit13[0] * 1) + (digit13[1] * 3) + (digit13[2] * 1) + (digit13[3] * 3) + (digit13[4] * 1) + (digit13[5] * 3) + (digit13[6] * 1) + (digit13[7] * 3) + (digit13[8] * 1) + (digit13[9] * 3) + (digit13[10] * 1) + (digit13[11] * 3) + (digit13[12] * 1));
            ISBNinvalid = (ISBN13 % 10 == 0);

            if (ISBN13 != 0)
            {
                Assert.IsFalse(ISBNinvalid);
            }
        }
    }
}
