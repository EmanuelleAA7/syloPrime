@interacaoTelas
Feature: Realizar a interação das telas
	Como usuário do sistema
	Eu quero poder interagir com as telas do site institucional e funcional.


	@InteragirTelasInstitucional
	Scenario Outline: Realizar a interacao do cliente no site institucional
		Given que estou na página inicial do site institucional
		When entao clico <opcao>
		Then a tela deve ir até a parte da <opcao>
	Examples:
		| opcao				|
		|id_serv_index		|
		|id_produto_index	|
		|id_simula_index	|
		|id_equipe_index	|
		|id_contato_index	|  
 
 @InteragirTelasAteLogin
 	Scenario: Realizar a interação do cliente do cadastro ate o login
 		Given que estou na página inicial do site institucional
 		When Acesso a pagina de cadastro
 		And sou direcionado para a página de cadastro
 		When clico que ja possuo uma conta
 		And sou redirecionado para a página de login
 		Then Faço o login com um usuário existente
 		And sou direcionado para a dashboard
 
 @InteragirTelasFuncional
 	Scenario Outline: Realizar a interação do cliente no site funcional
 		Given que efetuei o login no sistema
 		And entao clico <pagina>
 		Then devo ser direcionado para página <pagina>
		And saio do sistema
 		
	Examples:
 		| pagina       |
 		| id_silos      |
 		| id_vendas    |
 		| id_qualidade |
 		
