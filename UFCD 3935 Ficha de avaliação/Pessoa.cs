namespace UFCD_3935_Ficha_de_avaliação;

public class Pessoa
{
    //Implemente a classe Pessoa que têm como atributos  nome, idade, altura e sexo.
    //Atributos
    public string nome;
    public int idade;
    public int altura; // em cm
    public string sexo;

    //Construa os métodos set e get para cada variável da instância e um construtor para a classe.
    //Constructor
    public Pessoa(string nome, int idade, int altura, string sexo)
    {
        this.nome = nome;
        this.idade = idade;
        this.altura = altura;
        this.sexo = sexo;
    }

    //Set e Get
    public string Nome
    {
        get => nome;
        set => nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Idade
    {
        get => idade;
        set => idade = value;
    }

    public int Altura
    {
        get => altura;
        set => altura = value;
    }

    public string Sexo
    {
        get => sexo;
        set => sexo = value ?? throw new ArgumentNullException(nameof(value));
    }
}