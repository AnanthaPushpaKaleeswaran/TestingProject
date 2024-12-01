using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace JenkinsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string text = "Jenkins";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                JenkinsProject.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(text, result);
            }
        }
    }
}