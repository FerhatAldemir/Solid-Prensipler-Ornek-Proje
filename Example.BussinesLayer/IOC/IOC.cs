using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccessLayer.absraction;
using Example.DataAccessLayer.Concrete;
using Example.DataAccessLayer.Context;
using Example.DataAccessLayer.RepoStoryAbsraction;
using Example.DataAccessLayer.RepoStoryConcrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Linq;

namespace Example.BussinesLayer.IOC
{
    public static class IOC
    {
        public static IServiceProvider ConfigRepoStory(this IServiceCollection services)
        {


           // services.AddTransient(typeof(DataAccessLayer.absraction.IinvoiceDal),typeof(DataAccessLayer.Concrete.InvoiceDal));
            services.AddSingleton<ICheckDatabase, CheckDataBase>();
           
           
            TypeInfo[] TypeRepo = Assembly.
                GetExecutingAssembly().
                GetReferencedAssemblies().
                Select(Assembly.Load).
                SelectMany(x => x.DefinedTypes).
                Where(
                x=>x.ImplementedInterfaces.Any(y=>y.Name.Contains("IRepo")) 
                
                ).
                ToArray();
           
            services.RegisterTypes(TypeRepo, ServiceLifetime.Transient);
           
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

        private static void RegisterTypes(this IServiceCollection Service, TypeInfo[] typeInfo, ServiceLifetime serviceLifetime)
        {
            TypeInfo[] ClassTypes = typeInfo.Where(x => x.IsClass).ToArray();
            TypeInfo[] InterFacesTyps = typeInfo.Where(x => x.IsInterface).ToArray();
            foreach (TypeInfo _Type in InterFacesTyps)
            {
                var Class = ClassTypes.FirstOrDefault(x=>x.ImplementedInterfaces.Any(y=>y.GetTypeInfo() == _Type.GetTypeInfo()));
               Service.AddTransient(_Type.GetTypeInfo(), Class.GetTypeInfo());
                

            }


        }
    }
}
