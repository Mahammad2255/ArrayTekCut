using System;
using System.Collections;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0, n;


            

            Console.Write("Arrayin nece elementden ibaret olacagini daxil edin:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Arraye {0} element daxin edin :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nArrayde olan cut elementler : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nArrayda olan tek elementler\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
        }

    }
    }


