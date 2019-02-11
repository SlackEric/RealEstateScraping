using Xunit;
using System.Diagnostics;
using RealEstateScraping;
using System.Linq;

namespace RealEstateScraping.Tests
{
    public class UnitTest1
    {
        [Fact (DisplayName = "Test")]
        public async void Test1()
        {
            RealEstateScraper scraper = new RealEstateScraper();
          
            var result = scraper.GetHousesInMapBoundary().GetAwaiter().GetResult();
                 
            Debugger.Break();
        }
    }
}
