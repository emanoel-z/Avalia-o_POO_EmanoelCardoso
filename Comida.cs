public class Comida
{
    private string? nome;
    private double preço;
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
    public double Preço
    {
        get
        {
            return preço;
        }
        set
        {
            if(value <= 0)
            {
                Console.WriteLine("O preço nao pode ser zero ou negativo");
            }
            else
            {
                Console.WriteLine($"Preço: {preço}");
                preço = value;
            }
        }
    }

    public Comida(string nome, double preço)
    {
        this.nome = nome;
        this.preço = preço;
    }

    public override string ToString()
    {
        return $"Nome: {nome} || Preço: {preço}";
    }
}