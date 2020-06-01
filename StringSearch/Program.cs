using System;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchTheString = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(searchTheString);
            Console.WriteLine("Please select a word to search for from within the above sentence: ");
            string userInput = Console.ReadLine();
            string normalizedSentence = searchTheString.ToLower();
            string normalizedInput = userInput.ToLower();
            if (normalizedSentence.Contains(normalizedInput) == true) {
                Console.WriteLine("The word '" + userInput + "' was found");
            }
            else
            {
                Console.WriteLine("The word '" + userInput + "' was not found");
            }

        }
    }
}
