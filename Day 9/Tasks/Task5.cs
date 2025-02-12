using System;
interface Bike
{
    void bikeAvgSpeed(int speed);
}
interface Car
{
    void carAvgSpeed(int speed);
}
class Vehicle : Bike, Car
{
    public void bikeAvgSpeed(int speed)
    {
        if (speed > 50)
        {
            Console.WriteLine("Warning: Bike speed limit exceeded!");
        }
        else
        {
            Console.WriteLine("Bike speed is within the limit.");
        }
    }
    public void carAvgSpeed(int speed)
    {
        if (speed > 100)
        {
            Console.WriteLine("Warning: Car speed limit exceeded!");
        }
        else
        {
            Console.WriteLine("Car speed is within the limit.");
        }
    }
    static void Main(string[] args)
    {
        int bikeSpeed = int.Parse(args[0]);
        int carSpeed = int.Parse(args[1]);
        Vehicle vehicle = new Vehicle();
        vehicle.bikeAvgSpeed(bikeSpeed);
        vehicle.carAvgSpeed(carSpeed);
    }
}