using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFPoc
{
    public class EntityBase
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("dataCriacao")]
        public DateTime DataCriacao { get; set; }
        [Column("operationId")]
        public Guid OperationId { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
    }
}
