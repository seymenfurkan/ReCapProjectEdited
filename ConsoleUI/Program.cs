using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine("{0} --- {1} --- {2} TL/gün",car.Id,car.Description,car.DailyPrice);
            }
            Console.WriteLine("\n");

            //Add
            carManager.AddCar(new Car {Id=9, BrandId=6, ColorId=4, ModelYear="2023", DailyPrice=750, Description="Chevrolet Camaro" });
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            }
            Console.WriteLine("\n");

            //Delete
            carManager.DeleteCar(new Car { Id = 9 });
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            }
            Console.WriteLine("\n");

            //Update
            carManager.UpdateCar(new Car {Id = 7, DailyPrice = 700, ModelYear = "2023", Description="Audi RS 8"});
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            }
            Console.WriteLine("\n");

            //Renk ID'ye göre        
            foreach (var car in carManager.GetByColorId(2))
            {
                Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            }
            Console.WriteLine("\n");

            //Marka ID'ye göre
            Console.WriteLine("Hangi markaya göre arama yapmak istiyorsunuz ?\n");
            Console.WriteLine("1-Fiat\n2-Ford\n3-Opel\n4-Audi\n5-Renault");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seçimler kriterlerinize göre listeleniyor...");
            foreach (var car in carManager.GetByBrandId(value))
            {
                Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            }
            Console.WriteLine("\n");

        }
    }
}
