using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bookcar_demo.Core
{
    [Table("Role")]
    public class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        public Guid RoleId { get; set; }

        [MaxLength(255)]
        public string RoleName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }


    }
}
