using System;
using System.Collections.Generic;
using System.Text;

namespace Bookcar_demo.Core
{
    public class UserRole
    {
        public int UserId { get; set; }
        public Guid RoleId { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }

    }
}
