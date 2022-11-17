namespace Vendas.API.Models
{
    public class Venda
    {
        public int Numero { get; set; }
        public DateTime DataVenda { get; set; }
        public String NomeCliente { get; set; }

        public StatusVenda StatusVenda { get; set; }
        
        ICollection<VendaItem> vendaItems { get; set; } 
    }
}
