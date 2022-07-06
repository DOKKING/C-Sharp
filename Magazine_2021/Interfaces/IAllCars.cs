using Magazine_2021.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine_2021.Interfaces
{
    interface IAllCars
    {
        /// <summary>
        /// метод для получения всех авто
        /// </summary>
        IEnumerable<Car> Cars { get; }
        /// <summary>
        /// метод для получения избранных авто
        /// </summary>
        IEnumerable<Car> getFavCars { get;}
        /// <summary>
        /// вернет конкретный автомобиль по его ID 
        /// </summary>
        /// <param name="carId">ID автомобиля</param>
        /// <returns>объект - автомобиль</returns>
        Car getObjectCar(int carId);
    }
}
