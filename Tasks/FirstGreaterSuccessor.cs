namespace PD.Workademy.Exercises.Tasks
{
    public static class FirstGreaterSuccessor
    {
        public static void Test(int[] input)
        {
            /* Write a method that receives an array of integers (initialArray) and returns also an array of integers (resultArray) 
             * where each element has value that represents how far from original value is his first greater successor.
             * For example, if initialArray[3] = 5, value of resultArray[3] will be distance from that index (3) to the index of next greater successor.
             * In case there is not greater successor value will be 0.*/
            List<int> output = new();
            for (int i = 0; i < input.Length - 1; i++)
            {
                int distance = 0;
                if (input[i] < input[i + 1])
                {
                    ++distance;
                }
                else
                {
                    for (int j = i; j < input.Length - 1; j++)
                    {
                        if (input[i] < input[j])
                        {
                            distance = j - i;
                        }
                    }
                }
                output.Add(distance);
            }
            output.Add(0);
            Console.WriteLine($"Input: [{String.Join(",", input)}]; Output: [{String.Join(",", output)}]");
        }
    }
}
