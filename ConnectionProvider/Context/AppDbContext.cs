using Entity;
using Entity.Departments;
using Entity.Reset;
using Entity.Roles;
using Entity.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ResetPassword> ResetPasswords { get; set; }
        public DbSet<BankSignatoryData> BankSignatoryDatas { get; set; }
        public DbSet<Citizenship> Citizenships { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contracter> Contracters { get; set; }
        public DbSet<ContragentInfo> ContragentInfos { get; set; }
        public DbSet<LeaseContract> LeaseContracts { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<PlaceAndDateofRelease> PlacesAndDatesofRelease { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
