using System;

namespace ApiPagamentos.Model
{
    public class Cartao
    {
        public int Id { get; set; }
        public string titular { get; set; }
        public string numero { get; set; }
        public string data_expiracao { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }
    }
}
