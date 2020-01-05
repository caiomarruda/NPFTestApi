using System.Collections.Generic;
using System.Linq;

namespace NPFTestApi.Core.Models.Divisibility.Request
{
    public class MultipleRequest
    {
        public List<string> Numbers { get; set; }

        public List<int> NumbersInt()
        {
            return Numbers.Select(s => int.Parse(s)).ToList();
        }
    }


}
