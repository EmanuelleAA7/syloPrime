
Feature: Realizar cadastro de produtor no sistema da Sylo
  Para validar a autenticação do usuário do sistema
  Como usuário do sistema
  Eu quero me cadastrar.

    Background: 
	Given Que estou no site institucional
    And acesso a página de cadastro

@CadastroSucesso
Scenario: Realizar cadastro no sistema
	
    Given que estou na página de cadastro
    When preencho todos os campos obrigatórios
    And clico para registrar cadastro
    Then o sistema deve mostrar uma mensagem de cadastro feito com sucesso

@cadastroInvalido
Scenario Outline: Realizar cadastro no sistema com dados nulos
    Given que estou na página de cadastro
    When preencho todos os campos obrigatórios
    But Não preenchoo campo <campo>
    And clico para registrar cadastro
    Then o sistema deve mostrar uma mensagem de aviso invalido

    Examples: 
      | campo |
      | cnpj  |
      | email |
      | senha |



