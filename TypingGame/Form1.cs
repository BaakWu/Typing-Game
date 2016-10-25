using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class typingTest : Form
    {
        WordDictionary wordDic; // word dictionary object used in the UI
        wordPerMinute wpm;
        public typingTest(WordDictionary source, wordPerMinute source2) //constructor that requires the word dictionary
        {
            wordDic = source;
            wpm = source2;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeThis.Text = wordDic.ShowrandomWord();

        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e) //do something when the enter key is pressed
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            
           // 
            //if (typeThis.Text == inputBox.Text)
            if (typeThis.Text.StartsWith(inputBox.Text, StringComparison.CurrentCultureIgnoreCase)) //pops error prompt if typing is wrong
            {
                mistakeTag.Visible = false;

            }
            else
            {
                mistakeTag.Visible = true;
            }

            if (String.Equals(typeThis.Text, inputBox.Text, StringComparison.CurrentCultureIgnoreCase)) //compares the type text and the input insensitively and if true puts out a new word
            {
                typeThis.Text = wordDic.ShowrandomWord();
                inputBox.Text = null;

                timer1.Enabled = true;
                wpm.addWords();

            }
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
           // MessageBox.Show( wpm.getWPM().ToString();
            wpm.addSeconds();
            wpmLabel.Text = wpm.getWPM().ToString();
        }

    }

}

