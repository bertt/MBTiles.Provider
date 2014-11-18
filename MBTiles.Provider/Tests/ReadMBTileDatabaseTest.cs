
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBTiles.Provider.Tests
{
    [TestClass]
    public class ReadMBTileDatabaseTest
    {

        [TestMethod]
        public void FirstTest()
        {
            // arrange
            var connectionString = string.Format("Data Source={0}", "cities.mbtile");
            var mbTileProvider = new MbTileProvider(connectionString);

            // act
            var image = mbTileProvider.GetTile("0", 0, 0);

            // assert
            Assert.IsTrue(image!=null);
            
        }
    }
}
