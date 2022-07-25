using Renan_Ikeda_Fernandes_d3_avaliacao.Models;

namespace Renan_Ikeda_Fernandes_d3_avaliacao.Interfaces
{
    internal interface IAccessDB
    {
        public bool validaUsuario(string email, string senha);
        public List<User> ReadAll();
    }
}
