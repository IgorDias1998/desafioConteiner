using System.ComponentModel.DataAnnotations;

namespace DesafioConteiner.Enum
{
    public enum TipoConteiner
    {
        [Display(Name = "VintePes")]
        VintePes,
        [Display(Name = "QuarentaPes")]
        QuarentaPes
    }
}