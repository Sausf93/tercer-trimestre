namespace WebApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CURSOS
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
