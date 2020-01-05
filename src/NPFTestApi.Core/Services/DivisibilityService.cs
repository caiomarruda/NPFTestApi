using NPFTestApi.Core.Helpers;
using NPFTestApi.Core.Interfaces;
using NPFTestApi.Core.Models.Divisibility.Response;
using System;
using System.Collections.Generic;

namespace NPFTestApi.Core.Services
{
    public class DivisibilityService : IDivisibilityService
    {
        public DivisibilityService()
        {
        }

        public IEnumerable<MultipleResponse> IsNumberDivisibleByEleven(List<int> Numbers, bool recursiveValidation = false)
        {
            var lstMultiple = new List<MultipleResponse>();

            Numbers.ForEach(x =>
            {
                lstMultiple.Add(new MultipleResponse
                {
                    Number = x.ToString(),
                    IsMultiple = recursiveValidation 
                        ? DivByElevenRecursive(x) 
                        : DivByEleven(x)
                });

            });
            return lstMultiple;
        }

        private bool DivByEleven(int number)
        {
            return
                number % 11 == 0;
        }

        private bool DivByElevenRecursive(int number)
        {
            try
            {
                if (IntHelper.IntLength(number) <= 1)
                    return false;

                int lastNumber = number % 10;

                if (IntHelper.IntLength(number) == 2)
                {
                    int firstNumber = number / 10;
                    return firstNumber == lastNumber;
                }
                else
                    return DivByElevenRecursive((number / 10) - lastNumber);
            }
            catch(ArgumentOutOfRangeException)
            {
                return false;
            }
        }
    }
}
