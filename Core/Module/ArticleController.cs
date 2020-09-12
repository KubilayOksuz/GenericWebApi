using BaseControllerImplementations;
using DataTransferImplementations;
using Microsoft.AspNetCore.Mvc;
using ServiceImplementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Module {
    public class ArticleController : BaseApiController<ArticleDT, ArticleRepository> {
        ArticleRepository repository;
        public ArticleController( ArticleRepository repository ) : base( repository ) {
            this.repository = repository;
        }
        [HttpDelete]
        public async Task<ActionResult<ArticleDT>> DeleteAll() {
            List<ArticleDT> entities = await repository.ReadAll();
            foreach ( ArticleDT entity in entities ) {
                await repository.Delete( entity.Id );
            }
            return NoContent();
        }
    }
}