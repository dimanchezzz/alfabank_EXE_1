using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfabank_EXE
{
    
    class Program
    {
        public static int bsearch(int[] array, int x)
        {     
            int value = array.Where(n => n < x).First();
            int index = Array.IndexOf(array,value);
            Console.WriteLine(index);
            return index;
        }

        static void Main(string[] args)
        { 
            int[] arr = new int[100];
            Random rand = new Random();
            for(int i = 0; i < 100; i++)
            {
                arr[i] = rand.Next(0,1000);
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            int x = 300;
            bsearch(arr, x);
        }     
    }
}
