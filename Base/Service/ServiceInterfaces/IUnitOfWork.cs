using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseServiceInterfaces {
    public interface IUnitOfWork : IDisposable {
        DbContext context { get; }
        void Commit();
    }
}