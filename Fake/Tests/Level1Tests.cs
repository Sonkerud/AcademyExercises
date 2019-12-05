using Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Level1Tests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            var h = new Hej();
            var result = h.Add100(5);

            Assert.AreEqual(105, result);
        }
    }
}
