using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DesafioConteiner.Enum;


namespace DesafioConteiner.Models
{
    public class Movimentacao
    {
        [Key]
        public int IdMovimentacao {get; set;}

        [Required]
        public DateTime DataHoraInicio {get; set;}

        [Required]
        public DateTime DataHoraFim {get; set;}

        [Required]
        [EnumDataType(typeof(TipoMovimentacao))]
        public string TipoMovimentacao {get; set;}

        [Required]
        public int IdConteiner {get; set;}

        [JsonIgnore]
        public Conteiner Conteiner {get; set;}
    }
}