public class Pessoa
{
    public string Nome { get; set; } // Metodos são autoimplementados pelo C#
    public int Idade { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    private string _email;
    public string Email {
        get {
            // Lógica adicional no método get
            return _email.ToLower(); // Retorna o nome em letras maiúsculas
        }
        set {
            // Lógica adicional no método set
            _email = value.Trim();  // Remove espaços em branco do valor antes de atribuí-lo ao atributo Email
        }
    }

    public void Apresentar()
    {
        Console.WriteLine("Olá, eu sou " + Nome + " e tenho " + Idade + " anos.");
    }

    public void EnviarEmail(string mensagem)
    {
        Console.WriteLine("Enviando email para " + Email + ": " + mensagem);
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\nIdade: {Idade}\nEndereço: {Endereco}\nTelefone: {Telefone}\nEmail: {Email}";
    }
}
