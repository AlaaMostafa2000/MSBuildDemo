using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestJenkinsBuildAndTestTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World";
        [TestMethod]
        public void TestMethod1()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TestJenkinsBuildAndTest.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
