using System.ComponentModel.DataAnnotations;

namespace DesafioConteiner.Enum
{
    public enum TipoMovimentacao
    {
        [Display(Name = "embarque")]
        embarque,
        [Display(Name = "descarga")]
        descarga,
        [Display(Name = "gatein")]
        gatein,
        [Display(Name = "gateout")]
        gateout,

        [Display(Name = "reposicionamento")]
        reposicionamento,

        [Display(Name = "pesagem")]
        pesagem,

        [Display(Name = "scanner")]
        scanner
    }
}