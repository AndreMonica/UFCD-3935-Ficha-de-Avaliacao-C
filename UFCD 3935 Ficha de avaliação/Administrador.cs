namespace UFCD_3935_Ficha_de_avaliação;

//Implemente a classe Administrador como subclasse da classe Empregado. 
public class Administrador : Empregado
{
    //Um determinado administrador tem como atributos, para além dos atributos da classe Pessoa e da classe Empregado,
    //o atributo ajudasDeCusto ( ajudas referentes a viagens, estadias,...). 
    
    //Atributos
    public float ajudasDeCustos;


    public Administrador(string nome, int idade, int altura, string sexo, float salario, float ajudasDeCustos) : base(nome, idade, altura, sexo, salario)
    {
        this.ajudasDeCustos = ajudasDeCustos;
    }

    public float AjudasDeCustos
    {
        get => ajudasDeCustos;
        set => ajudasDeCustos = value;
    }

    //Note que deverá redefinir na classe Administrador o método herdado obterLucros 
    //(o salário de um administrador é equivalente ao salário de um empregado usual acrescido das ajudas de custo). 
    //Method
    public override float ObterLucros()
    {
        return (salario + ajudasDeCustos);
    }
}