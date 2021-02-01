using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string aFriend = "Bill";
            Console.WriteLine(aFriend);
            Console.WriteLine($"Hello {aFriend}");
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has{firstFriend.Length} letters and the name {secondFriend} has{secondFriend.Length} letters");


        }
    }
}
