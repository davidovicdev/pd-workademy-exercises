namespace PD.Workademy.Exercises.Tasks
{
    public static class GreatestCommonDivisorOfArray
    {
        public static void Test(int[] numbers)
        {
            /*
             Write a method that receives array of integers and returns integer that is greatest common divisor of1 array
             (greatest common divisor of the smallest and the largest number in array of integers).
            */
            int minNumber = numbers.Min();
            int maxNumber = numbers.Max();
            int output = 0;
            for (int i = maxNumber; i > 0; i--)
            {
                if (maxNumber % i == 0 && minNumber % i == 0)
                {
                    output = i;
                    break;
                }
            }
            Console.WriteLine($"Input: [{string.Join(",", numbers)}]; Output: {output}");
        }
    }
}
