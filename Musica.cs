public class Musica
{
    private string? nome;
    private string? genero;
    private int duraçao;
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
                Console.WriteLine("O nome nao pode ser nulo");
            }
            else
            {
                Console.WriteLine($"Nome: {nome}");
                nome = value;
            }
        }
    }

    public string? Genero
    {
        get
        {
            return genero;
        }
        set
        {
            if(value == null)
            {
                Console.WriteLine("o genero nao pode ser nulo");
            }
            else
            {
                Console.WriteLine($"Genero: {genero}");
                genero = value;
            }
        }
    }

    public int Duraçao
    {
        get
        {
            return duraçao;
        }
        set
        {
            if(value <= 0)
            {
                Console.WriteLine("A duraçao da musica nao pode ser 0 ou negativa.");
            }
            else
            {
                Console.WriteLine($"Duraçao: {duraçao}");
                duraçao = value;
            }
        }
    }

    public Musica(string nome, string genero, int duraçao)
    {
        this.nome = nome;
        this.genero = genero;
        this.duraçao = duraçao;
    }

    public override string ToString()
    {
        return $"Nome: {nome} ||Genero: {genero} || Duraçao: {duraçao}";
    }
}
