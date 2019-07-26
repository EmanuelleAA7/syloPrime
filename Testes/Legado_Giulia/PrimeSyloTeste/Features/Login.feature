@logins
Feature: Login
  Eu como usuário, desejo realizar meu login
  Para ter acesso as funcionalidades da aplicação
  
  Background:
     Given que estou no site institucional
    	And acessei o site >> Login 
  
  @user_login
  Scenario: Login do usuário com sucesso 
    When inseri meu login
    And inseri minha senha
    And clico em Login
    Then a mensagem de sucesso aparece na tela
   
     @user_email_incorreto
  Scenario: Login do usuário com email incorreto 
    When inseri meu login incorreto
    And inseri minha senha
    And clico em Login
    Then o site alerta e-mail inválido
    
   
     @user_senha_incorreta
  Scenario: Login do usuário com senha incorreta 
    When inseri meu login
    And inseri minha senha incorreta
    And clico em Login
    Then o site alerta senha inválida
