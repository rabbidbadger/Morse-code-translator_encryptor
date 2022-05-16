using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
    {" ","/" },
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




        private void encode_decode_TextChanged(object sender, EventArgs e)
        {
            {





            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
          
            string morseCode=" ";
            morseCode = userInput.Text.ToUpper();
            string translated = " ";
            string translatedInput = " ";


          



            //iterate through the letters one at a time and create new string containing morse code

            for (int i = 0; i < morseCode.Length; i++)

            {
                if (i > 0)
                    Console.WriteLine('/');

                string c = morseCode[i].ToString();
                if (this.toTranslate.ContainsKey(c))
                {
                   
                    toTranslate.TryGetValue(c, out translated);
                    translatedInput += translated + " ";
                    encode_decode.Text = (translatedInput);
                    

                }

                //{
                //    double GCD(double a, double h)

                //    {
                //        double temporary;


                //        do
                //        {
                //            for (double i = a; i <= 1; i--)
                //            {
                //                if (a % i == 0 && h % i == 0)
                //                {
                //                    double x = 0;
                //                    x = i;

                //                    return x;
                //                }
                //            }

                //            {
                //                temporary = (a % h);

                //                // Two random prime numbers for use in the key/encyption process
                //                Double p = 3;
                //                Double q = 7;

                //                // First part of public key:
                //                Double n = p * q;

                //                // Find second part of public key.
                //                // f is representative of encrypt

                //                Double f = 2;
                //                Double phi = (p - 1) * (q - 1);
                //                while (f < phi)

                //                    // f is also co-prime to phi and must be smaller than phi

                //                    if (GCD(f, phi) == 1)

                //                        break;

                //                    else

                //                        f++;

                //                // Private key where d is equal to decrypt

                //                // d*f = 1 + k * totient

                //                int k = 2; // represents a constant value
                //                Double d = (1 + (k * phi)) / f;

                //                // Message to be encrypted
                //                Double msg = 20;

                //                decoded.Text = ("Message data = %lf" + msg);

                //                // Encryption c = (msg ^ f) % n
                //                Double u = Math.Pow(msg, f);
                //                u = ((msg + f + Math.PI) % (2 * Math.PI)) - Math.PI;
                //                decoded.Text = ("\nEncrypted data = %lf" + u);

                //                // Decryption m = (u ^ d) % n
                //                Double m = Math.Pow(u, d);
                //                m = ((u + d + Math.PI) % (2 * Math.PI)) - Math.PI;
                //                decoded.Text = ("\nOriginal Message Sent = %lf" + m);

                //            }




                //        }







            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {

            string openFilename = "";
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    openFilename = openFileDialog1.FileName;
                    this.Text = openFilename;

                    //richTextBox1.Text = filename;
                    try
                    {
                        richTextBox1.Text = File.ReadAllText(openFilename);
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show("Does not compute");
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist you muppet");
                }

            }
        }

        private void translateLoadedFile_Click(object sender, EventArgs e)


        {

            string translatedLoadedFile = "";//empty string for final morse/text file
            string translatedFile = "";//empty string 
            string loadedFile = "";//empty string to be filled by loaded file
            loadedFile = richTextBox1.Text.ToUpper();

            // move through loaded file looking for key from dictionary to cast into empty string translatedFile
            for (int i = 0; i < loadedFile.Length; i++)

            {
                if (i > 0)
                    Console.WriteLine('/');

                string c = loadedFile[i].ToString();//string filled with chaaracters from loaded file
                if (this.toTranslate.ContainsKey(c))//look for key characters from dictionary 
                {
                    toTranslate.TryGetValue(c, out translatedLoadedFile);//replace characyers with key from dictionary and output to empty string
                    translatedFile += translatedLoadedFile + " ";//translatedLoadedFile is now contatinated against translatedFile


                    //transfer translated loaded file to the encode decode text output

                    encode_decode.Text = (translatedFile);
                   

                }
            }
        }


        private void translateMorse_Click(object sender, EventArgs e)
        {

            string loadedFile = "";
            loadedFile = richTextBox1.Text.ToUpper();
            string[] splitMorse = loadedFile.Split(new char[] { ' ' });//split the loaded file into individual characters(due to the morse) and allocation of where this occurs
            string converted = "";




            for (int i = 0; i < splitMorse.Length; i++)
            {
                if (i > 0)
                    Console.WriteLine('/');
                string c = splitMorse[i].ToString();
                if (this.toTranslate.ContainsValue(c))



                {


                    var Dictionary2 = this.toTranslate.ToDictionary((kv) => kv.Value, (kv) => kv.Key);




           
                    foreach (var kv in Dictionary2)

                    {
                        loadedFile += converted + "";
                        Dictionary2.TryGetValue(c, out converted);


                        {


                            encode_decode.Text = (loadedFile);
                            decoded.Text = (loadedFile);

                            break;

                        }


                    }
                }





            }

        }
    }
}

    

    







































































