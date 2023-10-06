namespace Fiap.Web.App.Models
{
    public class Cliente
    {
        //public string Nome { get; set; }
        //public string Sobrenome { get; set; }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Qualificacao> Qualificacao { get; set; }

        //one to one
        public CarteiraMotorista Cnh { get; set; }
        public int CarteiraMotoristaId { get; set; }
    }
