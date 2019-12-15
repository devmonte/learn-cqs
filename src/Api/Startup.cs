using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Core.Commands;
using Core.Dispatchers;
using Core.Handlers.Commands;
using Core.Handlers.Queries;
using Core.Models;
using Core.Queries;
using Core.Repositories;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LearnCqs
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<BikeShopDbContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddScoped<DbSeeder>();
            services.AddAutoMapper(options => options.AddProfile<MappingProfile>(), AppDomain.CurrentDomain.GetAssemblies());

            //CQS
            services.AddScoped<IDispatcher, Dispatcher>();
            services.AddScoped<IQueryDispatcher, QueryDispatcher>();
            services.AddScoped<ICommandDispatcher, CommandDispatcher>();
            //CQS queries
            services.AddScoped<IQueryHandler<GetBikes, List<Bike>>, GetBikesHandler>();
            services.AddScoped<IQueryHandler<GetBrands, List<Brand>>, GetBrandsHandler>();
            //CQS commands
            services.AddScoped<ICommandHandler<CreateBrand>, CreateBrandHandler>();
            services.AddScoped<ICommandHandler<CreateBike>, CreateBikeHandler>();
            //Repositories
            services.AddScoped<IBikesRepository, BikesRepository>();
            services.AddScoped<IBrandsRepository, BrandsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
