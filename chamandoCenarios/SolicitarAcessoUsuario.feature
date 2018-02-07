Feature: Solicitar Acesso ao Sistema
	Como usuario do sistema
	Eu quero solicitar a liberacao
	Para que eu possa acessar o sistema

@solicitarAcessoUsuario
Scenario Outline: solicitacao com sucesso
	Given que estou na página de solicitacao de acesso	
	And clico no botao de acesso
	And clico em Solicitacao de acesso
	And preenchi o mesmo com dados válidos <matriculaSoli>
	Then clico no botao salvar

	Examples: 
	| matriculaSoli   | justfivativaSoli   |
	| 787.183.786-92 | Para fins de Teste |
