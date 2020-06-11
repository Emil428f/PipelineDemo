using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ProgramOne programOne = new ProgramOne();

        [TestMethod]
        public void IsStringTest()
        {
            programOne.InputSetter("Hello");
            Assert.AreEqual("Hello", programOne.Input);
        }
    }
}
