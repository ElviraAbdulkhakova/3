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
            string[,] FLNames = new string[10, 2];
            string[] LastName = new string[10] {"Ivanov", "Petrov", "Sidorov", "Smirnov", "Fedorov", "Alekseev", "Kovalev", "Mamontov", "Kiselev", "Trankov" };
            //fill array by empty string 
            for (int i = 0; i < FLNames.GetLength(0); i++)
            {
                for (int j = 0; j < FLNames.GetLength(1); j++ ) 
                    FLNames[i,j]="";
            }

            //fill Last names
            for (int i = 0; i < FLNames.GetLength(0); i++)
            {
                FLNames[i, 0] = LastName[i];   
            }

            string res; 
         
            do 
            {
                Console.WriteLine("\nEnter action:\n- type \"fill\" to initialize elements;\n- type\"sort Family\" to sort array by last name;\n- type \"sort Name\" to sort array by first name;\n- type \"print\" to see all elements;\n- type \"help\" to repeat list of available actions;\n- type \"exit\" to quit.\n");
                res = Console.ReadLine();
                if (res.Equals("print"))
                {
                    Console.WriteLine();
                    for (int i = 0; i < FLNames.GetLength(0); i++)
                    {
                        for (int j = 0; j < FLNames.GetLength(1); j++)
                        {
                            Console.Write("{0} ", FLNames[i, j]);
                        }
                        Console.WriteLine();
                    }
                    continue;
                }

                else if (res.Equals("sort Family"))
                {
                    Array.Sort(LastName);
                    for (int i = 0; i < FLNames.GetLength(0);i++ )
                    {

                        for (int j = 0; j < LastName.Length;j++ )
                        {
                            if (FLNames[i, 0].Equals(LastName[j]))
                            {
                                temp0 = FLNames[i, 0];
                                temp1 = FLNames[i, 1];
                                FLNames[i, 0] = FLNames[j, 0];
                                FLNames[i, 1] = FLNames[j, 1];
                                FLNames[j, 0] = temp0;
                                FLNames[j, 1] = temp1;
                            }
                        }  
                    }
                    Console.WriteLine("Array sorted by last names successufully");
                    continue;
                }

                else if (res.Equals("sort Name"))
                {
                    string[] FirstName = new string[10];
                    for (int i = 0; i < FirstName.Length; i++)
                        FirstName[i] = FLNames[i, 1];
                    Array.Sort(FirstName);
                    for (int i = 0; i < FLNames.GetLength(0); i++)
                    {

                        for (int j = 0; j < FirstName.Length; j++)
                        {
                            if (FLNames[i, 1].Equals(FirstName[j]))
                            {
                                temp0 = FLNames[i, 0];
                                temp1 = FLNames[i, 1];
                                FLNames[i, 0] = FLNames[j, 0];
                                FLNames[i, 1] = FLNames[j, 1];
                                FLNames[j, 0] = temp0;
                                FLNames[j, 1] = temp1;
                            }

                        }

                    }
                    Console.WriteLine("Array sorted by first names successufully");
                    continue;
                }

                else if (res.Equals("fill"))
                {
                    Console.WriteLine("\nChoose a number:\n");
                    for (int i = 0; i < FLNames.GetLength(0); i++)
                    {
                        Console.Write("{0} - ", i);
                        for (int j = 0; j < FLNames.GetLength(1); j++)
                        {
                            Console.Write("{0} ", FLNames[i, j]);
                        }
                        Console.WriteLine();
                    }
                    int number;
                    Console.WriteLine();
                    string row = Console.ReadLine();
                    if (int.TryParse(row, out number))
                    {
                        if ((number >= 0) && (number <= FLNames.GetLength(0) - 1))
                        {
                            Console.WriteLine("\nYou choise is \"{0}\"\n\nEnter \"1\" to change first name, \"2\" - to change last name\n", FLNames[number, 0]);
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
                                            FLNames[number, 1] = name;
                                            Console.WriteLine("\nAfter changes {0} element of array is {1} {2}", number, FLNames[number, 0], FLNames[number, 1]);
                                            break;
                                        };
                                    case 2:
                                        {
                                            Console.Write("\nEnter new last name: ");
                                            string lastname = Console.ReadLine();
                                            FLNames[number, 0] = lastname;
                                            Console.WriteLine("\nAfter changes {0} element of array is {1} {2}", number, FLNames[number, 0], FLNames[number, 1]);
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
                    continue;
                }

                else if (res.Equals("help"))
                {
                   /* Console.WriteLine("\nEnter action:\n- type \"fill\" to initialize elements;\n- type\"sort Family\" to sort array by last name;\n- type \"sort Name\" to sort array by first name;\n- type \"print\" to see all elements;\n- type \"help\" to see list of available actions;\n- type \"exit\" to quit.\n");*/
                    continue;
                }

                else if (res.Equals("exit")) 
                {
                    continue;
                }

                else
                    Console.WriteLine("\nYou entered incorrect action");
                    continue;

            }
            while (!(res.Equals("exit")));          
        
        }
    }
}
