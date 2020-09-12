using System;
using System.ComponentModel.DataAnnotations;

namespace BaseDataTransferInterfaces {
    public interface IBaseDT {
        [Key]
        Guid Id { get; set; }
        DateTime CreatedDate { get; set; }
    }
}