using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewJablonski_CPT185_Chap8
{
    public partial class Form1 : Form
    {
        string morseCode = "";
        public Form1()
        {
            InitializeComponent();
        }
        private string morse(char i)
        {
            string codeoutput = "";
            switch(i)
            {
                case ' ':
                    codeoutput = " ";
                    break;
                case ',':
                    codeoutput = "--..--";
                    break;
                case '.':
                    codeoutput = ".-.-.-";
                    break;
                case '?':
                    codeoutput = "..--..";
                    break;
                case '0':
                    codeoutput = "-----";
                    break;
                case '1':
                    codeoutput = ".----";
                    break;
                case '2':
                    codeoutput = "..---";
                    break;
                case '3':
                    codeoutput = "...--";
                    break;
                case '4':
                    codeoutput = "....-";
                    break;
                case '5':
                    codeoutput = ".....";
                    break;
                case '6':
                    codeoutput = "-....";
                    break;
                case '7':
                    codeoutput = "--...";
                    break;
                case '8':
                    codeoutput = "---..";
                    break;
                case '9':
                    codeoutput = "----.";
                    break;
                case 'A':
                    codeoutput = ".-";
                    break;
                case 'B':
                    codeoutput = "-...";
                    break;
                case 'C':
                    codeoutput = "-.-.";
                    break;
                case 'D':
                    codeoutput = "-..";
                    break;
                case 'E':
                    codeoutput = ".";
                    break;
                case 'F':
                    codeoutput = "..-.";
                    break;
                case 'G':
                    codeoutput = "--.";
                    break;
                case 'H':
                    codeoutput = "....";
                    break;
                case 'I':
                    codeoutput = "..";
                    break;
                case 'J':
                    codeoutput = ".---";
                    break;
                case 'K':
                    codeoutput = "-.-";
                    break;
                case 'L':
                    codeoutput = ".-..";
                    break;
                case 'M':
                    codeoutput = "---";
                    break;
                case 'N':
                    codeoutput = "-.";
                    break;
                case 'O':
                    codeoutput = "---";
                    break;
                case 'P':
                    codeoutput = ".--.";
                    break;
                case 'Q':
                    codeoutput = "--.-";
                    break;
                case 'R':
                    codeoutput = ".-.";
                    break;
                case 'S':
                    codeoutput = "...";
                    break;
                case 'T':
                    codeoutput = "-";
                    break;
                case 'U':
                    codeoutput = "..-";
                    break;
                case 'V':
                    codeoutput = "...-";
                    break;
                case 'W':
                    codeoutput = ".--";
                    break;
                case 'X':
                    codeoutput = "-..-";
                    break;
                case 'Y':
                    codeoutput = "-.--";
                    break;
                case 'Z':
                    codeoutput = "--..";
                    break;
            }

            return codeoutput;
        }
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userInput = usrInputTextBox.Text;
                userInput = userInput.ToUpper();

                for (int i = 0; i < userInput.Length; i++)
                {
                    morseCode += morse(userInput[i]);
                }
                morseOutputLabel.Text = morseCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Form1 blankExamForm = new Form1();
            blankExamForm.Show();
            this.Dispose(false);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
