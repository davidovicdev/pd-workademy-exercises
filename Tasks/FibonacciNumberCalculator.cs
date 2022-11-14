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
            //  F(n) = F(n-2)+F(n-1)
            if (input < 0 || input > 100)
                Console.WriteLine("Input number needs to be between 0 and 100");
            else
            {
                int FibFrom(int n)
                {
                    if (n == 0)
                        return 0;
                    if (n == 1)
                        return 1;
                    if (n == 2)
                        return 1;
                    else
                        return FibFrom(n - 2) + FibFrom(n - 1);
                }
                int result = FibFrom(input);
                Console.WriteLine($"Input: {input}; Output: {result}");
            }
        }
    }
}
