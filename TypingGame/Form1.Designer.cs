namespace TypingGame
{
    partial class typingTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpLabel = new System.Windows.Forms.Label();
            this.wpmLabel = new System.Windows.Forms.Label();
            this.typeThis = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.wpmCounter = new System.Windows.Forms.Label();
            this.mistakeTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(82, 76);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(110, 13);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "Type the word Below!";
            // 
            // wpmLabel
            // 
            this.wpmLabel.AutoSize = true;
            this.wpmLabel.Location = new System.Drawing.Point(120, 233);
            this.wpmLabel.Name = "wpmLabel";
            this.wpmLabel.Size = new System.Drawing.Size(34, 13);
            this.wpmLabel.TabIndex = 1;
            this.wpmLabel.Text = "WPM";
            // 
            // typeThis
            // 
            this.typeThis.AutoSize = true;
            this.typeThis.Location = new System.Drawing.Point(120, 117);
            this.typeThis.Name = "typeThis";
            this.typeThis.Size = new System.Drawing.Size(35, 13);
            this.typeThis.TabIndex = 2;
            this.typeThis.Text = "label2";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(37, 174);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(209, 20);
            this.inputBox.TabIndex = 3;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // wpmCounter
            // 
            this.wpmCounter.AutoSize = true;
            this.wpmCounter.Location = new System.Drawing.Point(120, 272);
            this.wpmCounter.Name = "wpmCounter";
            this.wpmCounter.Size = new System.Drawing.Size(34, 13);
            this.wpmCounter.TabIndex = 4;
            this.wpmCounter.Text = "WPM";
            // 
            // mistakeTag
            // 
            this.mistakeTag.AutoSize = true;
            this.mistakeTag.ForeColor = System.Drawing.Color.Red;
            this.mistakeTag.Location = new System.Drawing.Point(95, 197);
            this.mistakeTag.Name = "mistakeTag";
            this.mistakeTag.Size = new System.Drawing.Size(97, 13);
            this.mistakeTag.TabIndex = 5;
            this.mistakeTag.Text = "There is a Mistake!";
            this.mistakeTag.Visible = false;
            // 
            // typingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 355);
            this.Controls.Add(this.mistakeTag);
            this.Controls.Add(this.wpmCounter);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.typeThis);
            this.Controls.Add(this.wpmLabel);
            this.Controls.Add(this.helpLabel);
            this.Name = "typingTest";
            this.Text = "Typing Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label wpmLabel;
        private System.Windows.Forms.Label typeThis;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label wpmCounter;
        private System.Windows.Forms.Label mistakeTag;
    }
}

