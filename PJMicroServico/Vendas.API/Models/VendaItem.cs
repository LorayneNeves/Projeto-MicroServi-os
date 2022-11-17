namespace Vendas.API.Models
{
    public class VendaItem
    {
        public int NumeroVenda { get; set; }
        public string Produto { get; set; }
        public int Qtde { get; set; }
        public decimal Preco { get; set; }
    }
}
