using Library.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Entities
{
    public class Language : AuditableEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public IList<Book> Books { get; set; } = new List<Book>();
    }
}
