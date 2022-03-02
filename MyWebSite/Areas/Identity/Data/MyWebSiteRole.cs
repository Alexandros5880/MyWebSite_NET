using Microsoft.AspNetCore.Identity;
using MyWebSite.Areas.Identity.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Areas.Identity.Data
{
    public class MyWebSiteRole : IdentityRole, IEntity
    {
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastUpdateDate { get; set; }
        public MyWebSiteRole()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
