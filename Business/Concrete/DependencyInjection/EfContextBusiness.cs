using Business.Abstract;
using DataAccess.Concrete.EntityFramework.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.DependencyInjection
{
    public static class EfContextBusiness
    {
        public static void AddScopeBusiness(this IServiceCollection services)
        {
            services.AddScopeDataAccess();
            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<IColorService, ColorManager>();
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IRentalsService, RentalsManager>();
            services.AddScoped<IUserService, UserManager>();
        }
    }
}
