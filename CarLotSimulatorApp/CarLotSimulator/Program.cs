using System;

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
            //DONE

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //DONE

            var lot = new CarLot();
            
            var honda = new Car();
            honda.Year = 2016;
            honda.Make = "Honda";
            honda.Model = "Element";
            honda.EngineNoise = "Vroom";
            honda.HonkNoise = "Meep, Meep";
            honda.IsDriveable = true;

            lot.Cars.Add(honda);

            var toyota = new Car() 
            { Year = 2020, Make = "Toyota", Model = "Rav4", 
            EngineNoise = "Grrr", HonkNoise = "Beep, Beep", IsDriveable = true};

            lot.Cars.Add(toyota);

            var ford = new Car(2018, "Ford", "Bronco","Vrrrrrrrr", "Hoooonk", false);
            lot.Cars.Add(ford);

            //CALL METHODS
            honda.MakeEngineNoise();
            honda.MakeHonkNoise();
            Console.WriteLine();

            toyota.MakeEngineNoise();
            toyota.MakeHonkNoise();
            Console.WriteLine();

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();
            Console.WriteLine();

            foreach (var item in lot.Cars)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
            }
            //*************BONUS*************//

            // DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
