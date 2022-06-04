using ConnectionProvider.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.MsSql(connectionString);
builder.Services.AddAuthentication(builder);
//builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString, b => b.MigrationsAssembly("ConnectionProvider")).UseLazyLoadingProxies());
builder.Services.MailSettingServices(builder);
builder.Services.CodeResetServices();
builder.Services.UserServices();
builder.Services.RoleServices();
builder.Services.MailService();
builder.Services.LeaseServices();
builder.Services.DepartmentServices();
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dataContext.Database.MigrateAsync();
}
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
