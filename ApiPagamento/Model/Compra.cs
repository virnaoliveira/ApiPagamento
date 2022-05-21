namespace ApiPagamentos.Model
{
    public class Compra
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public Cartao cartao { get; set; }
    }
}
