// UFCD 3935 | Ficha de avaliação
/*
1ª Parte
Implemente a classe Pessoa que têm como atributos  nome, idade, altura e sexo.Construa os métodos set e get para 
cada variável da instância e um construtor para a classe.
Construa depois uma classe Empregado que deve ser uma subclasse da classe Pessoa (herança), adicionando um novo 
construtor e uma variável de instância salário e os métodos set e get para o novo atributo. 
Construa um método obterLucros que devolva o lucro(salário) do empregado. 
Escreva no Program.cs os testes que achar adequados para esta classe.

2ª Parte
Considere como subclasse da classe Pessoa(desenvolvida anteriormente), a classe Fornecedor.
Considere que cada instância da classe Fornecedor tem, para além dos atributos que caracterizam a classe Pessoa,
os atributos creditoMaximo (correspondente ao crédito máximo atribuído pelo fornecedor a determinada pessoa) e 
valorEmDivida(montante da dívida para com o fornecedor). Implemente na classe Fornecedor, os métodos usuais set e get,
adicionando um novo construtor que inicializa todas as variáveis e um método obterSaldo que 
devolve a diferença entre os valores dos atributos creditoMaximo e valorEmDivida. 
Escreva no Program.cs os testes que achar adequados para esta classe.

3ª Parte
Implemente a classe Administrador como subclasse da classe Empregado. 
Um determinado administrador tem como atributos, para além dos atributos da classe Pessoa e da classe Empregado, 
o atributo ajudasDeCusto ( ajudas referentes a viagens, estadias,...). 
Note que deverá redefinir na classe Administrador o método herdado obterLucros 
(o salário de um administrador é equivalente ao salário de um empregado usual acrescido das ajudas de custo).  
Escreva no Program.cs os testes que achar adequados para esta classe.
 */

/*
!READ ME:
!Teste realizado a' letra escrito no enunciado acima.
!Cada "linha" do enunciado esta "espalhada" por comentario ao longo do codigo na sua devida localizacao
*/

using UFCD_3935_Ficha_de_avaliação;

// Testes 1' parte do exame
Pessoa objPessoa1 = new Pessoa("Andre", 27, 180, "M");
Console.WriteLine(objPessoa1.nome);
Empregado objEmpregado1 = new Empregado("Luis", 30, 175, "M", salario: 1000);
objEmpregado1.salario += 500;
Console.WriteLine("O empregado {1}, tem de salario {0}", objEmpregado1.ObterLucros(), objEmpregado1.nome);
Console.WriteLine("------------------------------------------------");

// Testes 2' parte do exame
Fornecedor objFornecedor1 = new Fornecedor("Manuel", 45, 150, "M", 2000, 200);
Console.WriteLine("O fornecedor {0}, tem como saldo: {1}",objFornecedor1.nome,objFornecedor1.ObterSaldo());
Console.WriteLine("------------------------------------------------");

// Testes 3' parte do exame

Administrador objAdmin1 = new Administrador("Maria", 35, 170, "F", 1000, 2500);
Console.WriteLine("O Admin: {0}, tem como salario {1}, e ajudas de {2}, no total leva para casa: {3}  menos os devidos impostos",objAdmin1.nome, objAdmin1.salario, objAdmin1.ajudasDeCustos, objAdmin1.ObterLucros());