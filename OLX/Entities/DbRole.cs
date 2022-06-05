using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace OLX.Entities
{
    public class DbRole : IdentityRole<int>
    {
        public ICollection<DbUserRole> UserRoles { get; set; }
    }
}