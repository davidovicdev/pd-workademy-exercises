namespace PD.Workademy.Exercises.Tasks
{
    public static class CheckIfStringIsSubsequenceOfSentence
    {
        public static void Test(string firstString, string secondString)
        {
            /*
                Write a method that receives two strings and returns true if first string is subsequence of second string , in other case it returns false.
                String is subsequence of second string in case all its characters are part of that second string, without changing order of characters.
                Characters don't have to be next to each other.
            */
            if (firstString.Length < 0 || firstString.Length > 100)
                Console.WriteLine("First string needs to have character length between 0 and 100");
            else if (secondString.Length < 0 || secondString.Length > 1000)
                Console.WriteLine(
                    "Second string needs to have character length between 0 and 1000"
                );
            else if (firstString.Any(char.IsUpper) || secondString.Any(char.IsUpper))
                Console.WriteLine("Both strings need to be in lowercase");
            else
            {
                List<bool> foundCharacters = new();
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (secondString.Any(x => x.Equals(firstString[i])))
                        foundCharacters.Add(true);
                }
                bool result = foundCharacters.Count == firstString.Length;
                Console.WriteLine(
                    $"Input: firstString ='{firstString}', secondString ='{secondString}' Output: {result})"
                );
            }
        }
    }
}
