namespace PD.Workademy.Exercises.Tasks
{
    public static class CheckIfSentnceIsPangram
    {
        public static void Test(string input)
        {
            /*
                Write a method that receives one string and returns true if sentence is pangram, and false if it is not.
                Sentence is pangram if consists every letter of the English alphabet.
            */
            if (input.Length <= 1 || input.Length >= 1000)
            {
                Console.WriteLine($"{input} needs to have minimum 2 and maximum 1000 characters");
            }
            else if (input.Any(char.IsUpper) || input.Any(char.IsWhiteSpace))
            {
                Console.WriteLine($"{input} needs to be in lowercase and without any spaces");
            }
            else
            {
                string alphapbetString = "abcdefghijklmnopqrstuvwxyz";
                List<char> alphabet = new();
                foreach (char c in alphapbetString)
                    alphabet.Add(c);
                List<char> lettersInInput = new() { };
                for (int i = 0; i < input.Length; i++)
                {
                    if (lettersInInput.Contains(input[i]))
                        continue;
                    else
                        lettersInInput.Add(input[i]);
                }
                Console.WriteLine(
                    $"Input: '{input}';Output: {alphabet.All(lettersInInput.Contains)}"
                );
            }
        }
    }
}
