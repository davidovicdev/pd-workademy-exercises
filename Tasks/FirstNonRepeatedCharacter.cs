namespace PD.Workademy.Exercises.Tasks
{
    public static class FirstNonRepeatedCharacter
    {
        public static void Test(string input)
        {
            if ((input.Length < 1 || input.Length > 1000) || input.Any(char.IsUpper))
            {
                Console.WriteLine(
                    $"'{input}' needs to have at between 1 and 1000 characters and all of them have to be lowercase"
                );
            }
            else
            {
                int indexOfNumber = -1;
                for (int i = 0; i < input.Length; i++)
                {
                    if (i > 0)
                    {
                        if (input[i] == input[i - 1])
                        {
                            continue;
                        }
                    }
                    string newString = input.Substring(i + 1);
                    if (!newString.Contains(input[i]))
                    {
                        indexOfNumber = i;
                        break;
                    }
                    else
                    {
                        indexOfNumber = -1;
                    }
                }
                Console.WriteLine($"Input: '{input}'; Output: {indexOfNumber}");
            }
        }
    }
}
