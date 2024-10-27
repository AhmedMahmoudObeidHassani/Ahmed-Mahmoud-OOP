using System.Drawing;

namespace Ahmed_Mahmoud_OOP
{

    class Vehicle
    {
        public  string companyName;
        
        public Vehicle(string companyName)
        {
            this.companyName = companyName;
        }


    }
    class Motor_vehicle: Vehicle
    {
        public string model;
        public Motor_vehicle(string model,string companyName) :base( companyName)
        {
            this.model = model;
        }


    }

    class Car : Motor_vehicle
    {
        public string color;
        public Car(string color,string model, string companyName):base(model,companyName)
        {

            this.color = color;
        }


    }
    class Truck: Motor_vehicle
    {
        public string weight;
        public Truck(string weight,string model,string companyName):base(model,companyName)
        {
            this.weight = weight;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car("red", "c112", "BMW");
            Truck MyTruck = new Truck(" 2000kg", "ccciu", "Bmw");
            Console.WriteLine($" my car is {MyCar.model} and the color is {MyCar.color} it made by {MyCar.companyName}");
            Console.WriteLine($" my Truck is { MyTruck.model} and the weight is{MyTruck.weight} it made by {MyTruck.companyName}");

        }
    }
}
