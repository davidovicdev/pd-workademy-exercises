namespace PD.Workademy.Exercises.Tasks
{
    public static class FibonacciNumberCalculator
    {
        public static void Test(int input)
        {
            /*
                Write a method that receives a integer and returns value of Fib(n).
                Fib is function that calculates Fibonacci numbers -
                numbers of Fibonacci sequence where each element of sequence has value that is sum of the two preceding elements.
                First(Fib(0)) and second(Fib(1)) elements have values 0 and 1.
            */
            if (input < 0 || input > 100)
                Console.WriteLine("Input number needs to be between 0 and 100");
            else
            {
                int result = 0;
                int temporarySumOfTwoNumbers = 0;
                for (int i = 1; i <= input; i++)
                {
                    if (input == 0)
                    {
                        result = 0;
                        break;
                    }
                    else
                    {
                        int j = i - 1;
                    }
                }
            }
        }
    }
}
