namespace Renan_Ikeda_Fernandes_d3_avaliacao.Models
{
    internal class User
    {
        public User(int Id, string Name, string Email, string Password)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
        }
        public User()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
