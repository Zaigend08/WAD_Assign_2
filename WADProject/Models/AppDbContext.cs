using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WADProject.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<DonorModel>? DonorData { get; set; }
        public DbSet<RecipientModel>? RecipientData { get; set; }
        public DbSet<BloodCollectionModel>? bloodCollectData { get; set; }
        public DbSet<BloodRequestModel>? bloodReqData { get; set; }
        public DbSet<BloodIssuedModel>? bloodIssuedData { get; set; }
        public DbSet<userAccountsModel>? Accounts { get; set; }
        public DbSet<logsModel>? logsData { get; set; }
    }
}
