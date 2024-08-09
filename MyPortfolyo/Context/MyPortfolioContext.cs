using Microsoft.EntityFrameworkCore;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Context
{
    public class MyPortfolioContext : DbContext
    {
        // Baglanti stringini verecegim method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            (
                "Server = YUSUFS_DESKTOP;" +
                "initial Catalog = MyPortfolioDb;" +
                "integrated Security = true;"
            );
        }
        // Entityleri veritabanina tablo olarak ekliyoruz. Veritabanina dahil etmek istedigimiz propertyleri burada geciyoruz
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }        
        public DbSet<ToDoList> ToDoLists{ get; set; }        
    }
}
