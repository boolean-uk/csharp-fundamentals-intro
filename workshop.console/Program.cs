// See https://aka.ms/new-console-template for more information


using workshop.console;
using workshop.console.Animals;

Car beetle = new() { Make="VW", Model = "Beetle", WheelCount=4 };
Car mini = new Car();
mini.Make = "Mini";
mini.Model = "Clubman";
mini.WheelCount = 4;


List<Car> cars = new List<Car>();

cars.Add(mini);
cars.Add(beetle);


foreach(Car car in cars)
{
    Console.WriteLine($"Make:{car.Make} | Model: {car.Model} | Wheels: {car.WheelCount}");
    Console.WriteLine($"Description:{car.Description}");
}


//Cat cat = new Cat() { Name="Red" };

Console.WriteLine();
