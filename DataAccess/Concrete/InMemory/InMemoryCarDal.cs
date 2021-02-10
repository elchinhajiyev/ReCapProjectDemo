using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;
		public InMemoryCarDal()
		{
			_cars = new List<Car> {
			new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2008, DailyPrice=50000  },
			new Car{Id=2, BrandId=1, ColorId=1, ModelYear=2010, DailyPrice=30000  },
			new Car{Id=3, BrandId=1, ColorId=2, ModelYear=2015, DailyPrice=40000  },
			new Car{Id=4, BrandId=1, ColorId=3, ModelYear=2009, DailyPrice=60000  },
			};
		}
		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetByBrandId(int BrandId)
		{
			return _cars.Where(c => c.BrandId == BrandId).ToList();
		}

		
		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.Id = car.Id;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.DailyPrice=car.DailyPrice;
			carToUpdate.Description = car.Description;
		}
	}
}
