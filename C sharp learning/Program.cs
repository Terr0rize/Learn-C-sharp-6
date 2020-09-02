using System;
using System.Collections.Generic; //массив, списки.
using System.Globalization;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {          

            int owo = 10;
            int[] num = new int[owo];
            Random rand = new Random();
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(-100, 50);
            }
            foreach (int el in num)
            {              
                Console.WriteLine(el);
            }
           
            Console.ReadKey();
        }
    }
}
