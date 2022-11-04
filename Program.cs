/* Write a method that receives one integer number
   and returns true if number has the same value if it is read from right to left
 , otherwise it returns false. */
Console.WriteLine("\n----- 1. November - IsNumberPalindrome");
void IsNumberPalindrome(int number)
{
    string numberToString = number.ToString();
    string reversedNumberToString = "";
    for (int i = numberToString.Length - 1; i >= 0; i--)
        reversedNumberToString += numberToString[i];
    bool isPalindrome = numberToString == reversedNumberToString;
    Console.WriteLine($"Input: {number}; Output: {isPalindrome}");
}
IsNumberPalindrome(150);
IsNumberPalindrome(181);
IsNumberPalindrome(1);
IsNumberPalindrome(11);
IsNumberPalindrome(19);

/* Write a method that receives one string that consists only R and S characters (in Upper Case)
 * and returns maximum number of perfect substrings.
 * Perfect substring is one that consists the same number of R and S characters.
 * Characters in string can not be skipped to create more substrings.*/
/*void NumberOfPerfectStrings(string input)
{
    
}
NumberOfPerfectStrings("RSRRSSRSRS");
NumberOfPerfectStrings("RSRRRSSRSS");
NumberOfPerfectStrings("SSSSRRRR");*/

/* Write a method that receives one string and returns true if sentence is pangram,
 * and false if it is not. Sentence is pangram if consists every letter of the English alphabet.*/
Console.WriteLine("\n----- 3. November - IsWordPangam");
void IsWordPangam(string input)
{
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
        List<char> alphabet =
            new()
            {
                'a',
                'b',
                'c',
                'd',
                'e',
                'f',
                'g',
                'h',
                'i',
                'j',
                'k',
                'l',
                'm',
                'n',
                'o',
                'p',
                'q',
                'r',
                's',
                't',
                'u',
                'v',
                'w',
                'x',
                'y',
                'z'
            };
        List<char> lettersInInput = new() { };
        for (int i = 0; i < input.Length; i++)
        {
            if (lettersInInput.Contains(input[i]))
                continue;
            else
                lettersInInput.Add(input[i]);
        }
        //Console.WriteLine(alphabet.Equals(lettersInInput));
        Console.WriteLine($"Input: '{input}';Output: {alphabet.All(lettersInInput.Contains)}");
    }
}
IsWordPangam("prodynabelgrade");
IsWordPangam("prodynabelgrade prodynabelgrade");
IsWordPangam("p");
IsWordPangam("jackamazedafewgirlsbydroppingtheantiqueonyxvas");
IsWordPangam("twodrivenjockshelpfaxmybigquiz");

/*
 Write a method that receives two strings and returns true if first string is subsequence of second string , in other case it returns false.
String is subsequence of second string in case all its characters are part of that second string, without changing order of characters.
Characters don't have to be next to each other.
 */
Console.WriteLine("\n----- 4. November - IsOneStringSubsequenceOfAnother");
void IsOneStringSubsequenceOfAnother(string firstString, string secondString)
{
    List<char> chars = new() { };
}
