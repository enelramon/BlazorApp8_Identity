using Microsoft.AspNetCore.Identity;

namespace BlazorApp_Identity.Data;
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser<int>
{
}public class ApplicationRole : IdentityRole<int>
{
}

