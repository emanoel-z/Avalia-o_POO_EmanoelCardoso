public class Conta
{
    private string? nome;
    private string? cpf;
    public string? Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if(value == null)
            {
                Console.WriteLine("o nome nao pode ser nulo");
            }
            else
            {
                Console.WriteLine($"Nome: {nome}");
                nome = value;
            }
        }
    }

    
    public string? Cpf
    {
        get 
        { 
            return cpf; 
        }
        set
        {
            if(value == null || value.Length != 11)
            {
                Console.WriteLine("cpf não atende aos requisitos.");
                return;
            }
            cpf = value;
        }

    }

    public Conta(string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }

    public override string ToString()
    {
        return $"{this.nome} || {this.cpf}";
    }
}

