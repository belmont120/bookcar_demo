using Bookcar_demo.Core;
using Bookcar_demo.Repository.Contexts;
using Bookcar_demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookcar_demo.Repository
{
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}
