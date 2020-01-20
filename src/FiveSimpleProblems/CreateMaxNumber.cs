using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FiveSimpleProblems
{
    public class CreateMaxNumber
    {
        public List<int> Numbers { get; set; }
        public CreateMaxNumber(List<int> numbers) 
        {
            if (numbers.Count > 0)
            {
                this.Numbers = numbers;
            }
            else
            {
                throw new Exception("The list of numbers cannot be empty.");
            }
        }

        public int GetMaxNumber() {
            int maxNumber = 0;
            var numberStringList = Numbers.Select( i => i.ToString()).OrderByDescending( x => x).ToList();
            var stringData = String.Join("",numberStringList.ToArray());
            if (!int.TryParse(stringData, out maxNumber))
            { 
            }
            return maxNumber;
        }


    }
}
