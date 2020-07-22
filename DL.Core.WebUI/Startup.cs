using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DL.Core.Application;
using DL.Core.Domain.CommandBus;
using DL.Core.Domain.CommandHandler;
using DL.Core.Infrastructure;
using MediatR;
using DL.Core.Domain.Commands.DomainCommands;
using DL.Core.Domain.EventBus;
using DL.Core.Domain.EventBusData;
using DL.Core.Domain.EventBusHanldler;

namespace DL.Core.WebUI
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
            services.AddMediatR(typeof(Startup));
            services.AddScoped<IStudentApplicationService, StudentApplicationSerivce>();
            services.AddScoped<IRequestHandler<StudentResgistCommand, string>, StudentCommandHandler>();
            services.AddScoped<ICommandExecutor, CommandExecutor>();

            ///ÊÂ¼þ
            ///
            services.AddScoped<IEventHandler, DL.Core.Domain.EventBus.EventHandler>();
            services.AddScoped<INotificationHandler<StudentEvent>, StudentEventHandler>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}