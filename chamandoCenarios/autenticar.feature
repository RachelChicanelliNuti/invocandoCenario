Feature: autenticar no sistema
	Para acessar tela de escolha de módulo
Enquanto usuário
Eu gostaria de me autenticar no sistema e escolher o perfil

@mytag
Scenario Outline: autenticar no sistema
	
	When eu preencho o campo CPF com o valor <cpf>
	And preencha o campo Senha com o valor <senha>
	When clico no botão entrar
	Then tvejo na tela <mensagem>

	Examples:
	| cpf            | senha  | mensagem                 |
	| 628.326.360-71 | 123456 | Autenticacao com sucesso |