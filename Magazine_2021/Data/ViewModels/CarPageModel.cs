using Magazine_2021.Data.Models;
using System.Collections.Generic;

namespace Magazine_2021.Data.ViewModels
{
    public class CarPageModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
