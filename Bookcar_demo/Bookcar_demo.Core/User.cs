using Bookcar_demo.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bookcar_demo.Core
{
    [Table("User")]
    public class User : BaseEntity
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        public int UserId { get; set; }
        [MaxLength(255)]
        public string Username { get; set; }
        [MaxLength(255)]
        public string Firstname { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string ContactNumber { get; set; }

        public Guid Salt { get; set; }

        [Column(TypeName = "char(64)")]
        public string Password { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<BorrowRecord> BorrowRecords { get; set; }

    }
}
