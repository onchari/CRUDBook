using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOOKCRUD.DbEntities
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<Book> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(name => name.Name).IsRequired();
            entityTypeBuilder.Property(isbn => isbn.ISBN).IsRequired();
            entityTypeBuilder.Property(author => author.Author).IsRequired();
            entityTypeBuilder.Property(publisher => publisher.Publisher).IsRequired();
        }
    }
}
