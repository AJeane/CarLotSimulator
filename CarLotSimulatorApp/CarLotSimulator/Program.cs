﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

          
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car



            Car ferrari = new Car();
            ferrari.Year = 2001;
            ferrari.Make = "Ferrari";
            ferrari.Model = "360 Modena";
            ferrari.EngineNoise = "Vreeeeem";
            ferrari.HonkNoise = "Hnnnnnnk";
            ferrari.IsDrivable = true;

            ferrari.MakeEngineNoise();
            ferrari.MakeEngineNoise();

            //

            Car volvo = new Car() { Year = 2014, Make = "Volvo", Model = "S60", EngineNoise = "Shreummm", HonkNoise = "Hnnnnnnngk" };
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
