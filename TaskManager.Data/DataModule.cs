using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

namespace TaskManager.Data
{
    public class DataModule :Module
    {
        private readonly IConfiguration _configuration;

        public DataModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }
         
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new SqliteConnection(_configuration.GetConnectionString("taskManagerConnection")))
                .As<IDbConnection>()
                .InstancePerLifetimeScope();
        }
    }
}
