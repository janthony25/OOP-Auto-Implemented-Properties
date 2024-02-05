﻿using System;
using System.Collections.Generic;


namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // Auto-Implemented properties = shortcut when no additional logic is required in the property
            //                               you do not have to define a field for a property.
            //                               you only have to write get; and /or set; inside the property

            Car car = new Car("Porche");
            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }

    class Car
    {
        public string Model { get; set; }


        public Car(string model)
        {
            this.Model = model;
        }
    }
}