namespace BR_Digital.Models;

public class Cliente(string nome)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int CodigoCliente { get; set; } = new Random().Next(1, 100000);
    public string Nome { get; set; } = nome;
}
