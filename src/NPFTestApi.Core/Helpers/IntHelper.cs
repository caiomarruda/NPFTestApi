using System;

namespace NPFTestApi.Core.Helpers
{
    public static class IntHelper
    {
        public static int IntLength(int i)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException();
            if (i == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(i)) + 1;
        }
    }
}
