namespace PD.Workademy.Exercises.Tasks
{
    public static class SplitStringInBalancedSubstrings
    {
        public static void Test(string input)
        {
            /* Write a method that receives one string that consists only R and S characters (in Upper Case)
             * and returns maximum number of perfect substrings.
             * Perfect substring is one that consists the same number of R and S characters.
             * Characters in string can not be skipped to create more substrings.*/
            if (input.Length <= 2 || input.Length >= 100)
                Console.WriteLine("String needs to contain between 2 and 100 characters.");
            else if (!input.Contains('R') && !input.Contains('S'))
                Console.WriteLine("String needs to have only R and S characters");
            else
            {
                int numberOfR = 0;
                int numberOfS = 0;
                int numberOfPerfectSubStrings = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'R')
                        numberOfR++;
                    else
                        numberOfS++;
                    if (numberOfR == numberOfS)
                    {
                        numberOfR = 0;
                        numberOfS = 0;
                        numberOfPerfectSubStrings++;
                    }
                }
                Console.WriteLine($"Input: '{input}'; Output: {numberOfPerfectSubStrings}");
            }
        }
    }
}
