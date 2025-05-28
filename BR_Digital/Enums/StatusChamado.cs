using System.ComponentModel.DataAnnotations;

namespace BR_Digital.Enums;

//TODO: Ajustar com valores reais
public enum StatusChamado
{
    [Display(Name = "Status Teste")]
    StatusTeste = 0,
    [Display(Name = "Status Teste 2")]
    StatusTeste2 = 1,
    [Display(Name = "Status Teste 3")]
    StatusTeste3 = 2
}
