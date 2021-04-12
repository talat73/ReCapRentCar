using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        void AddCar(Car car);
        List<Car> GetAll();
        void DeleteCar(Car car);
        void UpdateCar(Car car);
        Car GetCarById(int carId);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailsDto> GetCarDetails();
    }
}
