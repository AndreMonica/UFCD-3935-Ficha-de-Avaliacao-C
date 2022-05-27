namespace UFCD_3935_Ficha_de_avaliação;

//Construa depois uma classe Empregado que deve ser uma subclasse da classe Pessoa (herança), 
public class Empregado : Pessoa
{
    //adicionando um novo construtor e uma variável de instância salário e os métodos set e get para o novo atributo. 
    //Atributos
    public float salario;

    //Constructor
    public Empregado(string nome, int idade, int altura, string sexo, float salario) : base(nome, idade, altura, sexo)
    {
        this.salario = salario;
    }

    //Set e Get
    public float Salario
    {
        get => salario;
        set => salario = value;
    }
    
    //Construa um método obterLucros que devolva o lucro(salário) do empregado. 
    //Method
    public float obterLucros()
    {
        // ??? ok
        return (salario);
    }
}