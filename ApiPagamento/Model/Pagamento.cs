namespace ApiPagamentos.Model
{
    public class Pagamento
    {
        public int id { get; set; }
        public int id_compra { get; set; }
        public decimal valor { get; set; }
        public string estado { get; set; }
    }
}
