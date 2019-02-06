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

            int check = 1;
            while (check == 1)
            {
                Console.WriteLine("Please Enter The Text To Be Encrypte OR Decrypte");

                string text = Console.ReadLine();
                int coounter = 0;
                string f_text = "";
                for (int i = 0; i < text.Length; i++)
                {

                    if (text[i] >= 'A' && text[i] <= 'Z')
                    {


                        for (int c = 65; c <= 90; c++)
                        {
                            coounter++;

                            if (text[i] == 32)
                            {
                                coounter = 32;
                                break;
                            }
                            else
                            {
                                if (text[i] == c)
                                {

                                    coounter = 91 - coounter;
                                    break;

                                }

                            }



                        }
                    }

                    else
                    {
                        for (int c = 97; c <= 122; c++)
                        {
                            coounter++;

                            if (text[i] == 32)
                            {
                                coounter = 32;
                                break;
                            }
                            else
                            {
                                if (text[i] == c)
                                {
                                    coounter = 123 - coounter;
                                    break;

                                }
                            }




                        }

                    }

                    f_text += Convert.ToChar(((coounter)));
                    coounter = 0;

                }
                Console.WriteLine(f_text);
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Write 1 To Encryote OR Decrypte Another Text Or 0 To Exit  ");

                check =int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");

            }
        }
    }
}
