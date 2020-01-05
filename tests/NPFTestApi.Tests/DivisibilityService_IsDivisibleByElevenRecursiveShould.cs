using NPFTestApi.Core.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NPFTestApi.Tests
{
    public class DivisibilityService_IsDivisibleByElevenRecursiveShould
    {
        private readonly DivisibilityService _divisibilityService;

        public DivisibilityService_IsDivisibleByElevenRecursiveShould()
        {
            _divisibilityService = new DivisibilityService();
        }

        [Theory]
        [InlineData(new object[] { new int[] { -10, 4, 0, 1, 9 } })]
        public void IsDivisibleByElevenRecursive_ValuesLessThan2_ReturnFalse(int[] value)
        {
            var result = _divisibilityService.IsNumberDivisibleByElevenRecursive(new List<int>(value));

            Assert.Contains(true, result.Select(x => x.IsMultiple == false));
        }

        [Theory]
        [InlineData(new object[] { new int[] { 112233, 30800, 2937, 323455693 } })]
        public void IsDivisibleByElevenRecursive_ValuesGreatherThan2_ReturnTrue(int[] value)
        {
            var result = _divisibilityService.IsNumberDivisibleByElevenRecursive(new List<int>(value));

            Assert.Contains(true, result.Select(x => x.IsMultiple == true));
        }

        [Theory]
        [InlineData(new object[] { new int[] { 112234, 33, 30800 } })]
        public void IsDivisibleByElevenRecursive_ValuesGreatherThan2_ReturnFalse(int[] value)
        {
            var result = _divisibilityService.IsNumberDivisibleByElevenRecursive(new List<int>(value));

            Assert.Contains(true, result.Select(x => x.IsMultiple == false));
        }
    }
}
