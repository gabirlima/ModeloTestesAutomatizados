#language: pt-br

Funcionalidade: Login
	Para acessar a tela do usuário
	Como usuário do site
	Desejo realizar login

@login @producao
Cenário: Acessar tela de login
	Dado que acessei o site
	Quando cliquei o link Login
	Então devo visualizar a tela de login

@login @homologacao
Cenário: Realizar login
	Dado que acessei o site
	E cliquei o link Login
	Quando preencher o campo Login
	E preencher o campo Senha
	E selecionar o botão Submit
	Então devo visualizar a tela do usuário
