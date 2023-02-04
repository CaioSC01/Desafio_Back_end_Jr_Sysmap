using Gerenciamento.Models;

namespace Gerenciamento.Helper
{
    public interface ISessao
    {
        void CriaSessaoDoUsuario(UsuarioModel usurio);
        void RemoverSessaoUsuario();
        UsuarioModel BuscarSessaoDoUsuario();
    }
}
