using ControladorAviao.Models;

namespace ControladorAviao.Repository
{
    public interface IAviaoRepository
    {
        IEnumerable<AviaoModel>Avioes { get; }
        AviaoModel Cadastrar(AviaoModel aviao);
    }
}
