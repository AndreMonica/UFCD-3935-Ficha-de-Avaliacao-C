namespace UFCD_3935_Ficha_de_avaliação;

//Considere como subclasse da classe Pessoa(desenvolvida anteriormente), a classe Fornecedor. 
public class Fornecedor : Pessoa
{
    /*Considere que cada instância da classe Fornecedor tem, para além dos atributos que caracterizam a classe Pessoa, os atributos
     creditoMaximo (correspondente ao crédito máximo atribuído pelo fornecedor a determinada pessoa) e 
     valorEmDivida (montante da dívida para com o fornecedor). Implemente na classe Fornecedor, 
     */
    
    //Atributos
    public float creditoMaximo;
    public float valorEmDivida;

    //os métodos usuais set e get, adicionando um novo construtor que inicializa todas as variáveis 
    //Constructor
    public Fornecedor(string nome, int idade, int altura, string sexo, float creditoMaximo, float valorEmDivida) : base(nome, idade, altura, sexo)
    {
        this.creditoMaximo = creditoMaximo;
        this.valorEmDivida = valorEmDivida;
    }

    // Set e Get
    public float CreditoMaximo
    {
        get => creditoMaximo;
        set => creditoMaximo = value;
    }

    public float ValorEmDivida
    {
        get => valorEmDivida;
        set => valorEmDivida = value;
    }
    
    //e um método obterSaldo que devolve a diferença entre os valores dos atributos creditoMaximo e valorEmDivida.
    //Method
    public float ObterSaldo()
    {
        return (creditoMaximo - valorEmDivida);
    }
}