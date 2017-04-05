namespace practica_de_asp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CURSOS")]
    public partial class CURSO
    {
        [Key]
        [StringLength(10)]
        public string COD_CUR { get; set; }

        [StringLength(30)]
        public string DESCRIPCION { get; set; }

        public int? HORAS { get; set; }

        [StringLength(30)]
        public string TUTOR { get; set; }
    }
}
