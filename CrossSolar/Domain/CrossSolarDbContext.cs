using Microsoft.EntityFrameworkCore;

namespace CrossSolar.Domain
{
    public class CrossSolarDbContext : DbContext
    {
        public CrossSolarDbContext()
        {
        }

        public CrossSolarDbContext(DbContextOptions<CrossSolarDbContext> options) : base(options)
        {
        }

        public DbSet<Panel> Panels { get; set; }

        public DbSet<OneHourElectricity> OneHourElectricitys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OneDayElectricityModel>(e => e.Property(s => s.Sum).HasComputedColumnSql("SELECT SUM(dbo.OneHourElectricitys.KiloWatt) From dbo.OneHourElectricitys" +

    " Where(DATEPART(DAY, dbo.OneHourElectricitys.DateTime) = DATEPART(DAY, "+ e.Property(s => s.DateTime)+ ")" +

    " and(DATEPART(MONTH, dbo.OneHourElectricitys.DateTime) = DATEPART(MONTH, " + e.Property(s => s.DateTime) + ")" +

    " and(DATEPART(YEAR, dbo.OneHourElectricitys.DateTime) = DATEPART(YEAR, " + e.Property(s => s.DateTime) + ")"));

            modelBuilder.Entity<OneDayElectricityModel>(e => e.Property(s => s.Average).HasComputedColumnSql("SELECT AVG(dbo.OneHourElectricitys.KiloWatt) From dbo.OneHourElectricitys" +

     " Where(DATEPART(DAY, dbo.OneHourElectricitys.DateTime) = DATEPART(DAY, " + e.Property(s => s.DateTime) + ")" +

     " and(DATEPART(MONTH, dbo.OneHourElectricitys.DateTime) = DATEPART(MONTH, " + e.Property(s => s.DateTime) + ")" +

     " and(DATEPART(YEAR, dbo.OneHourElectricitys.DateTime) = DATEPART(YEAR, " + e.Property(s => s.DateTime) + ")"));

            modelBuilder.Entity<OneDayElectricityModel>(e => e.Property(s => s.Maximum).HasComputedColumnSql("SELECT MAX(dbo.OneHourElectricitys.KiloWatt) From dbo.OneHourElectricitys" +

    " Where(DATEPART(DAY, dbo.OneHourElectricitys.DateTime) = DATEPART(DAY, " + e.Property(s => s.DateTime) + ")" +

    " and(DATEPART(MONTH, dbo.OneHourElectricitys.DateTime) = DATEPART(MONTH, " + e.Property(s => s.DateTime) + ")" +

    " and(DATEPART(YEAR, dbo.OneHourElectricitys.DateTime) = DATEPART(YEAR, " + e.Property(s => s.DateTime) + ")"));

            modelBuilder.Entity<OneDayElectricityModel>(e => e.Property(s => s.Minimum).HasComputedColumnSql("SELECT MIN(dbo.OneHourElectricitys.KiloWatt) From dbo.OneHourElectricitys" +

    " Where(DATEPART(DAY, dbo.OneHourElectricitys.DateTime) = DATEPART(DAY, " + e.Property(s => s.DateTime) + ")" +

    " and(DATEPART(MONTH, dbo.OneHourElectricitys.DateTime) = DATEPART(MONTH, " + e.Property(s => s.DateTime) + ")" +

    " and(DATEPART(YEAR, dbo.OneHourElectricitys.DateTime) = DATEPART(YEAR, " + e.Property(s => s.DateTime) + ")"));



        }


    }
}