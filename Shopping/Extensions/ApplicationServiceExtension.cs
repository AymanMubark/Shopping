using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Shopping.Data;
using Shopping.IServices;
using Shopping.Mapper;
using Shopping.Services;

namespace Shopping.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration Configuration)
        {
            //services.Configure<CloudinarySettings>(Configuration.GetSection("CloudinarySettings"));
        //    services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAccountService, AccountService>();
           
            services.AddAutoMapper(typeof(MapperProfile).Assembly);

            services.AddDbContext<DataContext>(option => option.
            UseSqlServer(Configuration.GetConnectionString("Mu3eenContext")));


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Shopping App", Version = "v1" });
                c.AddSecurityDefinition("Bearer",
                 new OpenApiSecurityScheme
                 {
                     In = ParameterLocation.Header,
                     Description = "Bearer Token need to be Inserted..",
                     Name = "Authorization",
                     Type = SecuritySchemeType.ApiKey,
                     Scheme = "Bearer"
                 });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                    {
                        new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }});
            });


            return services;
        }
    }
}
