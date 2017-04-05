namespace practica_de_asp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALUMNOS")]
    public partial class ALUMNO
    {
        [Key]
        [StringLength(10)]
        public string COD_ALU { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_CUR { get; set; }

        [StringLength(10)]
        public string DNI { get; set; }

        [StringLength(30)]
        public string APELLIDOS { get; set; }

        [StringLength(20)]
        public string NOMBRE { get; set; }
    }
}
