using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity
{
    public interface IBaseEntity 
    {

    }
    public class BaseEntity:IBaseEntity
    {
        public bool Active { get; set; }//true//false//true//false
        public bool Delete { get; set; }//false//false//false//true
        public DateTime Created { get; set; }
        public DateTime Update { get; set; }
        public int Id { get; set; }
    }
}
