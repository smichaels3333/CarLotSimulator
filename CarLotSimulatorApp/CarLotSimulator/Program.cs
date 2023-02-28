using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();
            lot.Cars.Add();
            // Done Create a seperate class file called Car 
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var stephensCar = new Car();
            stephensCar.Make = "Toyota";
            stephensCar.Model = "Corolla";
            stephensCar.Year = 2009;
            stephensCar.EngineNoise = "vroom";
            stephensCar.HonkNoise = "beep";
            stephensCar.IsDriveable= true;

            lot.Cars.Add(stephensCar);

            var lindsaysCar = new Car()
            {
                Make= "Hyundai",
                Model= "Tuscon",
                Year= 2019,
                EngineNoise= "vroom",
                HonkNoise= "honk",
                IsDriveable= true,
            };

            lot.Cars.Add(lindsaysCar);

            var dadsCar = new Car(2016, "Chevy", "Colorado", "vroom", "honk", true);

            lot.Cars.Add(dadsCar);
            //Call methods
            stephensCar.MakeEngineNoise(stephensCar.EngineNoise);
            lindsaysCar.MakeEngineNoise(lindsaysCar.EngineNoise);
            dadsCar.MakeEngineNoise(dadsCar.EngineNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done- Create a CarLot class
            //Done- It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars) 
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }

    }
}
