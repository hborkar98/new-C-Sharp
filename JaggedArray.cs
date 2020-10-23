using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[2];
            arr[2] = new int[1];


           System.Console.WriteLine("Enter Elements :");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = 0;
                    //arr[i][j] = Convert.ToInt32(System.Console.ReadLine());
                }
            }

            System.Console.WriteLine("Entered Elements are :");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < (arr[i].Length); j++)
                {
                    System.Console.Write(arr[i][j]);
                    System.Console.Write('\t');
                }
                System.Console.WriteLine();
            }

           System.Console.ReadKey();
    
        }
    }
}