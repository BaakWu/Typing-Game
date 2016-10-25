using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //for debugging
using System.IO; // for input and reading a CSV

namespace TypingGame
{
    public class WordDictionary
    {
        private string[] words = null; //array of words to loaded with words
        private Random rnd1 = new Random(); // random number generator to get random words
        private int numWords; //number of words in array
        public WordDictionary()
        {
            string wordFile = File.ReadAllText(@"C:\Users\AlanWongDesk\Documents\Visual Studio 2013\Projects\TypingGame\TypingGame\wordDic.csv", Encoding.UTF8); // pulls words from CSV dictionary
            words = wordFile.Split(',').Select(p => p.Trim()).ToArray(); //takes words split by commas and trims them and creates the array to store the words
            numWords = words.Length; 
           // MessageBox.Show(ShowrandomWord()); //debug test 

        }
        public string ShowrandomWord() //takes the word array and picks a random word from the array, and returns it
        {
            return words[rnd1.Next(0, numWords)]; 
        }
    }
}
