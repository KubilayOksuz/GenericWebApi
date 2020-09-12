using BaseDataTransferInterfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseServiceInterfaces {
    public interface IGenericRepository<T> where T : class, IBaseDT {
        Task<List<T>> ReadAll();
        Task<T> Read( Guid id );
        Task<T> Create( T entity );
        Task<T> Update( T entity );
        Task<T> Delete( Guid id );
    }
}