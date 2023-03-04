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

        public AviaoModel GetAviaoModel(int aviaoId) => _context.Avioes.FirstOrDefault(i => i.aviaoId == aviaoId);
        public VooModel Cadastrar(VooModel voo)
        {
            _context.Voos.Add(voo);
            _context.SaveChanges();
            return voo;
        }


        
    }
}
