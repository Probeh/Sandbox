using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Identity
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        // Many to Many Navigation Property
        public virtual IEnumerable<UserRole> UserRoles { get; set; }
    }
}
