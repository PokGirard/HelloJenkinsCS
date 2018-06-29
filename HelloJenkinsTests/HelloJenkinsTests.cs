using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloJenkins;


namespace HelloJenkinsTests
{
    [TestClass]
    public class HelloJenkinsTests
    {
        [TestMethod]
        public void CreateMessage_WhenCalled_ReturnsHelloJenkins()
        {

          Assert.IsTrue("Hello World".Equals(Program.createMessage() + "false"));

        }

    }
}
