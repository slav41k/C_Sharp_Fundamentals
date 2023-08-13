using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car01 = new Car();
            Car car02 = new Car();
            Car car03 = new Car();
            car01.Input();
            car02.Input();
            car03.Input();
            Console.WriteLine("enter percents you would like to reduce prices of cars");
            float percent = Convert.ToSingle(Console.ReadLine());
            car01.ChangePrice(percent);
            car01.Output();
            car02.ChangePrice(percent);
            car02.Output();
            car03.ChangePrice(percent);
            car03.Output();
            Console.Write("Enter new color ");
            string newColor = Console.ReadLine();
            string oldColor = "white";
            if (car01.Color.Equals(oldColor))
            {
                car01.Color = newColor;
                Console.WriteLine("First car has new color - " + newColor);
            }
            else if (car02.Color.Equals(oldColor))
            {
                car02.Color = newColor;
                Console.WriteLine("Second car has new color - " + newColor);
            }
            else if (car03.Color.Equals(oldColor))
            {
                car03.Color = newColor;
                Console.WriteLine("Third car has new color - " + newColor);
            }
            else Console.WriteLine("Color was not changed");
            if (car01 == car02)
                Console.WriteLine("First and second cars are equals");
		
            else
                Console.WriteLine("First and second cars are not equals");
            Console.WriteLine(car01.ToString());
            Console.WriteLine(car02.ToString());
            Console.WriteLine(car03.ToString());
            Console.ReadKey();
        }
    }﻿
