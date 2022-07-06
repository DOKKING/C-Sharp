using Magazine_2021.Data;
using Magazine_2021.Data.Models;
using Magazine_2021.Data.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine_2021.Controllers
{
    public class CarsController : Controller
    {
        CarContext db;
        IHostingEnvironment env;
        public int pageSize = 6;
        int MaxPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)db.CarTable.Count() / pageSize);
            }
        }

        public CarsController(CarContext context, IHostingEnvironment environment)
        {
            db = context;
            env = environment;
        }

        public ViewResult AllCars(int page = 1)
        {
            return View(
                new CarPageModel
                {
                    Cars = db.CarTable.OrderBy(c => c.id).Skip((page - 1) * pageSize).Take(pageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = pageSize,
                        TotalItems = db.CarTable.Count()
                    }
                }
            );
        }


        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(Car car, IFormFile file)
        {
            if (file != null)
            {
                string path = "/img/" + Path.GetFileName(file.FileName);
                car.img = path;

                using (FileStream fileStream = new FileStream(env.WebRootPath + path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }

            db.CarTable.Add(car);
            db.SaveChanges();

            return RedirectToRoute(new { controller = "Home", action = "CarsInTable" });
        }


        public IActionResult DeleteCar(int _id)
        {
            //Car car = db.CarTable.Where(c => c.id == _id).FirstOrDefault();
            Car car = db.CarTable.Find(_id);

            if (car != null)
            {
                db.CarTable.Remove(car);
                db.SaveChanges();
            }

            return RedirectToRoute(new { controller = "Home", action = "CarsInTable" });
        }

        [HttpGet]
        public IActionResult EditCar(int? _id)
        {
            Car car = db.CarTable.Find(_id);

            if (car != null)
                return View(car);
            else
                return RedirectToRoute(new { controller = "Home", action = "CarsInTable" });
        }

        [HttpPost]
        public async Task<IActionResult> EditCar(Car car, IFormFile file)
        {
            if (file != null)
            {
                string path = "/img/" + Path.GetFileName(file.FileName);
                car.img = path;

                using (FileStream fileStream = new FileStream(env.WebRootPath + path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }

            //db.CarTable.Update(car);
            db.Entry(car).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToRoute(new { controller = "Home", action = "CarsInTable" });
        }


    }
}
