using ControladorAviao.Models;

namespace ControladorAviao.Repository
{
    public interface IVooRepository
    {
        IEnumerable<VooModel> Voos { get; }
    }
}
