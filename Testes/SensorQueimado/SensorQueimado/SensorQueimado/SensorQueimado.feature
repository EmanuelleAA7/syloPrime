	Feature: SensorQueimado
	Eu como usuário, desejo ser avisado 
	Quando um de meus sensores estiver queimado.

Background:
	Given que o usuario já está logado
	And   esta em sua página de dashboards

@Silo_3_Falhando
Scenario: Silo 3 com falha nos sensores
	Given que os dashboards do silo 3 estejam com temperatura 0
	And o silo 3 também acusa umidade 0
	When 25 segundos se passam
	Then um alerta aparece na tela

