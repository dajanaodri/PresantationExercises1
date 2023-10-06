using Excercise2;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle
        {
            Power = "150HP",
            RPM = 6000,
            NumberOfCylinders = 4
        };

        Vehicle car = new Car("200HP", 7000, 6);


        Console.WriteLine("Calling Engine() method on the base class object:");
        vehicle.Engine();

        Console.WriteLine("\nCalling Engine() method on the derived class object:");
        car.Engine();

        Console.ReadLine();
    }
}




