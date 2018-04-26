using System;
using System.Collections.Generic;
using System.Text;


class Exercise3b
{
    static void Main(string[] args)
    {
        string asterisk = "*";
        Console.Write("Enter height(1-20): ");
        try
        {
            int height = int.Parse(Console.ReadLine());

            if (height >= 1 && height <= 20)
            {
                for (int i = height; i > 0; i--)
                {

                    for (int j = i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(asterisk);
                    asterisk = asterisk + "*";
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