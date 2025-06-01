using BR_Digital.Models;

namespace BR_Digital.Repository
{
    public static class ChamadoRepository
    {
        private static List<Chamado> ListaChamados { get; set; } = [];

        public static List<Chamado> GetListaChamados()
        {
            return ListaChamados;
        }

        public static void AddChamado(Chamado chamado)
        {
            ListaChamados.Add(chamado);
        }

        public static void DeleteChamado(Chamado chamado)
        {
            ListaChamados.Remove(chamado);
        }

        public static void PopularListaChamado()
        {
            var rand = new Random();
            var clientes = new[] { new Cliente("VIVO"), new Cliente("TIM"), new Cliente("CLARO"), new Cliente("OI") };
            var tiposChamado = new[] { "Backbone-Tx", "Backbone-Rx" };
            var statusChamado = new[] { "Critico", "Importante", "Normal", "Resolvido" };

            for (int i = 0; i < 100; i++)
            {
                var cliente = clientes[rand.Next(0, clientes.Length)];
                var tipoChamado = tiposChamado[rand.Next(0, tiposChamado.Length)];
                var status = statusChamado[rand.Next(0, statusChamado.Length)];
                var data = new DateTime(rand.Next(2020, 2026), rand.Next(1, 13), rand.Next(1, 29), rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60), DateTimeKind.Utc);

                var chamado = new Chamado(cliente, "este / aquele", tipoChamado, status, data);
                ListaChamados.Add(chamado);
            }
        }
    }
}
