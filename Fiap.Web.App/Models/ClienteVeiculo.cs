namespace Fiap.Web.App.Models
{
    public class ClienteVeiculo
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
