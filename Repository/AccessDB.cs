using System.Collections.Generic;
using Renan_Ikeda_Fernandes_d3_avaliacao.Models;
using Renan_Ikeda_Fernandes_d3_avaliacao.Interfaces;
using System.Data.SqlClient;

namespace Renan_Ikeda_Fernandes_d3_avaliacao.Repository
{
    internal class AccessDB : IAccessDB
    {
        private readonly string stringConexao = "Data source=LAPTOP-9P1ALKJS\\SQLEXPRESS; initial catalog=User; integrated security=true;";

        public bool validaUsuario(string email, string senha)
        {
            List<User> users = this.ReadAll();
            
            foreach(User user in users)
            {
                if (user.Email == email && user.Password == senha)
                    return true;
            }

            return false;
        }
        public List<User> ReadAll()
        {
            List<User> listUsers = new();

            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT * FROM Users";

                connection.Open();

                using (SqlCommand cmd = new(querySelectAll, connection))
                {
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        User user = new User(
                            Id: Convert.ToInt32(rdr["IdUser"]), 
                            Name: rdr["Name"].ToString(), 
                            Email: rdr["Email"].ToString(), 
                            Password: rdr["Password"].ToString()
                        );

                        listUsers.Add(user);
                    }
                }
            }

            return listUsers;
        }
    }
}