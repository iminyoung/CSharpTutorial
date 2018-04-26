using System;
using System.Collections.Generic;
using System.Text;


class Exercise3a
{
    static void Main(string[] args)
    {
        Console.Write("Enter height(1-20): ");
        try
        {
            int height = int.Parse(Console.ReadLine());

            if (height >= 1 && height <= 20)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
            }
            else
            {
                Console.WriteLine("Input only 1 to 20 numbers");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Input only numbers");
        }
        Console.Read();
    }
}