#language: pt-br

Funcionalidade: Cálculo de IR
	Para quanto terei de salário
	Enquanto funcionário
	Eu gostaria de saber o meu salário líquido

Cenário: Salário de 4000 mensal
	Dado que estou consumindo o método CalcularSalario
	E preencho o campo 'salario' com o valor 4000
	Quando executo a aplicação
	Então vejo '3.100,00'