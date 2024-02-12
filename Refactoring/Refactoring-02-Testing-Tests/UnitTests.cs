using Refactoring_02_Testing_Library;
using Refactoring_02_Testing_Library.DTO;

namespace Refactoring_02_Testing_Tests
{
    public class UnitTests
    {
        [Fact]
        public void ShortfallTest()
        {
            var europe = new Province(ProvinceData.SampleProvinceData());

            Assert.Equal(5, europe.Shortfall());
        }
    }
}