namespace Fiap.Web.App.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Modelo { get; set; }
        public ICollection<ClienteVeiculo> ClienteVeiculo { get; set; }
    }
}
