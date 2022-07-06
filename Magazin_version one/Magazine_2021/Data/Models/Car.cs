using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine_2021.Data.Models
{
    public class Car
    {
        /// <summary>
        /// идентификатор авто
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название авто
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Краткое описание
        /// </summary>
        public string shortDesc { get; set; }
        /// <summary>
        /// Полное описание авто
        /// </summary>
        public string longDesc { get; set; }
        /// <summary>
        /// Картинка
        /// </summary>
        public string img { get; set; }
        /// <summary>
        /// Стоимость автомобиля
        /// </summary>
        public uint price { get; set; }
        /// <summary>
        /// Доступность авто в блоке "Избранные"
        /// </summary>
        public bool isFavourite { get; set; }
        /// <summary>
        /// Доступность авто для продажи
        /// </summary>
        public bool available { get; set; }
        /// <summary>
        /// Принадлежность к категории
        /// </summary>
        public int categoryId { get; set; }

    }
}
