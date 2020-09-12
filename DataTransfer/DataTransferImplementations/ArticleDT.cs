using BaseDataTransferInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferImplementations {
    public class ArticleDT : IBaseDT {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength( 64, MinimumLength = 3 )]
        [Column( TypeName = "VARCHAR(64)" )]
        public string Title { get; set; }

        [Required]
        [Column( TypeName = "VARCHAR(MAX)" )]
        public string Content { get; set; }
    }
}