using Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Level1Tests
    {
        // Create a class "Destination" and make the following test pass.

        [TestMethod]
        public void destination_rhodos()
        {
            var d = new Destination("Rhodos"); // Create a destination with the namn Rhodos
            d.AddHotel("Miramare", 2); // Add a hotel to the destination with 2 pools
            d.AddHotel("Kallithea", 1);
            d.AddHotel("Aquagrand", 3);

            Assert.AreEqual(6, d.TotalNumberOfPools); // There are 2+1+3 = 6 pools in Rhodos

            Assert.AreEqual("DESTINATION RHODOS", d.GetName()); // GetName should give DESTINATION and then the name in uppercase

            var hotelnames = d.HotelNames; // HotelNames should return a list of all hotelnames

            Assert.AreEqual(3, hotelnames.Count);
            Assert.AreEqual("Miramare", hotelnames[0]);
            Assert.AreEqual("Kallithea", hotelnames[1]);
            Assert.AreEqual("Aquagrand", hotelnames[2]);

            Assert.AreEqual(3, d.MaxPools); // "MaxPools" should tell the maximum number of pools in a hotel on this destination 

        }

        [TestMethod]
        public void destination_yyy()
        {
            var d = new Destination("yyy");
            d.AddHotel("AA", 20);
            d.AddHotel("BB", 19);

            Assert.AreEqual(39, d.TotalNumberOfPools);

            Assert.AreEqual("DESTINATION YYY", d.GetName());

            var hotelnames = d.HotelNames;

            Assert.AreEqual(2, hotelnames.Count);
            Assert.AreEqual("AA", hotelnames[0]);
            Assert.AreEqual("BB", hotelnames[1]);

            Assert.AreEqual(20, d.MaxPools);

        }
        [TestMethod]
        public void destination_zzz()
        {
            var d = new Destination("zzz");
            d.AddHotel("AA", 4);
            d.AddHotel("BB", 8);
            d.AddHotel("CC", 2);
            d.AddHotel("DD", 1);

            Assert.AreEqual(15, d.TotalNumberOfPools);

            Assert.AreEqual("DESTINATION ZZZ", d.GetName());

            var hotelnames = d.HotelNames;

            Assert.AreEqual(4, hotelnames.Count);
            Assert.AreEqual("AA", hotelnames[0]);
            Assert.AreEqual("BB", hotelnames[1]);
            Assert.AreEqual("CC", hotelnames[2]);
            Assert.AreEqual("DD", hotelnames[3]);

            Assert.AreEqual(8, d.MaxPools);

        }
    }
}
