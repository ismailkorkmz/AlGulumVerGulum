using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class UserRole
    {
        public int AppUserId { get; set; }
        public int AppRoleId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual AppRole AppRole { get; set; }
    }
}
