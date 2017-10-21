using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatchParenthesis;

namespace EGift.Testing
{
    [TestClass]
    public class MatchParenthesisTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testing = new MatchingParenthesis();

            string strTest = "39()(55555)";

            bool result = testing.hasMatches(strTest);

        }
    }
}
