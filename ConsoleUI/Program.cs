using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ////////////////////////////////////////////CarManager\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


            CarManager carManager = new CarManager(new EfCarDal());
             

            carManager.AddCar(new Car { CarId = 12, BrandId = 3, ColorId = 3, Description = "r", DailyPrice = -250, ModelYear = "2019" });

            Console.WriteLine("   ---Araç Listesi---   \n");
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            }
            Console.WriteLine("\n");

            //Console.WriteLine("   ---Arama Kriterlerine Göre Listeleme(BrandID)---    \n");
            //foreach (var car in carManager.GetByBrandId(2))
            //{
            //    Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine("   ---Arama Kriterlerine Göre Listeleme(ColorID)---    \n");
            //foreach (var car in carManager.GetByColorId(4))
            //{
            //    Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            //}




            //////////////////////////////////////////////ColorManager\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ //Tüm fonksiyonlar çalışmakta\\
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //int row1= 1;
            //foreach (var color in colorManager.GetAllColor())
            //{
            //    Console.WriteLine( row1 + "---" + color.ColorName);
            //    row1++;
            //}

            //Console.WriteLine("\n");

            //////////////////////////////////////////////BrandManager\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ //Tüm fonksiyonlar çalışmakta\\
            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //int row2 = 1;
            //foreach (var brand in brandManager.GetAllBrands())
            //{

            //    Console.WriteLine(row2 + "---" + brand.BrandName);
            //    row2++;
            //}








            // InMemoryFormat();

        }

        private static void InMemoryFormat()
        {
            //    //List
            //   // CarManager carManager = new CarManager(new InMemoryCarDal());
            //    foreach (var car in carManager.GetAllCar())
            //    {
            //        Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            //    }
            //    Console.WriteLine("\n");

            //    //Add
            //    carManager.AddCar(new Car { Id = 9, BrandId = 6, ColorId = 4, ModelYear = "2023", DailyPrice = 750, Description = "Chevrolet Camaro" });
            //    foreach (var car in carManager.GetAllCar())
            //    {
            //        Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            //    }
            //    Console.WriteLine("\n");

            //    //Delete
            //    carManager.DeleteCar(new Car { Id = 9 });
            //    foreach (var car in carManager.GetAllCar())
            //    {
            //        Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            //    }
            //    Console.WriteLine("\n");

            //    //Update
            //    carManager.UpdateCar(new Car { Id = 7, DailyPrice = 700, ModelYear = "2023", Description = "Audi RS 8" });
            //    foreach (var car in carManager.GetAllCar())
            //    {
            //        Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            //    }
            //    Console.WriteLine("\n");

            //    //Renk ID'ye göre        
            //    foreach (var car in carManager.GetByColorId(2))
            //    {
            //        Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            //    }
            //    Console.WriteLine("\n");

            //    //Marka ID'ye göre
            //    Console.WriteLine("Hangi markaya göre arama yapmak istiyorsunuz ?\n");
            //    Console.WriteLine("1-Fiat\n2-Ford\n3-Opel\n4-Audi\n5-Renault");
            //    int value = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Seçimler kriterlerinize göre listeleniyor...");
            //    foreach (var car in carManager.GetByBrandId(value))
            //    {
            //        Console.WriteLine("{0} --- {1} --- {2} TL/gün", car.Id, car.Description, car.DailyPrice);
            //    }
            //    Console.WriteLine("\n");
            //}
        }
    }
}
