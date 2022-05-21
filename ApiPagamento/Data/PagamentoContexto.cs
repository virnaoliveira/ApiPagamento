using ApiPagamentos.Model;
using Microsoft.EntityFrameworkCore;

namespace DesafioApiCompras.Data
{
    public class PagamentoContexto : DbContext
    {
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }

        public PagamentoContexto(DbContextOptions<PagamentoContexto> options) : base(options){ }
    }
}
