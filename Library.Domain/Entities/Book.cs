using Library.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Entities
{
    public class Book : AuditableEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Isbn { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public int PublishAt { get; set; }
        public int EditorialId { get; set; }
        public int AuthorId { get; set; }
        public int PresentationId { get; set; }
        public int LanguageId { get; set; }

        public Author Author { get; set; }
        public Editorial Editorial { get; set; }
        public Language Language { get; set; }
        public Presentation Presentation { get; set; }
        public IList<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    }
}
