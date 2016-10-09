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
        public typingTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e) //do something when the enter key is pressed
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            
           // 
            //if (typeThis.Text == inputBox.Text)
            if (typeThis.Text.StartsWith(inputBox.Text))
            {
                mistakeTag.Visible = false;

            }
            else
            {
                mistakeTag.Visible = true;
            }
        }

    }

}

