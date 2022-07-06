using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magazine_2021.Data;
using Magazine_2021.Data.Mock;
using Magazine_2021.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Magazine_2021
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //Получим строку подключения из файла конфигурации
            string connection = Configuration.GetConnectionString("DefaultConnection");

            //добавим контекст данных в качестве сервиса
            services.AddDbContext<CarContext>(options=>options.UseSqlServer(connection));

            services.AddMvc();
            //services.AddTransient<IAllCars, MockCars>();
            //services.AddTransient<ICarsCategory, MockCategory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); //отображение страничек с ошибками
            app.UseStatusCodePages(); //отображение кодов ошибок на страницах
            app.UseStaticFiles(); //позволяет работать со статическими файлами
            app.UseMvcWithDefaultRoute(); //подключена маршрутизация по умолчанию.
                     //т.е. должен существовать файл index и храниться в папке Home
        }





    }
}
