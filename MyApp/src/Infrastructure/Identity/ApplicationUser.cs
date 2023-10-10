using Microsoft.AspNetCore.Identity;

namespace MyApp.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }
    public string? Family { get; set; }
}
