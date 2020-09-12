using DataTransferImplementations;
using System;

namespace ServiceImplementations {
    public class ArticleRepository : GenericRepository<ArticleDT, CustomDbContext> {
        public ArticleRepository( CustomDbContext context ) : base( context ) {

        }
    }
}