using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame
{
   public class wordPerMinute
    {
        private long seconds; //amount of seconds so far
        private int words; // amount of words so far
        public wordPerMinute()
        {
            seconds = 1;
            words = 0;

        }
        public void addSeconds()
        {
            seconds++;
        }
        public void addWords()
        {
            words++ ;
        }
        public double getWPM()
        {
            return (words / (float)seconds) * 60;
        }
       public long getSeconds()
        {
           return seconds;

        }
        public int getWords()
        {
           return words;
        }
    }
}

