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
            int num = 1;
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(" " + num + " - " + "Model İsmi: {0} --- Marka: {1} --- Renk: {2} --- Kiralama Bedeli: {3}TL/gün ", car.Description, car.BrandName , car.ColorName , car.DailyPrice);
                num++;
            }

            //////////////////// CarManager Codes \\\\\\\\\\\\\\\\\\\\\\
            //GetCarById();
            //ListOfCar();
            //UpdateCar();
            //DeleteCar();
            //AddNewCar();    
            //ListByColorIdAndBrandId();
            //InMemoryFormat();



            /////////////////////// ColorManager Codes \\\\\\\\\\\\\\\\\\\\\
            //GetByColorId();
            //UpdateColor();
            //DeleteColor();
            //AddColor();
            //ListOfColor();



            ///////////////////// BrandManager Codes \\\\\\\\\\\\\\\\\\\\\\\
            //GetByBrandId();
            //DeleteBrand();
            //UpdateBrand();
            //AddBrand();
            //ListOfBrand();

        }

        private static void GetByBrandId()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetByBrand(2).BrandName;
            Console.WriteLine(result);
        }

        private static void DeleteBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.DeleteBrand(new Brand { BrandId = 6 });
        }

        private static void UpdateBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.UpdateBrand(new Brand { BrandId = 6, BrandName = "Maserati" });
        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.AddBrand(new Brand { BrandId = 6, BrandName = "Chevrolet" });
        }

        private static void ListOfBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAllBrands())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void GetByColorId()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetByColor(4).ColorName;
            Console.WriteLine(result);
        }

        private static void UpdateColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.UpdateColor(new Color { ColorId = 2, ColorName = "Simsiyah" });
        }

        private static void DeleteColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.DeleteColor(new Color { ColorId = 5 });
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.AddColor(new Color { ColorId = 5, ColorName = "Aytozu Grisi" });
        }

        private static void ListOfColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAllColors())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetCarById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(10).Description;
            Console.WriteLine(result);
        }

        private static void ListOfCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("   ---Araç Listesi---   \n");
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            }
            Console.WriteLine("\n");
        }

        private static void UpdateCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.UpdateCar(new Car { CarId = 10, DailyPrice = 165, BrandId = 1, ColorId = 4, ModelYear = "2016", Description = "Fiat Doblo" });
            Console.WriteLine("   ---Araç Listesi---   \n");
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            }
            Console.WriteLine("\n");
        }

        private static void DeleteCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.DeleteCar(new Car { CarId = 11 });
            Console.WriteLine("   ---Araç Listesi---   \n");
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            }
            Console.WriteLine("\n");
        }

        private static void AddNewCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.AddCar(new Car { CarId = 12, BrandId = 3, ColorId = 3, Description = "r", DailyPrice = -250, ModelYear = "2019" });
            Console.WriteLine("   ---Araç Listesi---   \n");
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            }
            Console.WriteLine("\n");
        }

        private static void ListByColorIdAndBrandId()
        {
            Console.WriteLine("   ---Arama Kriterlerine Göre Listeleme(BrandID)---    \n");
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByBrandId(2))
            {
                Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            }
            Console.WriteLine("\n");

            Console.WriteLine("   ---Arama Kriterlerine Göre Listeleme(ColorID)---    \n");
            foreach (var car in carManager.GetByColorId(4))
            {
                Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
            }
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
