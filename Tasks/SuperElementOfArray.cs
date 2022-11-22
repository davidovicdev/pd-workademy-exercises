namespace PD.Workademy.Exercises.Tasks
{
    public static class SuperElementOfArray
    {
        public static void Test(int[] input)
        {
            /* Write a method that receives an array of integers and returns value of super element of given array, otherwise it returns -1.
             * Super element is element that has a value equal to the number of repetitions in the array.*/
            int output = -1;
            for (int i = 0; i < input.Length; i++)
            {
                List<int> thatNumbers = new() { };
                for (int j = 0; j < input.Length; j++)
                    if (input[i] == input[j])
                        thatNumbers.Add(input[j]);
                if (thatNumbers.Count == input[i])
                    if (output <= input[i])
                        output = input[i];
            }
            Console.WriteLine($"Input: [{String.Join(",", input)}]; Output: {output}");
        }
    }
}
