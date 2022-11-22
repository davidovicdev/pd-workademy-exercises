namespace PD.Workademy.Exercises.Tasks
{
    public static class UglyNumberCheck
    {
        public static void Test(int input)
        {
            /*Write a method that receives an integer and returns true if integer is ugly number. 
             * Ugly number is positive integer whose factors are limited to 2, 3 and 5.*/
            bool isUglyNumber = false;
            int realInput = input;
            List<int> validFactorsForUglyNumber = new() { 2, 3, 5 };
            List<int> factors = new();
            do
            {
                if (input % 2 == 0)
                {
                    input /= 2;
                    factors.Add(2);
                }
                else if (input % 3 == 0)
                {
                    input /= 3;
                    factors.Add(3);
                }
                else if (input % 5 == 0)
                {
                    input /= 5;
                    factors.Add(5);
                }
                else
                {
                    var temp = input;
                    input /= input;
                    factors.Add(temp);
                }
            } while (input != 1);
            Console.WriteLine($"Input: {realInput}; Output; nesto ({String.Join(',', factors)})");
        }
    }
}
