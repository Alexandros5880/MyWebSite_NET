using Microsoft.AspNetCore.Identity;
using MyWebSite.Areas.Identity.Data.Interfaces;

namespace MyWebSite.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MyWebSiteUser class
    public class MyWebSiteUser : IdentityUser, IEntity
    {

    }
}
