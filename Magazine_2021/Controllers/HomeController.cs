using Magazine_2021.Data;
using Magazine_2021.Data.Mock;
using Magazine_2021.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine_2021.Controllers
{
    public class HomeController : Controller
    {
        private CarContext db;
        public HomeController (CarContext context)
        {
            db = context;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Главная страница супер сайта!";
            return View(db.CarTable);
        }

        public ViewResult FavCars()
        {
            ViewBag.Title = "Только избранные автомобили";

            return View(db.CarTable.Where(c=>c.isFavourite==true));
        }

        public IActionResult AddAllCars()
        {
            //создаем экземпляр, через который получаем доступ к списку авто
            var cars = new MockCars();
            //в цикле извлекаем каждый объект списка cars и добавляем в таблицу
            foreach(Car car in cars.Cars)
            {
                db.CarTable.Add(car);
                db.SaveChanges();
            }
            //ничего не возвращаем
            //return new EmptyResult();
            //return RedirectToRoute(new { controller = "Home", action = "Index" });
            return RedirectToAction("Index");

        }

        public ViewResult CarsInTable()
        {
            return View(db.CarTable);
        }

        public ViewResult SingleCar(int _id)
        {
            return View(db.CarTable.Where(c=>c.id==_id).FirstOrDefault());
        }
    }
}
