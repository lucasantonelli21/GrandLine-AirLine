using ControladorAviao.Context;
using ControladorAviao.Models;

namespace ControladorAviao.Repository
{
    public class VooRepository : IVooRepository
    {
        private readonly AppDbContext _context;
        public VooRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<VooModel> Voos => _context.Voos;
    }
}
