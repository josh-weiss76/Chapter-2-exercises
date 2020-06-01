using System;

namespace AreaOfARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the rectangle:");
            string lengthInput = Console.ReadLine();
            int length = int.Parse(lengthInput);
            Console.WriteLine("Please enter the width of the rectangle:");
            string widthInput = Console.ReadLine();
            int width = int.Parse(widthInput);
            Console.WriteLine("The area of the rectangle is " + (width * length));
        }
    }
}
