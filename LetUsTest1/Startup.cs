﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetUsTest1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LetUsTest1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPicsRepository, MockPicRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World! Is this Azure here?");
            });
            */
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            //app.UseNodeModules(env);

            app.UseMvc(rmd =>
            {
                rmd.MapRoute("Default",
                "{controller}/{action}/{id?}",
                new { controller = "App", Action = "Index" });
            });
        }
    }
}
