using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trre
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeExampleSearch();
            Console.ReadLine();
        }

        private static void DichotomousSearch()
        {
            var rand = new Random();
            var array = new List<int>();
            for (int i = 0; i < 5000; i++)
            {
                array.Add(rand.Next(0, 10000));
            }
            array.Add(1997);
            array.Sort();
            while (true)
            {
                Console.WriteLine("Saisir la valeur à chercher:");
                var x = int.Parse(Console.ReadLine());

                var indIn = 0;
                var indSup = 5000;
                do
                {
                    if (x == array[(indSup + indIn) / 2])
                    {
                        Console.Write((indSup + indIn) / 2);
                        break;
                    }
                    else
                    {
                        if (x > array[(indSup + indIn) / 2])
                        {
                            indIn = ((indSup + indIn) / 2) + 1;
                        }
                        else
                        {
                            indSup = ((indSup + indIn) / 2) - 1;
                        }
                    }
                }
                while (indSup != indIn && x != array[(indSup + indIn) / 2]);

                if (indSup == indIn && array[indIn] != x)
                {
                    Console.WriteLine("Item not found in the array");
                }
                else
                {
                    Console.WriteLine($"Item found in the array in the position {(indSup + indIn) / 2}");
                }
            }
        }

        private static void TreeExampleSearch()
        {
            //var n = new Node
            //{
            //    value = 100,
            //    right = new Node
            //    {
            //        value = 110,
            //        right = new Node
            //        {
            //            value = 120,
            //            right = new Node
            //            {
            //                value = 121,


            //            },
            //            left = new Node
            //            {
            //                value = 111,
            //            }

            //        },
            //        left = new Node
            //        {
            //            value = 101,
            //            right = new Node
            //            {
            //                value = 105,


            //            },
            //            left = new Node
            //            {
            //                value = 99,
            //            }

            //        },


            //    },
            //    left = new Node
            //    {
            //        value = 90,
            //        right = new Node
            //        {
            //            value = 95,

            //            right = new Node
            //            {
            //                value = 96,
            //                left = new Node
            //                {
            //                    value = 93,
            //                },
            //                right = new Node
            //                {
            //                    value = 97,
            //                }

            //            },
            //            left = new Node
            //            {
            //                value = 94,
            //                left = new Node
            //                {
            //                    value = 92,
            //                }
            //            }
            //        },
            //        left = new Node
            //        {
            //            value = 85,
            //            right = new Node
            //            {
            //                value = 86,
            //                right = new Node
            //                {
            //                    value = 88,
            //                },
            //                left = new Node
            //                {
            //                    value = 87,
            //                }
            //            },
            //            left = new Node
            //            {
            //                value = 80,
            //                right = new Node
            //                {
            //                    value = 84,
            //                },

            //                left = new Node
            //                {
            //                    value = 75,

            //                    left = new Node
            //                    {
            //                        value = 70,
            //                    },
            //                    right = new Node
            //                    {
            //                        value = 76,
            //                    }
            //                }



            //            }
            //        }
            //    }
            //};

            var n = new Node
            {
                value = 1000
            };
            var rand = new Random();
            for(int i = 0; i<5000; i++)
            {
                n.Add(rand.Next(0, 200000));
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the value to search:");
                    var valueToSearch = int.Parse(Console.ReadLine());
                    var x = n.Find(valueToSearch);
                    Console.WriteLine(x == null ? "not found" : "Found");
                }
                catch
                {
                }
            }
        }

        private static long FibonacciRecusrsion(int ln)
        {
            if (ln == 0)
                return 0;
            else
            if (ln == 1)
                return 1;
            else
                return (FibonacciRecusrsion(ln - 1) + FibonacciRecusrsion(ln - 2));
        }

        private static long FibonacciAlgo(int ln)
        {
            long a = 0;
            long b = 1;
            long suit = 0;
            for (int i = 0; i < ln; i++)
            {
                var tmp = a;
                suit = a + b;
                a += b;
                b = tmp;
            }
            return suit;
        }
    }
}