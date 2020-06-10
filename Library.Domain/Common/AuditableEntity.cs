using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Common
{
    public abstract class AuditableEntity
    {
        public DateTime CreateAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
