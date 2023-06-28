using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1D2D
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("-----first matrix-----");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value for arr {i},{j}");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "");
                }
                Console.WriteLine();
            }

            //int[,] arr = new int[3, 3];
            Console.WriteLine("-----second matrix-----");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value for arr {i},{j}");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----Addition matrix-----");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+arr[i,j] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
