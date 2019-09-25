using System;

namespace OOPS_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Sri Satya", "Saketh", "Cricket");
            Console.WriteLine(player.getName());
            Console.WriteLine(player.get_PLayer());
        }
    }
}
