using System;
using System.Collections.Generic;
using System.Text;

namespace Delegater01
{
    public static class Utilities
    {

        public static T[] SortGenArray<T>(this T[] arr, Func<T,T,bool> func)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                
                    if (func(arr[j], arr[minIndex]))
                    {
                        minIndex = j;
                    }
                    T temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                   
            }
            return arr;
        }

        public static void SortArray(int[] intArr)
        {
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < intArr.Length; j++)
                
                    if (intArr[j] < intArr[minIndex])
                    
                        minIndex = j;
                    
                    int temp = intArr[i];
                    intArr[i] = intArr[minIndex];
                    intArr[minIndex] = temp;
                
            }
        }

        public static void SortIntArray(int[] intArr)
        {
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < intArr.Length; j++)
                    if (intArr[j] < intArr[minIndex])
                        minIndex = j;
                int tmp = intArr[i];
                intArr[i] = intArr[minIndex];
                intArr[minIndex] = tmp;
            }
        }

    }   
}
