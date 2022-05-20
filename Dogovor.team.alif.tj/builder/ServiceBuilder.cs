using ConnectionProvider.Context;
using Entity.MailSettings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository;
using Repository.Interfaces;
using Repository.Interfaces.DepartmentRepository;
using Repository.UserRepositories;
using Service.Services;
using Service.Services.MailService;
using System.Text;

namespace Dogovor.team.alif.tj.builder;
public static class ServiceBuilder
{
    public static void MsSql(this IServiceCollection Services, string connectionString)
    {
        Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString, b => b.MigrationsAssembly("ConnectionProvider")).UseLazyLoadingProxies());
    }
    public static void AddAuthentication(this IServiceCollection Services, WebApplicationBuilder builder)
    {
        Services.AddAuthentication(opt =>
        {
            opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
            .AddJwtBearer(cfg =>
            {
                cfg.SaveToken = true;
                cfg.RequireHttpsMetadata = false;

                cfg.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:ValidateAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
                };
            });
    }
    public static void MailSettingServices(this IServiceCollection Services, WebApplicationBuilder builder)
    {
        Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
    }
    public static void CodeResetServices(this IServiceCollection Services)
    {
        Services.AddScoped<ICodeResetRepository, CodeResetRepository>();
        //services.AddScoped<ICodeResetService, CodeResetService>();
    }
    public static void UserServices(this IServiceCollection Services)
    {
        Services.AddScoped<IUserRepository, UserRepository>();
        Services.AddScoped<IUserService, UserService>();
    }
    public static void RoleServices(this IServiceCollection Services)
    {
        Services.AddScoped<IRoleRepository, RoleRepository>();
    }
    public static void MailService(this IServiceCollection Services)
    {
        Services.AddScoped<IMailServices, MailServices>();
    }
    public static void DepartmentServices(this IServiceCollection Services)
    {
        Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        //services.AddScoped<IDepartmentService, UserService>();
    }
}

