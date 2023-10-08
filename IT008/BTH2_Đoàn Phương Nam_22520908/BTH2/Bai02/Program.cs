using System.Globalization;

class Program
{
    static string FixString(string input)
    {
        // Split the input into words
        string[] words = input.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        for (int i = 0; i < words.Length; i++)
        {
            // Convert each word to lowercase
            //string word = words[i].ToLower();
            //// Capitalize the first letter of each word
            //char[] characters = word.ToCharArray();
            //characters[0] = char.ToUpper(characters[0]);
            //words[i] = new string(characters);

            words[0] = textInfo.ToTitleCase(words[0].ToLower());
        }

        // Join the words back together with spaces
        string result = string.Join(" ", words);

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a full name:");
        string input = Console.ReadLine();
        string fixedString = FixString(input);
        Console.WriteLine("Fixed Name: " + fixedString);
    }
}
