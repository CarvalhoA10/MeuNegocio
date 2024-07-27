namespace Meu_Negocio.Models
{
    internal class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CodigoBarras { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public float PrecoUnitario { get; set; }
        public float PrecoVenda { get; set; }
        public int quantidade { get; set; }
       
    }
}
