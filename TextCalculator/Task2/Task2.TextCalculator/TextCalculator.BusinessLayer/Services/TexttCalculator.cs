using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextCalculator.BusinessLayer.Interfaces;

namespace TextCalculator.BusinessLayer.Services
{
    public class TexttCalculator : ITextCalculator
    {
        public string Add(string str)
        {
			var parsedNumbers = new List<double>();
			var negativeNumbers = new List<double>();
			var emptyPositions = new List<int>();

			// Validate for empty string
			if (String.IsNullOrEmpty(str))
			{
				return "0";
			}

			var nums = str.Split(',');

			//Other validations
			for (var i = 0; i < nums.Length; i++)
			{
				if (String.IsNullOrEmpty(nums[i]))
				{
					emptyPositions.Add((i + 1));
					continue;
				}

				double parsed;
				bool successfulConversion = double.TryParse(nums[i], out parsed);
				if (!successfulConversion)
				{
					throw new Exception("Insert only numbers!");
				}
				else
				{
					if (parsed < 0)
					{
						negativeNumbers.Add(parsed);
					}
					else
					{
						parsedNumbers.Add(parsed);
					}
				}


			}

			//Return for negative numbers
			if (negativeNumbers.Count > 0)
			{
				var message = string.Join(",", negativeNumbers);

				throw new Exception("Negative not allowed: " + message);
			}

			//Missing number in position-->showing every position that has empty string, not only the last one
			if (emptyPositions.Count > 0)
			{
				var message = string.Join(",", emptyPositions);

				throw new InvalidOperationException("Missing number on position " + message);
			}

			//Getting sum from numbers


			string sum = parsedNumbers.Sum().ToString();


			//Returning final result

			return sum;



		}
	}
}
