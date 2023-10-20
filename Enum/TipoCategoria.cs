using System.ComponentModel.DataAnnotations;

namespace DesafioConteiner.Enum
{
    public enum TipoCategoria
    {
        [Display(Name = "Exportação")]
        Exportação,
        [Display(Name = "Importação")]
        Importação
    }
}