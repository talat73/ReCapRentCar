using DataAccess.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.DependencyInjection
{
    public static class EfContextDal
    {
        public static void AddScopeDataAccess(this IServiceCollection services)
        {
            services.AddScoped<ICustomerDal, CustomerDal>();
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<ICarDal, EfCarDal>();
            services.AddScoped<IColorDal, EfColorDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IRentalsDal, RentalsDal>();
        }
    }
}
