using System;

namespace Magazine_2021.Data.ViewModels
{
    public class PagingInfo
    {
        /// <summary>
        /// Количество элементов в таблице
        /// </summary>
        public int TotalItems { get; set; }
        /// <summary>
        /// Количество элементов выводимых на странице
        /// </summary>
        public int ItemsPerPage { get; set; }
        /// <summary>
        /// Номер текущей страницы
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// Всего страниц
        /// </summary>
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
