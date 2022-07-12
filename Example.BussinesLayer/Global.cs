using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccessLayer.Concrete;
using Example.DataAccessLayer.absraction;

namespace Example.BussinesLayer
{
    public class Global
    {
       
        private static Global Instance {get;set;}

        internal IServiceProvider Service { get; private set; }

        internal DatabaseTypes CurrentDatabase { get; set; }

        public static Global GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Global();
                Instance.CurrentDatabase = DatabaseTypes.Mssql;
                Instance.Service = IOC.IOC.ConfigRepoStory(new ServiceCollection());
                
                ICheckDatabase Check = Instance.Service.GetService<ICheckDatabase>();
                Check.MigrationDatase();
            }


            return Instance;

        }

    }
}
