using BaseDataTransferInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseControllerInterfaces {
    public interface IBaseApiController<TEntity> where TEntity : class, IBaseDT {
        Task<ActionResult<TEntity>> Read( Guid id );
        Task<ActionResult<IEnumerable<TEntity>>> ReadAll();
        Task<ActionResult<TEntity>> Create( TEntity entity );
        Task<ActionResult<TEntity>> Update( TEntity entity );
        Task<ActionResult<TEntity>> Delete( Guid id );
    }
}