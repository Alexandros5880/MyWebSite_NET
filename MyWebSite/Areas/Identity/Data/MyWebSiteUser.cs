using Microsoft.AspNetCore.Identity;
using MyWebSite.Areas.Identity.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebSite.Areas.Identity.Data
{
    public class MyWebSiteUser : IdentityUser, IEntity
    {
        public string Password { get; set; }
        public string ConfingPassword { get; set; }
        [NotMapped]
        public ICollection<string> SelectedRolesIds { get; set; }
        [NotMapped]
        public ICollection<string> SelectedRolesForDeleteIds { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastUpdateDate { get; set; }
        public MyWebSiteUser()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
