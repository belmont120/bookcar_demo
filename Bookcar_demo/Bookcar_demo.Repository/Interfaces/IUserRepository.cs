using Bookcar_demo.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookcar_demo.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        bool CheckUserExists(int userId);
    }
}
