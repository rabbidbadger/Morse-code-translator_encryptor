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
        Dictionary<char, String> MorseCode = new Dictionary<char, String>()// morse dictionary
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
            String toTranslate = Console.ReadLine();

            if (toTranslate == null)
            {
                //throw a meaningful exception or give some useful feedback to the user!
                return;
            }

            for (int i = 0; i < toTranslate.Length; i++)
            {
                if (i > 0)
                    Console.Write('/');

                char c = toTranslate[i];
                if (MorseCode.ContainsKey(c))
                    Console.Write(MorseCode);
            }

            Console.WriteLine();

        }




        private void encode_decode_TextChanged(object sender, EventArgs e)//invert dictionary
        {
            Console.WriteLine(MorseCode);
        }



        private void Button1_Click(object sender, EventArgs e)

        {

            {


                    var Dictionary2 = MorseCode.ToDictionary((kv) => kv.Value, (kv) => kv.Key);
                    


                    Console.WriteLine("MorseCode");

                    foreach (var kv in MorseCode)
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
    





        }

    
    