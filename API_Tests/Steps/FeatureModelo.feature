#language: pt-br

Funcionalidade: FeatureModelo
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Cenário: Add two numbers
	Quando realizo a requisição GET
	Então devo receber o retorno 200 - OK
