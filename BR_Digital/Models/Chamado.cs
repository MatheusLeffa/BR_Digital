using BR_Digital.Enums;

namespace BR_Digital.Models;

public class Chamado
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int CodigoChamado { get; set; } = new Random().Next(1, 1000000000);
    public Cliente Cliente { get; set; }
    public string Trecho { get; set; }
    public TipoChamado Tipo { get; set; }
    public StatusChamado Status { get; set; }
    public DateTime Abertura { get; set; } = DateTime.Now;
    public TimeSpan Interacao { get; set; } = TimeSpan.Zero;

    public Chamado(Cliente cliente, string trecho, TipoChamado tipo, StatusChamado status)
    {
        Cliente = cliente;
        Trecho = trecho;
        Tipo = tipo;
        Status = status;
    }

    public Chamado(Cliente cliente, string trecho, TipoChamado tipo, StatusChamado status, DateTime abertura)
    {
        Cliente = cliente;
        Trecho = trecho;
        Tipo = tipo;
        Status = status;
        Abertura = abertura;
    }
}
