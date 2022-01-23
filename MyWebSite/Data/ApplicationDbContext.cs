﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Areas.Identity.Data;
using MyWebSite.Data.Models;

namespace MyWebSite.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyWebSiteUser>, IApplicationDbContext
    {

        public DbSet<CV> CVs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Project> Projects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

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
            builder.Entity<CV>().HasData(new CV() { ID = 1, IsActive = true, Description = "My CV", Path = "/CV/CV.pdf" });

            // Add Projects
            builder.Entity<Project>().HasData(new Project() { ID = 1, Title="CBProject", Description= "Online School For Data Sience." });
            builder.Entity<Project>().HasData(new Project() { ID = 2, Title = "Economy", Description = "Salesforce App To Manipulate Your Wallet." });
            builder.Entity<Project>().HasData(new Project() { ID = 3, Title = "Eelementum", Description = "WordPress WebSite For KungFou School." });
            builder.Entity<Project>().HasData(new Project() { ID = 4, Title = "Elevators Dashboard", Description = "A B&B App For Elevator Maintence Company." });
            builder.Entity<Project>().HasData(new Project() { ID = 5, Title = "Elevators Managment", Description = "A B&B App For Elevator Maintence Company." });
            builder.Entity<Project>().HasData(new Project() { ID = 6, Title = "IPCameras Dashboard", Description = "IPCameras Security Software." });
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
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/ElevatorDash/img_{i}.png", ProjectId = 4 });
                id++;
            }
            // Elevators Managment System Project
            for (int i = 1; i < 3; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/ElevatorsManagmentSystem/img_{i}.png", ProjectId = 5 });
                id++;
            }
            // IPCamerasDashboard Project
            for (int i = 1; i < 16; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/IPCamerasDashboard/img_{i}.png", ProjectId = 6 });
                id++;
            }
            // RemoteAutoMoto Project
            for (int i = 1;i < 4 ; i++)
            {
                builder.Entity<Image>().HasData(new Image() { ID = id, ImagePath = $"~/ProjectImages/RemoteAutoMoto/img_{i}.png", ProjectId = 7 });
                id++;
            }

        }

    }
}
