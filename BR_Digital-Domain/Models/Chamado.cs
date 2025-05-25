using BR_Digital_Shared.Enums;

namespace BR_Digital_Domain.Models;

public class Chamado(Cliente cliente, string trecho, TipoChamado tipo, StatusChamado status)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int CodigoChamado { get; set; } = new Random().Next(1, 10000000);
    public Cliente Cliente { get; set; } = cliente;
    public string Trecho { get; set; } = trecho;
    public TipoChamado Tipo { get; set; } = tipo;
    public StatusChamado Status { get; set; } = status;
    public DateTime Abertura { get; set; } = DateTime.Now;
    public TimeSpan Interacao { get; set; } = TimeSpan.Zero;
}
