using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Identity
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
    public class Role : IdentityRole<Guid>
    {
        // Many to Many Navigation Property
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}
