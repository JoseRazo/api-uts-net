using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace ApiUtsNet.Models

{
    [Table("sistema_pais")]
    public class Pais
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("nombre")]
        public string? Nombre { get; set; }

        [Column("nacionalidad")]
        public string? Nacionalidad { get; set; }

        [Column("abreviatura")]
        public string? Abreviatura { get; set; }
    }
}