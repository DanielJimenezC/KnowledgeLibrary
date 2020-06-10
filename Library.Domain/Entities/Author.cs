using Library.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Entities
{
    public class Author : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Book> Books { get; set; } = new List<Book>();
    }
}
