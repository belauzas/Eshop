using System;

namespace Eshop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the shop!");

            Shop shootsEshop = new Shop();

            shootsEshop.AddItem("Pirstines");
            shootsEshop.AddItem("Kepure");
            shootsEshop.AddItem("Salikas");

            Console.ReadLine();
        }
    }
}