using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Threading.Channels;

namespace Properties

{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }

        class Car
        {
            //String model;

            //public string Model
            //{
            //    get { return model; }
            //    set { model = value; }
            //}

            public string Model
            {
                get;
                set;
            }

            public Car(String model) 
            {
                this.Model = model;
            }
        }
    }
}