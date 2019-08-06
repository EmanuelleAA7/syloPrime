Feature: SensorDesligado
	Eu como usuário
	Desejo ser informado se o sensor estiver desligado

@Sensor_Desligado
Scenario: Sensor Desligado
	Given o usuario já está logado
	And seu arduíno é desonectado
	Then Um alerta aparece na tela