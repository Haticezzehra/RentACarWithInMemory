using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Car :IEntity
    {
        int Id { get; set; }
        int BrandId { get; set; }
        int ColorId { get; set; }   
        int ModelYear { get; set; }
        int DailyPrice { get; set; }
        string Description { get; set; }

        
    }
}
