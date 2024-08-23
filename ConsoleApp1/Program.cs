
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //          int x = Convert.ToInt32(Console.ReadLine());
            //          int y = int.Parse(Console.ReadLine());
            float x;
            float y;
            bool isX;
            bool isY;
            string str;
            str = Console.ReadLine();
            string[] arr = str.Split(' ');
            do
            {

                isX = float.TryParse(arr[0], out x);
                isY = float.TryParse(arr[0], out y);
                float c = 0;

                string z = arr[1];
                if (isX && isY)
                {
                    switch (z)
                    {
                        case "+":
                            c = x + y;
                            break;
                        case "-":
                            c = x - y;
                            break;
                        case "*":
                            c = x * y;
                            break;
                        case "/":
                            if (y == 0)
                            {
                                Console.WriteLine("error");
                            }
                            else { c = (x / y); }

                            break;
                    }
                    if (c != 0)
                    {
                        Console.WriteLine(c);
                    }

                }
                else
                {
                    Console.WriteLine("Duzgun Reqem daxil edin!");
                }

            } while (!isX || !isY || y == 0);


            Console.ReadKey();
        }
    }
}
