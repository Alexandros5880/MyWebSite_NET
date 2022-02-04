using Microsoft.AspNetCore.Identity;
using MyWebSite.Areas.Identity.Data.Interfaces;
using System.Collections.Generic;
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
    }
}
