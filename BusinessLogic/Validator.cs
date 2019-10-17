using System;

namespace BusinessLogic
{
    public  class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public bool IsSsn(string ssn)
        {
            string newSsn = ssn.Replace("-", string.Empty);
            
            if (int.TryParse(newSsn, out int s))
            {
                if (ssn.Trim().ToString().Length == 9)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            throw new NotImplementedException();
        }
    }
}
