#language: pt-br

Funcionalidade: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Cenário: Acessar tela de login
	Dado que acessei o site
	Quando cliquei o link Login
	Então devo visualizar a tela de login

Cenário: Realizar login
	Dado que acessei o site
	E cliquei o link Login
	Quando preencher o campo Login
	E preencher o campo Senha
	E selecionar o botão Submit
	Então devo visualizar a tela do usuário
