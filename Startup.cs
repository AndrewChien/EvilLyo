using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EvilLyo.Models;

namespace EvilLyo
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
            //Use CodeFirst，使用依赖注入将服务（EF的数据库上下文）注入。这些服务的组件(如MVC控制器)通过构造函数的参数实现。
            //var connection = Configuration.GetConnectionString("MySqlConnection");//注意：centos上无法解析
            var connection = "Data Source=127.0.0.1;Database=yirenzonghe;User ID=root;Password=uAiqwVwjJ8-i;pooling=true;CharSet=utf8;port=3306;sslmode=none";
            services.AddDbContext<DataContext>(options => options.UseMySql(connection));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
