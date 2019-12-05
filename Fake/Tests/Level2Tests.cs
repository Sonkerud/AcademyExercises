using Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Level2Tests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            var h = new Hej();
            var result = h.Subtract5(200);

            Assert.AreEqual(195, result);
        }
    }
}
