using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {


        static void Main(string[] args)
        {
            //CarTest();
            //ColorTest();            
            //UserTest();
            //CustomerTest();
            //CarDetails();
            //RentalTest();

            
        }





        //private static void CustomerTest()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomer());
        //    foreach (var customer in customerManager.GetAll())
        //    {
        //        Console.WriteLine(customer.CustomerName);
        //    }
        //}
        //private static void UserTest()
        //{
        //    UserManager userManager = new UserManager(new EfUser());
        //    foreach (var user in userManager.GetAll())
        //    {
        //        Console.WriteLine(user.FirstName);
        //    }
        //}
        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColor());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //}
        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCar());
        //    var result = carManager.GetCarDetails();

        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.Id + " / " + car.DailyPrice);
        //        }
        //    }
        //}
        //private static void RentalTest()
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRental());
        //    var result = rentalManager.GetRentalDetails();

        //    if (result.Success == true)
        //    {
        //        foreach (var rental in result.Data)
        //        {
        //            Console.WriteLine("{0}/{1}/{2}/{3}/{4}/{5}", rental.Id,rental.CarId, rental.FirstName,rental.LastName,rental.RentDate,rental.ReturnDate);
        //            Console.WriteLine(result.Message);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

        //}

        //private static void CarDetails()
        //{
        //    CarManager carManager = new CarManager(new EfCar());

        //    var result = carManager.GetCarDetails();

        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine( car.DailyPrice + " / " + car.Description);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}
    }
}