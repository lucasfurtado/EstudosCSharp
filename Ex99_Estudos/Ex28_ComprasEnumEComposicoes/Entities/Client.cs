using System;

namespace Ex28_ComprasEnumEComposicoes.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return string.Concat("Client: ", Name, $" ({BirthDate.ToString("dd/MM/yyyy")}) - ",Email);
        }
    }
}
