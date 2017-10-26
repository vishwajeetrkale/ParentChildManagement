using System;
using System.Collections.Generic;

namespace CSharpConceptsExamples
{
    public class Class1
    {
        public static void Main()
        {
            Class1 cc = new Class1();
            cc.testValidSentence();
        }

        public static string reconstructSentence(string s, Dictionary<string, bool> dictionary)
        {
            int ptr = 0;
            Stack<int> spaces = new Stack<int>();
            spaces.Push(ptr);
            String currWord = "";
            while (!(spaces.Count == 0))
            {
                currWord = s.Substring(spaces.Peek(), ptr);
                Console.WriteLine("Curr Word: " + currWord);

                if (dictionary.ContainsKey(currWord))
                {
                    Console.WriteLine(">>>Found word: " + currWord);
                    spaces.Push(ptr);
                }

                if (ptr >= s.Length)
                {
                    // reached the end 
                    if (dictionary.ContainsKey(currWord))
                    {
                        Console.WriteLine("Sentence is done!");
                        spaces.Push(ptr);
                        // Done.
                        break;
                    }

                    Console.WriteLine("Backtracking ...");
                    if (spaces.Count == 0)
                    {
                        Console.WriteLine("Sentence could not be reconstructed");
                        break;
                    }
                    else
                    {
                        ptr = spaces.Pop();
                    }

                }

                ptr++;
            }

            // Reconstruct Sentence
            int to = s.Length;
            string sentence = "";
            while (!(spaces.Count == 0))
            {
                int from = spaces.Pop();
                string word = s.Substring(from, to);
                to = from;
                sentence = (word + (" " + sentence));
            }

            return sentence;
        }

        // Try it with this unit test.
        public void testValidSentence()
        {
            Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
            dictionary.Add("the", true);
            dictionary.Add("dog", true);
            dictionary.Add("went", true);
            dictionary.Add("to", true);
            dictionary.Add("park", true);
            dictionary.Add("in", true);
            dictionary.Add("sunshine", true);
            dictionary.Add("happy", true);
            dictionary.Add("do", true);
            dictionary.Add("sun", true);
            dictionary.Add("shine", true);
            dictionary.Add("sunny", true);
            dictionary.Add("on", true);
            dictionary.Add("a", true);
            dictionary.Add("day", true);
            String sentence = "thehappydogwenttotheparkonasunnyday";
            Console.WriteLine(sentence + " Reconstructed: " + reconstructSentence(sentence, dictionary));
        }
    }
}
