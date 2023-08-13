using System;

namespace Task5
{
    public class Bird : IFlayable
    {
        private string _name;
        private string _canFly;

        public Bird() { }

        public void Input()
        {
            Console.WriteLine("Enter the name of a Bird:");
            _name = Console.ReadLine();
            Console.WriteLine($"Can {_name} fly? (yes or no)");
            _canFly = Console.ReadLine();
        }

        public void Fly()
        {
            string canFlyStatus = (_canFly == "yes") ? "can fly" : "cannot fly";
            Console.WriteLine($"Name: {_name}, {_name} {canFlyStatus}");
        }


    }
}