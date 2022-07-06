using Magazine_2021.Data.Models;
using Magazine_2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine_2021.Data.Mock
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {id = 1, categoryName = "Электромобили", desc="Современный вид транспорта"},
                    new Category {id = 2, categoryName = "Классические автомобили", desc = "Автомобили с ДВС"}
                };
            }
        }
    }
}
