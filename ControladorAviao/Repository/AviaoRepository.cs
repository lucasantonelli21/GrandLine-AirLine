using ControladorAviao.Context;
using ControladorAviao.Models;
using Microsoft.Data.SqlClient;

namespace ControladorAviao.Repository
{
    public class AviaoRepository : IAviaoRepository
    {
        private readonly AppDbContext _context;
        public AviaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AviaoModel> Avioes => _context.Avioes;

        public AviaoModel Cadastrar(AviaoModel aviao)
        {
            _context.Avioes.Add(aviao);
            _context.SaveChanges(); 
            return aviao;
        }
    }
}
