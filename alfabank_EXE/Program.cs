﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfabank_EXE
{
    
    class Program
    {
        public static int? bsearch(int[] array, int x)
        {
          try
            {
                IEnumerable<int> ivalue = array.Where(n => n < x);
                if(ivalue.Count()==0)
                {
                    return null;
                }
                else
                {
                    int value = ivalue.First();
                    int index = Array.IndexOf(array, value);
                    return index;
                }
            } 
            catch (Exception ex)
            {
                throw (ex);
            }   
                     
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
