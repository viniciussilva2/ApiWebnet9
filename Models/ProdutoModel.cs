namespace ApiWEBNET9.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public int QuantidadeEstoque { get; set; }

        public string CodigoBarras { get; set; } = string.Empty;

        public string Marca { get; set; } = string.Empty;



    }
}
