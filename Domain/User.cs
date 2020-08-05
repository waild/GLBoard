
using Microsoft.AspNetCore.Identity;
using Domain.Abstractions;

namespace Domain
{
    public class User : IdentityUser, IEntity<string>
    {
    }
}


