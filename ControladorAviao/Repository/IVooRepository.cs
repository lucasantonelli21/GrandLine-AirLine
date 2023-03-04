using ControladorAviao.Models;

namespace ControladorAviao.Repository
{
    public interface IVooRepository
    {
        IEnumerable<VooModel> Voos { get; }
        AviaoModel GetAviaoModel(int aviaoId);
        VooModel Cadastrar(VooModel voo);
    }
}
