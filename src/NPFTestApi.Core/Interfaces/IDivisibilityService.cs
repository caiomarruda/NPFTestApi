using NPFTestApi.Core.Models.Divisibility.Response;
using System.Collections.Generic;

namespace NPFTestApi.Core.Interfaces
{
    public interface IDivisibilityService
    {
        IEnumerable<MultipleResponse> IsNumberDivisibleByEleven(List<int> number);
        IEnumerable<MultipleResponse> IsNumberDivisibleByElevenRecursive(List<int> Numbers);
    }
}
