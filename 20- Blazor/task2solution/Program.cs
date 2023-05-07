
using Microsoft.EntityFrameworkCore;

namespace BlazorDay2Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
       options.AddPolicy("myPolicy", PolicyOptions =>
                   PolicyOptions.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())
       );
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Task2Context>(op => op.UseSqlServer("data source=.;initial catalog=blazortask2;integrated security=true;encrypt=false"));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("myPolicy");
            app.MapControllers();

            app.Run();
        }
    }
}