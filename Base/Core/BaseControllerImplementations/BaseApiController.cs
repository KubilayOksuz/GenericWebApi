using BaseControllerInterfaces;
using BaseDataTransferInterfaces;
using BaseServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseControllerImplementations {
    [ApiController]
    [Route( "api/[controller]/[action]" )]
    public class BaseApiController<TEntity, TRepository> : ControllerBase, IBaseApiController<TEntity>
       where TEntity : class, IBaseDT
       where TRepository : IGenericRepository<TEntity> {
        private readonly TRepository repository;

        public BaseApiController( TRepository repository ) {
            this.repository = repository;
        }
        [HttpGet( "{id}" )]
        public virtual async Task<ActionResult<TEntity>> Read( Guid id ) {
            TEntity baseDt = await repository.Read( id );
            if ( baseDt == null ) {
                return NotFound();
            }
            return baseDt;
        }
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> ReadAll() {
            return await repository.ReadAll();
        }
        [HttpPost]
        public virtual async Task<ActionResult<TEntity>> Create( [FromBody] TEntity entity ) {
            await repository.Create( entity );
            return CreatedAtAction( "Read", new { id = entity.Id }, entity );
        }
        [HttpPut]
        public virtual async Task<ActionResult<TEntity>> Update( [FromBody] TEntity entity ) {
            await repository.Update( entity );
            return CreatedAtAction( "Read", new { id = entity.Id }, entity );
        }
        [HttpDelete( "{id}" )]
        public virtual async Task<ActionResult<TEntity>> Delete( Guid id ) {
            await repository.Delete( id );
            return NoContent();
        }
    }
}