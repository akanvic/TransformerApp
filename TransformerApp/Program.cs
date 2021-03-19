using System;

namespace TransformerApp
{
    public enum Landscape
    {
        Air,
        Road,
        Water
    }

    public class Vehicle
    {
        public void Jet(int wheels, int MaxSpeed)
        {
            Console.WriteLine("BOOM A JET with {0} wheels and a Max speed of {1} in {2}", wheels, MaxSpeed, Landscape.Air);
        }
        public void Car(int wheels, int MaxSpeed)
        {
            Console.WriteLine("BOOM A CAR with {0} wheels and a Max speed of {1} on {2}", wheels, MaxSpeed, Landscape.Road);
        }

        public void Boat(int wheels, int MaxSpeed)
        {
            Console.WriteLine("BOOM A BOAT with {0} wheels and a Max speed of {1} on {2} ", wheels, MaxSpeed, Landscape.Water);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Transformer(Landscape.Road);      
        }

        static void Transformer(Landscape landscape)
        {
            var vehicle = new Vehicle();
            if (landscape == Landscape.Air)
            {
                vehicle.Jet(8,900);
            }
            else if (landscape == Landscape.Road)
            {
                vehicle.Car(4, 350);
            }
            else
            {
                vehicle.Boat(0, 200);
            }
        }
    }
}
