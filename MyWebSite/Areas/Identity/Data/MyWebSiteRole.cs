using Microsoft.AspNetCore.Identity;
using MyWebSite.Areas.Identity.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Areas.Identity.Data
{
    public class MyWebSiteRole : IdentityRole, IEntity
    {
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }
        public MyWebSiteRole()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
