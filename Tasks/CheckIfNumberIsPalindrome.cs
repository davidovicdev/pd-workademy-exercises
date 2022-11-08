namespace PD.Workademy.Exercises.Tasks
{
    public static class CheckIfNumberIsPalindrome
    {
        /*  Write a method that receives one integer number
             and returns true if number has the same value if it is read from right to left
            , otherwise it returns false. */

        public static void Test(int number)
        {
            string numberToString = number.ToString();
            string reversedNumberToString = "";
            for (int i = numberToString.Length - 1; i >= 0; i--)
                reversedNumberToString += numberToString[i];
            bool isPalindrome = numberToString == reversedNumberToString;
            Console.WriteLine($"Input: {number}; Output: {isPalindrome}");
        }
    }
}
