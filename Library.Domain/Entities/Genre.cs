using Library.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Entities
{
    public class Genre : AuditableEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public IList<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    }
}
