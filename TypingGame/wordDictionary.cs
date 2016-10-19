using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //for debugging
using System.IO; // for input and reading a CSV

namespace TypingGame
{
    class WordDictionary
    {
        private string[] words = null; //array of words to loaded with words
        Random rnd1 = new Random(); // random number generator to get random words
        int numWords;
        public WordDictionary()
        {


            string wordFile = File.ReadAllText(@"C:\Users\AlanWongDesk\Documents\Visual Studio 2013\Projects\TypingGame\TypingGame\wordDic.csv", Encoding.UTF8);
            words = wordFile.Split(',');
            numWords = words.Length;
            MessageBox.Show(ShowrandomWord());

        }
        public string ShowrandomWord() //takes the word array and picks a random word from the array, and returns it
        {
            return words[rnd1.Next(0, numWords)];
        }
    }
}
