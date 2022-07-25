using Renan_Ikeda_Fernandes_d3_avaliacao.Models;
using Renan_Ikeda_Fernandes_d3_avaliacao.Interfaces;

namespace Renan_Ikeda_Fernandes_d3_avaliacao.Repository
{
    internal class Log : ILog
    {
        private const string path = "acessos/log.txt";

        public Log(string path = path)
        {
            CreateFolderAndFile(path);
        }

        private static string PrepareLine(User user, string acao = "logou")
        {
            DateTime now = DateTime.Now;
            string diaFormatado = now.ToString("dd/MM/yyyy");
            string horaFormatada = now.ToString("HH:mm:ss");
            return $"O usuário: {user.Name} {user.Id} {acao} às {horaFormatada} do dia {diaFormatado} \n";
        }

        public static void CreateFolderAndFile(string path)
        {
            string folder = path.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public void RegisterAccess(User user, string acao = "logou")
        {
            string line = PrepareLine(user, acao);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(line);
            }
        }
    }
}
