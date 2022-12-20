using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Services.Mail;
using Desaprendiendo.Services.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Desaprendiendo
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
            services.AddControllersWithViews();
            services.AddRazorPages();
            const string connection = @"Server=tcp:desaprendiendodb.database.windows.net,1433;Initial Catalog=desaprendiendoDB;Persist Security Info=False;User ID=jacintoaisa;Password=P0t@to!!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            services.AddDbContext<DBContextEF>(options => options.UseSqlServer(connection));
            services.AddScoped<ICategoriaRepository, CategoryRepository>();
            services.AddScoped<ISubCategoriaRepository, SubCategoryRepository>();
            services.AddScoped<ICursoRepository, GenericRepository>();
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<ILeccionRepository, LeccionRepository>();
            services.AddScoped<IGenericPhotoRepository<Curso>, GenericPhotoRepository<Curso>>();
            services.AddScoped<IGenericPhotoRepository<Categoria>, GenericPhotoRepository<Categoria>>();
            services.AddScoped<IGenericPhotoRepository<SubCategoria>, GenericPhotoRepository<SubCategoria>>();
            services.AddTransient<IEMail, EMail>();


            services.AddSingleton<IFileProvider>(
                    new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
            services.AddMemoryCache();
            services.AddDistributedMemoryCache();
            //services.AddSession(opts =>
            //{
            //    opts.Cookie.IsEssential = true; // make the session cookie Essential
            //});
            services.Configure<MailConfiguration>(Configuration.GetSection("EmailSettings"));
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            //app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=CategoriaFront}/{action=Index}/{id?}");
            });
        }

    }
    }

