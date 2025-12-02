global using Microsoft.AspNetCore.Identity;
namespace Demo.DataAccess.Models;
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
}
