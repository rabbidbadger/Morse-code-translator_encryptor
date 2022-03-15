using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_code_translator_encryptor
{
    public partial class Form1 : Form
    {
        Dictionary<char, String> MorseCode = new Dictionary<char, String>()
{
    {'A' , ".-"},
    {'B' , "-..."},
    {'C' , "-.-."},
    {'D' , "-.."},
    {'E' , "."},
    {'F' , "..-."},
    {'G' , "--."},
    {'H' , "...."},
    {'I' , ".."},
    {'J' , ".---"},
    {'K' , "-.-"},
    {'L' , ".-.."},
    {'M' , "--"},
    {'N' , "-."},
    {'O' , "---"},
    {'P' , ".--."},
    {'Q' , "--.-"},
    {'R' , ".-."},
    {'S' , "..."},
    {'T' , "-"},
    {'U' , "..-"},
    {'V' , "...-"},
    {'W' , ".--"},
    {'X' , "-..-"},
    {'Y' , "-.--"},
    {'Z' , "--.."},
    {'0' , "-----"},
    {'1' , ".----"},
    {'2' , "..---"},
    {'3' , "...--"},
    {'4' , "....-"},
    {'5' , "....."},
    {'6' , "-...."},
    {'7' , "--..."},
    {'8' , "---.."},
    {'9' , "----."},
    {'.', ".-.-.-"},
    {',', "--..--" },
    {' '," " },
    {'?', "· · - - · ·" },
    {'!',  "- · - · - -" },
    {'/', "- · · - ·" },
    {'&', "· ···" },
    {':', "- - - · · ·" },
    {';', "- · - · - ·" },
    {'=', "- · · · -" },
    {'-', "- · · · · -" },
    {'_', "· · - - · -" },
    {'"', "· - · · - ·" },



/*  */
};
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            String userInput = Console.ReadLine();

            

            }

            private void encode_decode_TextChanged(object sender, EventArgs e)

            {



                {
                    Console.WriteLine();
                }
            }

            private void button1_Click(object sender, EventArgs e)

            {
            userInput = Console.ReadLine();
                

                    for (int i = 0; i < userInput.Length; i++)
                    {
                        if (i > 0)
                            Console.Write('/');

                        char c = userInput[i];
                        if (MorseCode.ContainsKey(c))
                            Console.Write(MorseCode);
                    }

                }





            }
        }
    }