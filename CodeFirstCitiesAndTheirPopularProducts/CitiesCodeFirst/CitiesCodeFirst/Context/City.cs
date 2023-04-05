using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesCodeFirst.Context
{
    internal class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; } = null!;               
        public virtual ICollection<PopularProduct> PopularProducts { get; set; }

        
    }
}
   
