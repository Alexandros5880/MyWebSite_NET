using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyWebSite.Areas.Identity.Data;
using MyWebSite.Areas.Identity.Repositories;
using MyWebSite.Areas.Identity.Repositories.Interfaces;
using MyWebSite.AutoMapperProfiles;
using MyWebSite.Data;
using MyWebSite.Data.Models;
using MyWebSite.HorizontalClasses;
using MyWebSite.HorizontalClasses.Interfaces;
using MyWebSite.Repositories;
using MyWebSite.Repositories.Interface;

namespace MyWebSite
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

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("ProstreSQLContext")));

            services.AddDatabaseDeveloperPageExceptionFilter();


            //services.AddDefaultIdentity<MyWebSiteUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddRoles<MyWebSiteRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddDefaultIdentity<MyWebSiteUser>()
                .AddRoles<MyWebSiteRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddRazorPages();


            // API Related Records Cicly
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );



            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);


            //                                       Dependency Injection
            // Transient objects are always different; a new instance is provided to every controller and every service.
            // Scoped objects are the same within a request, but different across different requests.
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            //services.AddTransient<IApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<IRepository<CV>, CvRepository>();
            services.AddScoped<IRepository<Image>, ImageRepository>();
            services.AddScoped<IRepository<Message>, MessageRepository>();
            services.AddScoped<IRepository<Project>, ProjectRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IRolesRepository, RolesRepository>();
            services.AddScoped<IRepository<HomeData>, HomeDataRepository>();
            services.AddScoped<IRepository<ContactData>, ContactDataRepository>();
            services.AddScoped<IRepository<Order>, OrderRepository>();
            services.AddScoped<IRepositoriesHundler, RepositoriesHundler>();
            services.AddScoped<IEmailTool, EmailTool>();
            services.AddScoped<FilesTools>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                
                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Projects}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
