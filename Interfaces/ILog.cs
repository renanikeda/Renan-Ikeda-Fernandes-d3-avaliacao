using Renan_Ikeda_Fernandes_d3_avaliacao.Models;

namespace Renan_Ikeda_Fernandes_d3_avaliacao.Interfaces
{
    internal interface ILog
    {
        public void RegisterAccess(User user, string acao);
        private const string path = "acessos/log.txt";
    }
}
