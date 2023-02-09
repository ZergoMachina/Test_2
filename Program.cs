using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_2
{
    internal class Program
    {
        static int[] createArray(int size)
        {
            int[] myArray = new int[size];
            Random randomElem = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomElem.Next(0, 2);
            }
            return myArray;
        }
        static int[] deleteElement(ref int[] array)
        {
            Random randomElem = new Random();
            int[] newArray = new int[array.Length - 1];
            int delete = randomElem.Next(0, (array.Length - 1));
            if (delete == 0)
            {
                Array.Copy(array, 1, newArray, 0, newArray.Length);
            }
            else if (delete == array.Length-1)
            {
                Array.Copy(array, 0, newArray, 0, newArray.Length);
            }
            else
            {
                Array.Copy(array, 0, newArray, 0, delete);
                Array.Copy(array, delete + 1, newArray, delete, newArray.Length-delete);
            }
            return newArray;
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        static int Counting(int[] array)
        {
            int count = 0;
            int count2 = 0;
            int count0 = array.Length - 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == 1)
                {
                    count = 0;
                    count++;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] == 1)
                        {
                            count++;
                        }
                        else
                        {
                            i = j - 1;
                            break;
                        }

                    }
                    if (count > count2)
                    {
                        count2 = count;
                    }
                    else count = count2;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Random randomSize = new Random();
            int[] array = createArray(randomSize.Next(2, 20));
            int[] newarray = deleteElement(ref array);
            
            PrintArray(array);
            PrintArray(newarray);
            Console.WriteLine(Counting(newarray));
        }
    }
}
