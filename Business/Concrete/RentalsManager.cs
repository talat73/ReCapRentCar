using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _rentalDal;

        public RentalsManager(IRentalsDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rentals)
        {
            if (rentals.RentDate.Hour >= 18 && rentals.RentDate.Hour<=7)
            {
                return new SuccessResult(Messages.RentHourInvalid);
            }
            _rentalDal.Add(rentals);
            return new SuccessResult(Messages.RentalsAdded);
        }

        public IResult Delete(Rentals rentals)
        {
            _rentalDal.Delete(rentals);
            return new SuccessResult(Messages.RentalsDeleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll());
        }

        public IDataResult<Rentals> GetById(int rentalId)
        {
            return new SuccessDataResult<Rentals>(_rentalDal.Get(r => r.RentalsId == rentalId));
        }

        public IResult Update(Rentals rentals)
        {
            _rentalDal.Update(rentals);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
