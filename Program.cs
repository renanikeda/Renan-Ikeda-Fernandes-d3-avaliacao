using Renan_Ikeda_Fernandes_d3_avaliacao.Models;
using Renan_Ikeda_Fernandes_d3_avaliacao.Repository;

namespace Renan_Ikeda_Fernandes_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new();
            AccessDB database = new();
            Log log = new();
            bool cancelar = false;
            string breakLine = "==================================================";
            Console.WriteLine("Bem vindo ao programa de avaliação da disciplina D3 \n" + breakLine);

            while (!cancelar)
            {
                Console.WriteLine("\nEscolha uma das seguintes opções: ");
                Console.WriteLine("1: Acessar o sistema");
                Console.WriteLine("0: Cancelar operação");
                string acesso = Console.ReadLine();
                bool validaUsuario = false;
                
                switch (acesso)
                {
                    case "1":
                        Console.WriteLine("\nInsira seu e-mail: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Insira sua senha: ");
                        string senha = Console.ReadLine();

                        validaUsuario = database.validaUsuario(email, senha);

                        if (!validaUsuario)
                        {
                            Console.WriteLine("\nUsuário ou senha inválidos");
                            Console.WriteLine("Por favor insira novamente as credenciais\n");
                            break;
                        }

                        log.RegisterAccess(user);
                        Console.WriteLine("\nEfetuou o login corretamente");
                        Console.WriteLine("1: Deslogar ");
                        Console.WriteLine("0: Encerrar Sistema ");
                        string login = Console.ReadLine();

                        if (login == "1")
                            log.RegisterAccess(user, "deslogou");
                        else if (login == "0")
                        {
                            Console.WriteLine("Operação encerrada\n");
                            cancelar = true;
                        }
                        break;

                    case "0":
                        Console.WriteLine("Operação Cancelada\n");
                        cancelar = true;
                        break;

                    default:
                        Console.WriteLine("Nenhuma das Opções\n");
                        break;

                }
            }

        }
    }
}