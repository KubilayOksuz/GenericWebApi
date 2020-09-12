using BaseServiceInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseServiceImplementations {
    public class UnitOfWork : IUnitOfWork {
        public DbContext context { get; }
        public UnitOfWork( DbContext context ) {
            this.context = context;
        }
        public void Commit() {
            context.SaveChanges();
        }
        public void Dispose() {
            context.Dispose();
        }
    }
}