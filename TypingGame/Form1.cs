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

        public typingTest(WordDictionary source) //constructor that requires the word dictionary
        {
            wordDic = source;
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

            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }

}

