namespace WebApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALUMNOS
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
