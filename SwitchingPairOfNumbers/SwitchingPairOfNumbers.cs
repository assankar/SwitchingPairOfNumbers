using System;

namespace SwitchingPairOfNumbers
{
    class SwitchingPairOfNumbers
    {
        static void Main(string[] args)
        {
            SwitchingPairOfNumbers switchingPairOfNumbers = new SwitchingPairOfNumbers();
            Console.WriteLine(switchingPairOfNumbers.SwitchPairs(123456));
            Console.WriteLine(switchingPairOfNumbers.SwitchPairs(21783));
        }

        public SwitchingPairOfNumbers()
        {

        }

        public int SwitchPairs(int number)
        {
            string s = number.ToString();
            string swappedString = "";

            for(int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    swappedString = swappedString + s[i];
                    break;
                }
                swappedString = swappedString + s[i + 1] + s[i];
                i++;
            }

            return int.Parse(swappedString);
        }
    }
}
