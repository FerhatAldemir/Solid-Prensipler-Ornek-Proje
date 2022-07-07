using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccessLayer.absraction;
using Example.DataAccessLayer.Concrete;
using Example.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace Example.BussinesLayer.IOC
{
    public static class IOC
    {
        public static IServiceProvider ConfigRepoStory(this ServiceCollection services)
        {   
            services.AddTransient<IinvoiceDal, InvoiceDal>();

            services.AddSingleton<ICheckDatabase, CheckDataBase>();

            if (Global.GetInstance().CurrentDatabase == DatabaseTypes.Mssql)
            {
                services.AddTransient<DbContext, MssqlContext>();
            }
            else if (Global.GetInstance().CurrentDatabase == DatabaseTypes.SqlLite)
            {
                services.AddTransient<DbContext, SqlLiteContext>();
            }


            return services.BuildServiceProvider();
        }
    }
}
