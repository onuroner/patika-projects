using FluentValidation.AspNetCore;
using RestfulApi.Extensions;
using Serilog;

namespace RestfulApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Logging implementation
            Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.File("Logs/log.txt", rollingInterval:RollingInterval.Day).CreateLogger();
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductValidator>()).AddNewtonsoftJson();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseGlobalException();
            app.MapControllers();

            app.Run();
        }
    }
}