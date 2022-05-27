// UFCD 3935 | Ficha de avaliação

/*
1ª Parte

Escreva no Program.cs os testes que achar adequados para esta classe.



2ª Parte

Considere como subclasse da classe Pessoa(desenvolvida anteriormente), a classe Fornecedor. 
Considere que cada instância da classe Fornecedor tem, para além dos atributos que caracterizam a classe Pessoa, 
os atributos creditoMaximo (correspondente ao crédito máximo atribuído pelo fornecedor a determinada pessoa) 
e valorEmDivida(montante da dívida para com o fornecedor). Implemente na classe Fornecedor, 
os métodos usuais set e get, adicionando um novo construtor que inicializa todas as variáveis 
e um método obterSaldo que devolve a diferença entre os valores dos atributos creditoMaximo e valorEmDivida.
 Escreva no Program.cs os testes que achar adequados para esta classe.

3ª Parte

Implemente a classe Administrador como subclasse da classe Empregado. 
Um determinado administrador tem como atributos, para além dos atributos da classe Pessoa e da classe Empregado,
 o atributo ajudasDeCusto ( ajudas referentes a viagens, estadias,...). 
 
 Note que deverá redefinir na classe Administrador o método herdado obterLucros 
 (o salário de um administrador é equivalente ao salário de um empregado usual acrescido das ajudas de custo). 
 
  Escreva no Program.cs os testes que achar adequados para esta classe.
*/

using UFCD_3935_Ficha_de_avaliação;

Pessoa objPessoa1 = new Pessoa("Andre", 27, 180, "M");
Empregado objEmpregado1 = new Empregado("Luis", 30, 175, "M", salario: 1000);
objEmpregado1.salario += 500;
Console.WriteLine("O empregado tem de salario {0}", objEmpregado1.obterLucros());