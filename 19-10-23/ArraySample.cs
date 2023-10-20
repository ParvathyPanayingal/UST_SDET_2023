using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ArraySample
    {
        //int[] numbers = { 10, 20, 30 }; //when we know the exact elements
        // int[] numbers= new int[5]; //when we don't know the elements we mention the size
        readonly int[] numbers=new int[5];
        int[,] nums=new int[2,2]; //',' denotes that is is 2d array.
        public void Onedim()
        {
            
            //numbers = new int[5];
            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;


            for (int i= 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Second array");
            //numbers = new int[8];
            numbers[1] = 123;

            //for (int i = 0; i < numbers.Length; i++)
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public void Twodim()
        {
            /*
             nums[0,0] = 100;
            nums[0,1] = 200;
            nums[1,0] = 300;
            nums[1,1] = 400;
            */

            //another way
            int[,] nums = { { 100, 200 }, { 300, 400 } };
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
        //jagged array
        public void Jarray()
        {
            int[][,] arr = new int[][,]
            {
                new int[,] { { 1,2},{ 3,4} },
                new int[,] { {0,2 }, {4,6 },{ 8, 10 } },
                new int[,] {{7,8,8},{3,1,7},{0,6,8}},
                
                

            };
            /*foreach(var item in arr)
            {
                Console.WriteLine(item[1,1]);
            }*/
            for(int i=0;i<arr.Length;i++)
            {
               int x= 0;
                for (int j = 0; j < arr[i].GetLength(x) ;
                j++)
                {
                for(int k = 0; k < arr[j].Rank;k++)
                {
                    Console.Write(arr[i][j,k]+" ");
                }
                Console.WriteLine();
            }
                x++;
                Console.WriteLine() ;
            }
        }
    }
}
