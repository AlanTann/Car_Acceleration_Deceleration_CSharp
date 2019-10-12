using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Honda", "Red", 5, 0);

            int choice = 0;

            while (choice != -1)
            {

                choice = 0;
                car.output();
                Console.WriteLine("Do you Wish to Accelrate, Decelerate or Stop the Car?\n1. Accelerate\n2. Decelerate\n3. Stop\n\nType in -1 to Exit\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        car.accel(car.speed);
                        break;
                    case 2:
                        car.decel(car.speed);
                        break;
                    case 3:
                        car.stop();
                        break;
                    case -1:
                        break;
                    default:
                        Console.WriteLine("Invalid Answer");
                        break;
                }

            }       
            

            Console.WriteLine("\nPress Enter to Exit!");
            Console.ReadLine();
        }
    }

    public class Car
    {
        
        public int speed { get; set; }
        public int engine { get; set; }
        public string brand;
        public string color;

        //Default Constructor
        public Car()
        {

        }
        
        //Overloaded Constructor
        public Car(string Brand, string Color, int Engine, int Speed)
        {
            brand = Brand;
            color = Color;
            engine = Engine;
            speed = Speed;
        }

        
        public void accel(int _speed)
        {
            speed = _speed + 10;

        }
        public void decel(int _speed)
        {
            speed = _speed - 10;
            if (speed < 0)
             speed = 0; 


        }
        public void stop()
        {
            speed = 0;
        }
        
        public void output()
        {
            Console.WriteLine("Car Brand: {0}\nCar Color: {1}\nCar Engine Power: {2}\nCar Speed: {3}\n", brand, color, engine, speed);
        }
    }
}



