using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Areas.Identity.Data;
using MyWebSite.Data.Models;
using System;

namespace MyWebSite.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyWebSiteUser, MyWebSiteRole, string>, IApplicationDbContext
    {
        [Obsolete]
        private IHostingEnvironment _environment;

        public DbSet<CV> CVs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<HomeData> HomeData { get; set; }
        public DbSet<ContactData> ContactData { get; set; }
        public DbSet<Order> Orders { get; set; }

        [Obsolete]
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHostingEnvironment _environment)
            : base(options)
        {
            this._environment = _environment;
        }

        [Obsolete]
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            // Configure Relationships
            builder.Entity<Project>()
                .HasMany(p => p.Images)
                .WithOne(i => i.Project);

            builder.Entity<Image>()
                .HasOne(i => i.Project)
                .WithMany(p => p.Images);



            // Add seed Data

            // Add CV
            builder.Entity<CV>().HasData(new CV() { ID = 1, IsActive = true, Description = "My CV", CVPath = "/CV/CV.pdf" });

            // Add Projects
            builder.Entity<Project>().HasData(new Project() { ID = 1, Title="CBProject", Description= "Online School For Data Sience.", Price = 33.03m, DownloadLinkZip= "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.zip", DownloadLinkTar= "https://github.com/Alexandros5880/CBProject/archive/refs/tags/v1.0.tar.gz" });
            builder.Entity<Project>().HasData(new Project() { ID = 2, Title = "Economy", Description = "Salesforce App To Manipulate Your Wallet." });
            builder.Entity<Project>().HasData(new Project() { ID = 3, Title = "Eelementum", Description = "WordPress WebSite For KungFou School.", WebPage = "https://elementumartialfitness.com" });
            builder.Entity<Project>().HasData(new Project() { ID = 4, Title = "Elevators Managment", Description = "A B&B App on Salesforce For Elevator Maintence Company.", DownloadLinkZip = "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.zip", DownloadLinkTar = "https://github.com/Alexandros5880/ElevatorsManagement/archive/refs/tags/v1.0.tar.gz" });
            builder.Entity<Project>().HasData(new Project() { ID = 5, Title = "Elevators Dashboard", Description = "A B&B App writen in Java For Elevator Maintence Company.", WebPage = "https://alexandrosplatanios15-dev-ed.lightning.force.com/lightning/n/Work_Managment_Desktop" });
            builder.Entity<Project>().HasData(new Project() { ID = 6, Title = "IPCameras Dashboard", Description = "IPCameras Security Software.", DownloadLinkZip = "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.zip", DownloadLinkTar = "https://github.com/Alexandros5880/ESP32-Cam-Dashboard/archive/refs/tags/v1.0.tar.gz" });
            builder.Entity<Project>().HasData(new Project() { ID = 7, Title = "Remote Auto Moto", Description = "Update Your Old Vichecle To Full Software Update." });

            // Add Images
            int id = 1;
            // CB Project
            for (int i = 1; i < 31; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/CBProject/img_{i}.png", ProjectId = 1 });
                id++;
            }
            // Economy Project
            for (int i = 1; i < 8; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/Economy/img_{i}.png", ProjectId = 2 });
                id++;
            }
            // Elementum Project
            for (int i = 1; i < 13; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/Elementum/img_{i}.png", ProjectId = 3 });
                id++;
            }
            // ElevatorDash Project
            for (int i = 1; i < 15; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/ElevatorManagment/img_{i}.png", ProjectId = 4 });
                id++;
            }
            // Elevators Managment System Project
            for (int i = 1; i < 3; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/ElevatorDashboard/img_{i}.png", ProjectId = 5 });
                id++;
            }
            // IPCamerasDashboard Project
            for (int i = 1; i < 16; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/IPCamerasDashboard/img_{i}.png", ProjectId = 6 });
                id++;
            }
            // RemoteAutoMoto Project
            for (int i = 1; i < 3 ; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/RemoteAutoMoto/img_{i}.png", ProjectId = 7 });
                id++;
            }




            // Create Home Data
            string subPath = "/img/home/me.jpg";
            string path = "";
            builder.Entity<HomeData>().HasData(
                new HomeData()
                {
                    ID = 1,
                    Title = "Hello",
                    SubTitle = "A bot about me",
                    Paragraph = "I'm a paragraph. Click here to add your own text and edit me. I’m a great place for you to tell a story and let your users know a little more about you.",
                    ImagePath = subPath,
                    ImageFullPath = path,
                    IsActive = true,
                    CreatedDate = DateTime.Today
                }
            );
            // Create Contact Data
            builder.Entity<ContactData>().HasData(
                new ContactData()
                {
                    ID = 1,
                    Title = "Contact us",
                    SubTitle = "Do you have any questions? Please do not hesitate to contact us directly. Our team will come back to you within a matter of hours to help you.",
                    AddressMap = "https://maps.google.com/maps?q=Greece%20Voula%20Fleming%2014%2016673&t=&z=17&ie=UTF8&iwloc=&output=embed",
                    Address = "Fleming 14, Voula, 16673, Greece",
                    Phone = "+30-6949277783",
                    Email = "alexandrosplatanios28@gmail.com",
                    FacebookLink = "https://www.facebook.com/profile.php?id=100013059701658",
                    InstagramLink = "https://www.instagram.com/alexandros_platanios/",
                    LinkedLin = "https://www.linkedin.com/in/alexandros-platanios-723984203/",
                    FullName = "Alexandros Platanios",
                    IsActive = true,
                    CreatedDate = DateTime.Today
                }
            );



            // Add Role && User
            var hasher = new PasswordHasher<MyWebSiteUser>();
            const string USER_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ID = "ad376a8f-9eab-4bb9-9fca-30b01540f445";
            builder.Entity<MyWebSiteRole>().HasData(new MyWebSiteRole()
            {
                Id = ROLE_ID,
                Name = "Admin",
                NormalizedName = "Admin"
            });
            builder.Entity<MyWebSiteUser>().HasData(new MyWebSiteUser() {
                Id = USER_ID,
                Email = "alexandrosplatanios15@gmail.com",
                NormalizedEmail = "alexandrosplatanios15@gmail.com",
                UserName = "alexandrosplatanios15@gmail.com",
                NormalizedUserName = "alexandrosplatanios15@gmail.com",
                PhoneNumber ="6949277783",
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                PasswordHash = hasher.HashPassword(null, "-Platanios719791"),
                SecurityStamp = string.Empty,
                Password = "-Platanios719791",
                ConfingPassword = "-Platanios719791"
            });
            // Connect this User with this Role
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = USER_ID
            });

        }

    }
}
