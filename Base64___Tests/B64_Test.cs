using Microsoft.VisualStudio.TestTools.UnitTesting;
using Base64;

namespace Base64___Tests
{
    [TestClass]
    public class B64_Test
    {
        [TestMethod]
        public void Base64Test1()
        {
            string risposta = B64.Base64();
            Assert.AreEqual("THVjcmV6aWE=", risposta);
        }
    }
}
