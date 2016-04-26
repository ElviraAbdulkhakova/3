using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons3_4
{
    class Program
    {
                static void Main(string[] args)
        {
            //FLNames contains set of pair: first name and last name
            string temp0, temp1;
            string[,] flnames = new string[10, 2];
            string[] lastname = new string[10] {"Ivanov", "Petrov", "Sidorov", "Smirnov", "Fedorov", "Alekseev", "Kovalev", "Mamontov", "Kiselev", "Trankov" };
            //fill array by empty string 
            for (int i = 0; i < flnames.GetLength(0); i++)
            {
                for (int j = 0; j < flnames.GetLength(1); j++)
                    flnames[i, j] = "";
            }

            //fill Last names
            for (int i = 0; i < flnames.GetLength(0); i++)
            {
                flnames[i, 0] = lastname[i];   
            }

            string res; 
         
            do 
            {
                Console.WriteLine("\nEnter action:\n- type \"fill\" to initialize elements;\n- type\"sort Family\" to sort array by last name;\n- type \"sort Name\" to sort array by first name;\n- type \"print\" to see all elements;\n- type \"help\" to repeat list of available actions;\n- type \"exit\" to quit.\n");
                res = Console.ReadLine();
                switch (res)
                {
                    case "print":
                        {
                            Console.WriteLine();
                            for (int i = 0; i < flnames.GetLength(0); i++)
                            {
                                for (int j = 0; j < flnames.GetLength(1); j++)
                                {
                                    Console.Write("{0} ", flnames[i, j]);
                                }
                                Console.WriteLine();
                            }
                            break;
                        }

                    case "sort Family":
                        {
                            Array.Sort(lastname);
                            for (int i = 0; i < flnames.GetLength(0); i++)
                            {

                                for (int j = 0; j < lastname.Length; j++)
                                {
                                    if (flnames[i, 0].Equals(lastname[j]))
                                    {
                                        temp0 = flnames[i, 0];
                                        temp1 = flnames[i, 1];
                                        flnames[i, 0] = flnames[j, 0];
                                        flnames[i, 1] = flnames[j, 1];
                                        flnames[j, 0] = temp0;
                                        flnames[j, 1] = temp1;
                                    }
                                }
                            }
                            Console.WriteLine("Array sorted by last names successufully");
                            break;
                        }

                    case "sort Name":
                        {
                            string[] firstname = new string[10];
                            for (int i = 0; i < firstname.Length; i++)
                                firstname[i] = flnames[i, 1];
                            Array.Sort(firstname);
                            for (int i = 0; i < flnames.GetLength(0); i++)
                            {

                                for (int j = 0; j < firstname.Length; j++)
                                {
                                    if (flnames[i, 1].Equals(firstname[j]))
                                    {
                                        temp0 = flnames[i, 0];
                                        temp1 = flnames[i, 1];
                                        flnames[i, 0] = flnames[j, 0];
                                        flnames[i, 1] = flnames[j, 1];
                                        flnames[j, 0] = temp0;
                                        flnames[j, 1] = temp1;
                                    }

                                }

                            }
                            Console.WriteLine("Array sorted by first names successufully");
                            break;
                        }

                    case "fill":
                        {
                            Console.WriteLine("\nChoose a number:\n");
                            for (int i = 0; i < flnames.GetLength(0); i++)
                            {
                                Console.Write("{0} - ", i);
                                for (int j = 0; j < flnames.GetLength(1); j++)
                                {
                                    Console.Write("{0} ", flnames[i, j]);
                                }
                                Console.WriteLine();
                            }
                            int number;
                            Console.WriteLine();
                            string row = Console.ReadLine();
                            if (int.TryParse(row, out number))
                            {
                                if ((number >= 0) && (number <= flnames.GetLength(0) - 1))
                                {
                                    Console.WriteLine("\nYou choise is \"{0}\"\n\nEnter \"1\" to change first name, \"2\" - to change last name\n", flnames[number, 0]);
                                    int x;
                                    string choise = Console.ReadLine();
                                    if (int.TryParse(choise, out x))
                                    {
                                        switch (x)
                                        {
                                            case 1:
                                                {
                                                    Console.Write("\nEnter new first name: ");
                                                    string name = Console.ReadLine();
                                                    flnames[number, 1] = name;
                                                    Console.WriteLine("\nAfter changes {0} element of array is {1} {2}", number, flnames[number, 0], flnames[number, 1]);
                                                    break;
                                                };
                                            case 2:
                                                {
                                                    Console.Write("\nEnter new last name: ");
                                                    string lastname_new = Console.ReadLine();
                                                    flnames[number, 0] = lastname_new;
                                                    Console.WriteLine("\nAfter changes {0} element of array is {1} {2}", number, flnames[number, 0], flnames[number, 1]);
                                                    break;
                                                };
                                            default:
                                                {
                                                    Console.WriteLine("\nYou entered incorrect number");
                                                    break;
                                                }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nYou need to choise number");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nNumber is out of range");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nYou need to choise number");
                            }
                            break;
                        }

                    case "help":
                        {
                            /* Console.WriteLine("\nEnter action:\n- type \"fill\" to initialize elements;\n- type\"sort Family\" to sort array by last name;\n- type \"sort Name\" to sort array by first name;\n- type \"print\" to see all elements;\n- type \"help\" to see list of available actions;\n- type \"exit\" to quit.\n");*/
                            break;
                        }

                    case "exit":
                        {
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nYou entered incorrect action");
                            break;
                        }

                }
    
            }
            while (!(res.Equals("exit")));          
        
        }
    }
}
