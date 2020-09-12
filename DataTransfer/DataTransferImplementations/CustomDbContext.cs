using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferImplementations {
    public class CustomDbContext : DbContext {
        public CustomDbContext( DbContextOptions<CustomDbContext> options ) : base( options ) {
        }
        public DbSet<ArticleDT> Article { get; set; }
    }
}