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

        public static Chamado? GetChamadoByCodigo(int codigoChamado)
        {
            return ListaChamados.Find(c => c.CodigoChamado == codigoChamado);
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
            var tiposChamado = new[] { "Backbone-Tx", "Backbone-Rx", "Noc-Tx" };
            var statusChamado = new[] { "Critico", "Importante", "Normal", "Concluido", "Fechado" };
            var trechosChamado = new[] { "Cachoeirinha / Gravataí", "Porto Alegre / Cachoeirinha", "Porto Alegre / Alvorada", "Porto Alegre / Canoas" };

            for (int i = 0; i < 100; i++)
            {
                var cliente = clientes[rand.Next(0, clientes.Length)];
                var tipoChamado = tiposChamado[rand.Next(0, tiposChamado.Length)];
                var status = statusChamado[rand.Next(0, statusChamado.Length)];
                var trechos = trechosChamado[rand.Next(0, trechosChamado.Length)];
                var data = new DateTime(rand.Next(2020, 2026), rand.Next(1, 13), rand.Next(1, 29), rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60), DateTimeKind.Utc);

                var chamado = new Chamado(cliente, trechos, tipoChamado, status, data);
                ListaChamados.Add(chamado);
            }
        }
    }
}
