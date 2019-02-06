using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secutiry
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 1;
            while (loop == 1)
            {
                Console.WriteLine("PLease Enter 'E' For Encryption 'D' For Decryption");
                char type = char.Parse(Console.ReadLine().ToUpper());

                string text;
                int key;
                string text_processing = "";
                int ascii;

                if (type == 'E')
                {
                    Console.WriteLine("Please Enter The Text To Be Encrypte");
                    text = Console.ReadLine().ToUpper();
                    Console.WriteLine("Plaese Enter The Key The Key Should Be Between [ 26 To -26]");
                    key = int.Parse(Console.ReadLine());

                    for (int i = 0; i < text.Length; i++)
                    {

                        ascii = text[i] + key;
                        if (key > 0 && ascii > 90)
                        {
                            ascii = ascii - 90;
                            ascii = ascii + 64;
                        }
                        else
                        {
                            if (ascii < 65)
                            {
                                ascii = ascii - 65;
                                ascii = ascii + 91;
                            }
                        }
                        text_processing += Convert.ToChar(ascii);
                    }

                    Console.WriteLine("The Enctypted Text Is :[ {0} ]", text_processing);
                    Console.WriteLine("---------------------------------------------------------------");

                }

                else
                {
                    Console.WriteLine("Please Enter Encrypted Text");
                    text = Console.ReadLine().ToUpper();
                    Console.WriteLine("Please enter the encryption key");
                    key = int.Parse(Console.ReadLine());


                    for (int i = 0; i < text.Length; i++)

                    {
                        ascii = text[i] - key;
                        if (key > 0 && ascii < 65)
                        {
                            ascii = ascii - 65;
                            ascii = ascii + 91;

                        }
                        else
                        {
                            if (ascii > 90)
                            {
                                ascii = ascii - 90;
                                ascii = ascii + 64;
                            }
                        }
                        text_processing += Convert.ToChar(ascii);
                    }

                    Console.WriteLine("The Decrypted Text Is :[ {0} ]", text_processing);
                    Console.WriteLine("---------------------------------------------------------------");



                }
                Console.Write("Write 1 To Encryote OR Decrypte Another Text Or 0 To Exit  ");
                loop = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------");

            }


        }
    }
}
