using System;
using System.Collections.Generic;
using AmazonWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace AmazonWebsite.Context;

public partial class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options) { }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.BookId, "IX_Books_BookID").IsUnique();

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
