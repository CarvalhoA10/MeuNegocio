namespace Meu_Negocio.Models
{
    internal class EntradaProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CodigoBarras { get; set; } = string.Empty;
        public string NotaFiscal { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public float ValorUnitario { get; set; }
        public DateTime DataNf {  get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
