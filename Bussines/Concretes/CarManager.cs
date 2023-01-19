using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager :ICarService
    {
        ICarDal carDal;
        public CarManager(ICarDal carDal)
        {
           this.carDal = carDal;    
        }

        public List<Car> GetAll()
        {
          return carDal.GetAll();
        }
    }
}
