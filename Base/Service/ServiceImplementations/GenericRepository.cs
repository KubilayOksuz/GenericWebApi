using BaseDataTransferInterfaces;
using BaseServiceInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceImplementations {
    public abstract class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
   where TEntity : class, IBaseDT
   where TContext : DbContext {
        private readonly TContext context;
        public GenericRepository( TContext context ) {
            this.context = context;
        }
        public async Task<TEntity> Create( TEntity entity ) {
            context.Set<TEntity>().Add( entity );
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete( Guid id ) {
            var entity = await context.Set<TEntity>().FindAsync( id );
            if ( entity != null ) {
                context.Set<TEntity>().Remove( entity );
                await context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TEntity> Read( Guid id ) {
            return await context.Set<TEntity>().FindAsync( id );
        }

        public async Task<List<TEntity>> ReadAll() {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update( TEntity entity ) {
            context.Entry( entity ).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }
    }
}