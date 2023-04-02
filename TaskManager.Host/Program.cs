using Autofac;
using Autofac.Extensions.DependencyInjection;
using TaskManager.Core;
using TaskManager.Data;

namespace TaskManager.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());


            builder.Host.ConfigureContainer<ContainerBuilder>(containerbuilder =>
            {
                containerbuilder.RegisterModule(new DataModule(builder.Configuration));
                containerbuilder.RegisterModule(new CoreModule());
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}