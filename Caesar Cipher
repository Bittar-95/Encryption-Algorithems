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
            Console.WriteLine("PLease Enter 'E' For Encryption 'D' For Decryption");
            char type = char.Parse(Console.ReadLine().ToUpper());
            int loop = 1;
            while (loop == 1)
            {
                string text;
                int key;
                if (type == 'E')
                {

                    Console.WriteLine("Please Enter The Text To Be Encrypte");
                    text = Console.ReadLine().ToUpper();
                    Console.WriteLine("Plaese Enter The Key The Key Should Be Between [ 26 To -26]");
                    key = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Please Enter Encrypted Text");
                    text = Console.ReadLine().ToUpper();
                    Console.WriteLine("Please enter the encryption key");
                    key = int.Parse(Console.ReadLine());
                }

                string encrypted_text = "";

                int ascii;

                for (int i = 0; i < text.Length; i++)
                {
                    if (type == 'E')
                    {
                        ascii = text[i] + key;
                        if (key > 0)
                        {


                            if (ascii > 90)
                            {
                                ascii = ascii - 90;
                                ascii = ascii + 64;

                            }
                        }
                        else
                        {
                            if (ascii < 65)
                            {
                                ascii = ascii - 65;
                                ascii = ascii + 91;
                            }
                        }
                    }


                    else
                    {
                        ascii = text[i] - key;
                        if (key > 0)
                        {


                            if (ascii < 65)
                            {
                                ascii = ascii - 65;
                                ascii = ascii + 91;
                          

                            }
                        }
                        else
                        {
                            if (ascii > 90)
                            {
                                ascii = ascii - 90;
                                ascii = ascii + 64;
                            }
                        }
                    }

                
                    encrypted_text += Convert.ToChar(ascii);
                }
                if (type == 'E')
                {
                    Console.WriteLine("The Enctypted Text Is :[ {0} ]", encrypted_text);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.Write("Write 1 To Encrypte Another Text Or 0 To Exit  ");
                    loop = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("The Decrypted Text Is :[ {0} ]", encrypted_text);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.Write("Write 1 To Decrypte Another Text Or 0 To Exit  ");
                    loop = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------------------------");

                }
   


            }
        }
    }
}
