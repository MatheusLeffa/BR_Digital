namespace BR_Digital_Domain.Models;

public class Cliente(string nome)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int CodigoCliente { get; set; }
    public string Nome { get; set; } = nome;
}
