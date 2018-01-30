Feature: Autenticação no sistema
Para acessar tela de escolha de módulo
Enquanto usuário
Eu gostaria de me autenticar no sistema e escolher o perfil

@loginUsuario
Scenario Outline: Autenticação com sucesso
	Given que estou na página de autenticacao 
	When eu preencho o campo CPF com o valor <cpf>
	And preencha o campo Senha com o valor <senha>
	When clico no botão Entrar
	Then vejo na tela <mensagem>

	Examples:
	| cpf           | senha        | mensagem     |
	| 723.223.550-03   | 123456 | 'Bem-vindo'   |
