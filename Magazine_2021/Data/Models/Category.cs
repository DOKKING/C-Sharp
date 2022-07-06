using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine_2021.Data.Models
{
    public class Category
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название категории
        /// </summary>
        public string categoryName {get; set;}
        /// <summary>
        ///Описание категории
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// Список автомобилей в данной категории
        /// </summary>
        public List<Car> _cars { get; set; }
    }
}
