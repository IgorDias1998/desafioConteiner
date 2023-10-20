using System.ComponentModel.DataAnnotations;

namespace DesafioConteiner.Enum
{
    public enum TipoStatus
    {
        [Display(Name = "Cheio")]
        Cheio,
        [Display(Name = "Vazio")]
        Vazio
    }
}