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

            //AddRental();

            //AddCustomer();

            //AddUser();



            //int num = 1;
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(" " + num + " - " + "Model İsmi: {0} --- Marka: {1} --- Renk: {2} --- Kiralama Bedeli: {3}TL/gün ", car.Description, car.BrandName , car.ColorName , car.DailyPrice);
            //    num++;
            //}


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

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.AddRental(new Rental { Id = 3, CarId = 2, CustomerId = 2, RentDate = new DateTime(2022, 5, 25), ReturnDate = new DateTime(2024, 5, 25) });
            foreach (var rental in rentalManager.GetAllRentals())
            {
                Console.WriteLine("Veri : {0} --- Araç No : {1} --- Müşteri No : {2} --- Kiralama Tarihi : {3} --- Teslim Tarihi : {4}", rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
            }
        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.AddCustomer(new Customer { CustomerId = 3, UserId = 3, CompanyName = "Er Holding" });
            foreach (var customer in customerManager.GetAllCustomers())
            {
                Console.WriteLine(" {0} --- Şirket İsmi : {1} ", customer.CustomerId, customer.CompanyName);
            }
        }

        private static void AddUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.AddUser(new User { UserId = 4, FirstName = "Enes", LastName = "Er", Email = "eneser@gmail.com", Password = "ss123456" });
            foreach (var user in userManager.GetAllUsers())
            {
                Console.WriteLine("{0} --- İsim : {1} --- Soyisim : {2} --- Email Adresi : {3} --- Şifre : {4}", user.UserId, user.FirstName, user.LastName, user.Email, user.Password);
            }
        }

        private static void GetByBrandId()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetByBrand(2).Data;
            Console.WriteLine(result.BrandName);
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
            var result = brandManager.GetAllBrands();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetByColorId()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetByColor(4).Data;
            Console.WriteLine(colorManager.GetByColor(4).Message);
            Console.WriteLine(result.ColorName);
        }

        private static void UpdateColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.UpdateColor(new Color { ColorId = 2, ColorName = "Simsiyah" });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void DeleteColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.DeleteColor(new Color { ColorId = 5 });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.AddColor(new Color { ColorId = 5, ColorName = "Aytozu Grisi" });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
              
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ListOfColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAllColors();
            
            if (result.Success)
            {
                Console.WriteLine(result.Message);
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(10).Data;
            Console.WriteLine(result.Description);
            Console.WriteLine(result);
        }

        private static void ListOfCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var resultOfList = carManager.GetAllCar();
           
            if (resultOfList.Success == true)
            {
                Console.WriteLine("--- "+resultOfList.Message+" ---\n");
                
                foreach (var car in resultOfList.Data)
                {
                    Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(resultOfList.Message);
            }
        }

        private static void UpdateCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.UpdateCar(new Car { CarId = 10, DailyPrice = 160, BrandId = 1, ColorId = 4, ModelYear = "2015", Description = "Fiat Doblo" });
            Console.WriteLine(result.Message+"\n");
            var resultOfList = carManager.GetAllCar();
            Console.WriteLine("   ---Araç Listesi---   \n");
            if (resultOfList.Success == true)
            {
                foreach (var car in resultOfList.Data)
                {
                    Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(resultOfList);
            }
        }

        private static void DeleteCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.DeleteCar(new Car { CarId = 12 });
            Console.WriteLine(result.Message+"\n");
            var resultOfList = carManager.GetAllCar();
            Console.WriteLine("   ---Araç Listesi---   \n");
            if (resultOfList.Success == true)
            {
                foreach (var car in resultOfList.Data)
                {
                    Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(resultOfList);
            }
        }

        private static void AddNewCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.AddCar(new Car { CarId = 14, BrandId = 2, ColorId = 4, Description = "F", DailyPrice = -210, ModelYear = "2019" });
            Console.WriteLine(result.Message);
            var resultOfList = carManager.GetAllCar();
            Console.WriteLine("   ---Araç Listesi---   \n");
            if (resultOfList.Success == true)
            {
                foreach (var car in resultOfList.Data)
                {
                    Console.WriteLine(" {0} --- {1} --- {2} Model --- {3} TL/gün ", car.CarId, car.Description, car.ModelYear, car.DailyPrice);
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(resultOfList);
            }
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
