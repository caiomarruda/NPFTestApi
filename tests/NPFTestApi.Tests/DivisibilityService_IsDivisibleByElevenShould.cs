using NPFTestApi.Core.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NPFTestApi.Tests
{
    public class DivisibilityService_IsDivisibleByElevenShould
    {
        private readonly DivisibilityService _divisibilityService;

        public DivisibilityService_IsDivisibleByElevenShould()
        {
            _divisibilityService = new DivisibilityService();
        }

        #region Sample_TestCode
        [Theory]
        [InlineData(new object[] { new int[] { -10, 4, 0, 1, 9} })]
        public void IsDivisibleByEleven_ValuesLessThan2_ReturnFalse(int[] value)
        {
            var result = _divisibilityService.IsNumberDivisibleByEleven(new List<int>(value));

            Assert.Contains(true, result.Select(x => x.IsMultiple == false));
            //Assert.Contains<MultipleResponse>(result.GetEnumerator(), false);

            //Assert.Contains(result, $"{value} should not be prime");
        }
        #endregion

        [Theory]
        [InlineData(new object[] { new int[] { 112233, 30800, 2937, 323455693 } })]
        public void IsDivisibleByEleven_ValuesGreatherThan2_ReturnTrue(int[] value)
        {
            var result = _divisibilityService.IsNumberDivisibleByEleven(new List<int>(value));

            Assert.Contains(true, result.Select(x => x.IsMultiple == true));
        }

        [Theory]
        [InlineData(new object[] { new int[] { 112234, 33, 30800 } })]
        public void IsDivisibleByEleven_ValuesGreatherThan2_ReturnFalse(int[] value)
        {
            var result = _divisibilityService.IsNumberDivisibleByEleven(new List<int>(value));

            Assert.Contains(true, result.Select(x => x.IsMultiple == false));
        }
    }
}
