using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input_prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the character: ");
            char user;
            user = Convert.ToChar(Console.ReadLine());

            switch (user)
            {
                case 'A':
                    
                        for (int col = 1; col <= 5; col++) 
                    {
                            for (int row = 1; row <= 3; row++) 
                        {
                                if (row == 1 && col == 3)
                            {
                                    Console.Write("*");
                                } 
                            else 
                            {
                                    Console.Write(" ");
                                }
                                if (row == 2 && (col == 2 || col == 3||col==4))
                                    { 
                                Console.Write("*"); 
                            } 
                            else
                                { 
                                Console.Write(" "); 
                            }
                                if (row == 3 && (col == 1 || col == 5))
                            {
                                    Console.Write("*");
                                } 
                            else
                            { 
                                Console.Write(" ");
                            }


                            }
                            Console.WriteLine();
                        }
                        break;


                        case 'N':
                            for (int col = 1; col <= 4; col++) {
                                for (int row = 1; row <= 4; row++)
                                {
                                    if (col == 1 && (row == 1 || row == 2 || row == 3 || row == 4)) {
                                        Console.Write("*");
                                    } else { Console.Write(" "); }
                                    if (col == 4 && (row == 1 || row == 2 || row == 3 || row == 4))
                                    {
                                        Console.Write("*");
                                    }
                                    else { Console.Write(" "); }
                                    if (col == 2 && row == 2)
                                    { Console.Write("*"); }
                                    else { Console.Write(" "); }
                                    if (col == 3 && row == 2)
                                    {
                                        Console.Write("*");
                                    } else
                                    { Console.Write(" "); }

                                    
                                    }
                        Console.WriteLine();
                            }
                    break;
                    
            }
            Console.Read();
        }
        }
    }

