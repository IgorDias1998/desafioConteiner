using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DesafioConteiner.Enum;

namespace DesafioConteiner.Models
{
    public class Conteiner
    {
        [Key]
        public int IdConteiner {get; set;}

        [Required]
        public string Cliente {get; set;}

        [Required]
        [RegularExpression("^[A-Z]{4}[0-9]{7}")]
        public string NumeroConteiner {get; set;}

        [Required]
        [EnumDataType(typeof(TipoConteiner))]
        public string TipoConteiner {get; set;}

        [Required]
        [EnumDataType(typeof(TipoStatus))]
        public string TipoStatus {get; set;}

        [Required]
        [EnumDataType(typeof(TipoCategoria))]
        public string TipoCategoria {get; set;}
    }
}