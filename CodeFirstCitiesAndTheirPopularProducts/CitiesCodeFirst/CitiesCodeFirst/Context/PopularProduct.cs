using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesCodeFirst.Context
{
    internal class PopularProduct
    {
        [Column(name:"ProductID")]
        public int PopularProductID { get; set; }        
        public int CityID { get; set; }        
        public City Cities { get; set; } = null!;
        public string ProductName { get; set; } = null!;
    }
}
