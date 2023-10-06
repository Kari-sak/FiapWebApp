using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.App.Models
{
    public enum Estado
    {
        SP,
        RJ,
        MG
    }
    public class Produto
    {
        [HiddenInput]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; }
        public int? CategoriaId { get; set; }
        public Estado Estado { get; set; }
        public bool Importado { get; set; }
    }
}
