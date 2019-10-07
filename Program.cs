using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

// Add several more words and their definitions
wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#.");
wordsAndDefinitions.Add("Frowsy", "having a slovenly or uncared-for appearance.");
wordsAndDefinitions.Add("Abscond", "to depart secretly and hide oneself.");
wordsAndDefinitions.Add("Pell-Well", "in mingled confusion or disorder.");


/*
    Use square brackets to get the definition of two of the
    words and then output them to the console
*/
Console.WriteLine(wordsAndDefinitions["Frowsy"]);
Console.WriteLine(wordsAndDefinitions["Pell-Well"]);

/*
    Below, loop over the wordsAndDefinitions dictionary to get the following output:
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
*/
foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
{
    Console.WriteLine($"The Meaning of {word.Key} is {word.Value}");
}
        }
    }
}
// hopefully this pulls
