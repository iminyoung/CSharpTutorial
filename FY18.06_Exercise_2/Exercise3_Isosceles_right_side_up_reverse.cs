using System;
using System.Collections.Generic;
using System.Text;

class Exercise4_Reverse
{
    static void Main(string[] args)
    {
        Console.Write("Enter height(1-20): ");
        try
        {
            int height = int.Parse(Console.ReadLine());
            int star = 0;

            if (height >= 1 && height <= 20)
            {

                for (int i = height; i >= 1; i--)
                {
                    star = 0;
                    while (star != (2 * i - 1))
                    {
                        Console.Write("*");
                        star++;
                    }
                    Console.WriteLine();
                    for (int space = 0; space <= height - i; space++)
                    {
                        Console.Write(" ");
                    }
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