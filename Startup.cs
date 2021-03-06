﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyCourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IApplicationLifetime lifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                lifetime.ApplicationStarted.Register(()=>{
                    string filePath=Path.Combine(env.ContentRootPath,"bin/reload.txt"); //collega a un file di testo
                    File.WriteAllText(filePath,DateTime.Now.ToString());

                });
            }
 
            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();  //tutto sotto poteva essere sintetizzato cosi
            
            app.UseMvc(routeBuilder =>
            {
                
                routeBuilder.MapRoute("default","{controller=Home}/{action=Index}/{id?}");

            } );
        
        }
    }
}
