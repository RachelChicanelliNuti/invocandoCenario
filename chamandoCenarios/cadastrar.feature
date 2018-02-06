﻿Feature: cadastrar
	Como usuario do sistema
	Eu quero me registrar
	Para que eu possa acessar o sistema

@cadastroUsuario
Scenario Outline: Cadastrar Ususario
	Given que estou na pagina de cadastro 
	And eu preencho o campo nome <nome>
	And eu preencho o campo email <email>
	And eu preencho o campo nascimento <nascimento>
	And eu preencho o campo rg <rg>
	And eu preencho o campo celular<celular>
	And eu preencho o campo logradouro<logradouro>
	And eu preencho o campo numero<numero>
	And eu preencho o campo bairro<bairro>
	And eu preencho o campo complemento<complemento>
	And eu preencho o campo cep<cep>
	And eu preencho o campo uf <uf>
	And eu preencho o campo municipio <municipio>
	And eu preencho o campo cpf<cpf>
	And eu preencho o campo senha <senha>
	And eu preencho o campo repetir <repetir>
	And eu aceito o Termo de uso
	Then eu clico no botao Entrar
	Given que estou na página de autenticacao
	Given que estou na tela de solicitação de acesso

	Examples: 
	| nome          | email                          | nascimento | rg         | celular     | logradouro | numero | bairro   | complemento | cep       | uf                 | municipio  | cpf            | senha  | repetir |
	| MAQ3 | maqw44@mailinator.com | 06/12/1977 | 27532063-7 | 65999666917 | Av.Florais | 875    | Ribeirão | Q.05        | 78048-135 | Mato Grosso do Sul | Água Clara | 231.842.588-40 | 123456 | 123456  |