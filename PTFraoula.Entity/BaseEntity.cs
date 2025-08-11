using PTFraoula.Core.Abstracts;
using PTFraoula.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTFraoula.Entity
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int AutoID { get; set; }
    }
}
