using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Morse_code_translator_encryptor

{
    public partial class Form1 : Form
    {
        Dictionary<string, String> toTranslate = new Dictionary<string, String>()// morse dictionary
        
{
    {"A" , ".-"},
    {"B" , "-..."},
    {"C" , "-.-."},
    {"D" , "-.."},
    {"E" , "."},
    {"F" , "..-."},
    {"G" , "--."},
    {"H" , "...."},
    {"I" , ".."},
    {"J" , ".---"},
    {"K" , "-.-"},
    {"L" , ".-.."},
    {"M" , "--"},
    {"N" , "-."},
    {"O" , "---"},
    {"P" , ".--."},
    {"Q" , "--.-"},
    {"R" , ".-."},
    {"S" , "..."},
    {"T" , "-"},
    {"U" , "..-"},
    {"V" , "...-"},
    {"W" , ".--"},
    {"X" , "-..-"},
    {"Y" , "-.--"},
    {"Z" , "--.."},
    {"0" , "-----"},
    {"1" , ".----"},
    {"2" , "..---"},
    {"3" , "...--"},
    {"4" , "....-"},
    {"5" , "....."},
    {"6" , "-...."},
    {"7" , "--..."},
    {"8" , "---.."},
    {"9" , "----."},
    {".", ".-.-.-"},
    {",", "--..--" },
    {" "," " },
    {"?", "· · - - · ·" },
    {"!",  "- · - · - -" },
    {"/", "- · · - ·" },
    {"&", "· ···" },
    {":", "- - - · · ·" },
    {";", "- · - · - ·" },
    {"=", "- · · · -" },
    {"-", "- · · · · -" },
    {"_", "· · - - · -" },
   





};
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userInput_TextChanged(object sender, EventArgs e)//iterate through text input to convert to morse

        {




        }




        private void encode_decode_TextChanged(object sender, EventArgs e)//invert dictionary
        {
            {

               
                
                

            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            string morseCode;
            morseCode = userInput.Text.ToUpper();


            string translated = "";
            string translatedInput = "";

            KeyPreview = true;

            if (userInput == null)
            {
                //throw a meaningful exception or give some useful feedback to the user!
                return;
            }

            for (int i = 0; i < morseCode.Length; i++)
            {
                if (i > 0)
                    Console.WriteLine('/');

                string c = morseCode[i].ToString();
                if (this.toTranslate.ContainsKey(c))

                {
                    toTranslate.TryGetValue(c, out translated);
                    translatedInput += translated + " ";
                }
            }

            encode_decode.Text = (translatedInput);




            var Dictionary2 = this.toTranslate.ToDictionary((kv) => kv.Value, (kv) => kv.Key);




            foreach (var kv in this.toTranslate)
            {
                Console.WriteLine($"Key: {kv.Key} Value: {kv.Value}");
            }

                    Console.WriteLine("Dictionary2");
                    foreach (var kv in Dictionary2)
                    {
                        Console.WriteLine($"Key: {kv.Key} Value: {kv.Value}");
                    }


        }
    }
}

    





        

    
    