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
    You want to track the following about each word:
        word, definition, part of speech, example sentence

    Example of one dictionary in the list:
    {
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    }
*/

// Create dictionary to represent a few words
Dictionary<string, string> excitedWord = new Dictionary<string, string>();

// Add each of the 4 bits of data about the word to the Dictionary
excitedWord.Add("word", "Excited");
excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
excitedWord.Add("part of speech", "adjective");
excitedWord.Add("example sentence", "I am excited to learn C#!");


// Add Dictionary to your `dictionaryOfWords` list



// create another Dictionary and add that to the list


/*
    Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

    Example output for one word in the list of dictionaries:
        word: excited
        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
        part of speech: adjective
        example sentence: I am excited to learn C#!
*/

// Iterate the List of Dictionaries
foreach ()
{
    // Iterate the KeyValuePairs of the Dictionary
    foreach ()
    {
        Console.WriteLine($"{wordData.Key}: {wordData.Value}");
    }
}
        }
    }
}

