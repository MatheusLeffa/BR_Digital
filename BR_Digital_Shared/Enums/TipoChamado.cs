using System.ComponentModel.DataAnnotations;

namespace BR_Digital_Shared.Enums;

public enum TipoChamado
{
    [Display(Name = "Backbone-Tx")]
    Backbone_Tx = 0,

    [Display(Name = "Backbone-Rx")]
    Backbone_Rx = 1
}
