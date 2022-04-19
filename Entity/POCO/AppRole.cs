using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class AppRole:BaseEntity
    {
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
