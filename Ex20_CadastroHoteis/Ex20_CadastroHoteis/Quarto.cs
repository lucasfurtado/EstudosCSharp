namespace Ex20_CadastroHoteis
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

        public Quarto(string nome, string email, int numero)
        {
            Nome = nome;
            Email = email;
            NumeroQuarto = numero;
        }

        public override string ToString()
        {
            return NumeroQuarto + ": " + Nome + ", " + Email;
        }
    }
}
