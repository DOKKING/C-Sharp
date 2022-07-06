using Magazine_2021.Data.Models;
using Magazine_2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine_2021.Data.Mock
{
    public class MockCars : IAllCars
    {
        public string Header { get; set; }
        public IEnumerable<Car> Cars {
            get
                {
                return new List<Car>
                    {
                        new Car
                        {
                            name="Tesla",
                            shortDesc = "Экологически чистый авто",
                            longDesc = "",
                            img = "/img/tesla.jpg",
                            price = 200000,
                            isFavourite = true,
                            available = true,
                            categoryId = 1
                        },
                        new Car
                        {
                            name="Mercedes SLS",
                            shortDesc = "Экологически чистый авто",
                            longDesc = "",
                            img = "/img/MersX.jpg",
                            price = 250000,
                            isFavourite = true,
                            available = false,
                            categoryId = 1
                        },

                        new Car
                        {
                            name="LADA ELECTRA",
                            shortDesc = "Новейшая разработка автопрома РФ",
                            longDesc = "",
                            img = "/img/mers.jpg",
                            price = 150000,
                            isFavourite = false,
                            available = true,
                            categoryId = 1
                        },

                        new Car
                        {
                            name="FORD GTR",
                            shortDesc = "Автомобили с классическим двигателем",
                            longDesc = "",
                            img = "/img/fiesta.jpg",
                            price = 100000,
                            isFavourite = true,
                            available = true,
                            categoryId = 2
                        },

                        new Car
                        {
                            name="Bugatti",
                            shortDesc = "Автомобили с классическим двигателем",
                            longDesc = "",
                            img = "/img/a4.jpg",
                            price = 220000,
                            isFavourite = true,
                            available = false,
                            categoryId = 2
                        },

                        new Car
                        {
                            name="Tesla BENZO",
                            shortDesc = "Как TESLA только бензиновая",
                            longDesc = "",
                            img = "/img/toyota.jpg",
                            price = 135000,
                            isFavourite = true,
                            available = true,
                            categoryId = 2
                        }
                };
            }
        }
        public IEnumerable<Car> getFavCars {
            get
            {
                return Cars.Where(c => c.isFavourite == true);
            }
        }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
