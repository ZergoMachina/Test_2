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
        //static int[] createArray(int size)
        //{
        //    int[] myArray = new int[size];
        //    Random randomElem = new Random();
        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        myArray[i] = randomElem.Next(0, 2);
        //    }
        //    return myArray;
        //}
        //static int[] deleteElement(ref int[] array)
        //{
        //    Random randomElem = new Random();
        //    int[] newArray = new int[array.Length - 1];
        //    int delete = randomElem.Next(0, (array.Length - 1));
        //    if (delete == 0)
        //    {
        //        Array.Copy(array, 1, newArray, 0, newArray.Length);
        //    }
        //    else if (delete == array.Length-1)
        //    {
        //        Array.Copy(array, 0, newArray, 0, newArray.Length);
        //    }
        //    else
        //    {
        //        Array.Copy(array, 0, newArray, 0, delete);
        //        Array.Copy(array, delete + 1, newArray, delete, newArray.Length-delete);
        //    }
        //    return newArray;
        //}
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
            int sum1 = 0;
            int sum2 = 0;
            int countZero = 0;
            int beginnew = 0;
            int beginnew2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                {
                    count++;
                }
                if (array.Length > 2)
                {
                    if ((array[i] == 0 && array[i - 1] == 0))
                    {
                        countZero = 0;
                        count = 0;
                    }
                    if ((array[i] == 0 && count > 0 && array[i - 1] != 0) || (i == array.Length - 1))
                    {
                        countZero++;
                        if (countZero == 1)
                        {
                            beginnew = count;
                            if (i == array.Length - 1)
                            {
                                return sum1;
                            }
                            count = 0;
                        }
                        if (countZero > 1 || i == array.Length - 1)
                        {
                            countZero = 1;
                            beginnew2 = beginnew;
                            beginnew = count;
                            sum2 = sum1;
                            sum1 = beginnew + beginnew2;
                            if (sum1 < sum2)
                            {
                                sum1 = sum2;
                            }
                            if (i != array.Length - 1)
                            {
                                count = 0;
                            }
                        }
                        
                    }
                }
                else if (count > 0)
                {
                    sum1 = count;
                }
                if (count == array.Length)
                {
                    count--;
                    sum1 = count;
                }
            }
            return sum1;
        }
        static void Main(string[] args)
        {
            Random randomSize = new Random();
            int[] testArray1 = { 0, 1 };
            int[] testArray2 = { 1, 1 };
            int[] testArray3 = { 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1 };
            int[] testArray4 = { 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1};
            int[] testArray5 = { 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
            //int[] array = createArray(randomSize.Next(2, 20));
            //int[] newarray = deleteElement(ref array);
            
            //PrintArray(array);
            PrintArray(testArray2);
            Console.WriteLine(Counting(testArray2));
        }
    }
}
