@Simulador
Feature: Simulador
	Eu como usuário
	Desejo utilizar o simulador para verificar os benefícios que solução me proporcionaria

Background:
	Given que estou no site institucional
	And clico em menu >> simulação

@Correto_Propriedade
Scenario: Propriedade funcionando normalmente
	And clico em propriedade
	When preencho os campos requeridos
	And clico em calcular propriedade
	Then os resultados propriedade aparecem na tela

@Incorreto_Propriedade
Scenario Outline: Propriedade com campos nulos
	And clico em propriedade
	When preencho os campos requeridos
	But  preencho o campo <campo> com um valor nulo
	And clico em calcular propriedade
	Then o sistema avisa que estão faltando dados

	Examples:
	| campo                      |
	| valor_saca_p_id            |
	| qt_sacas_p_id              |
	| desperdicio_porcentagem_id |
	| preco_mao_de_obra_p_id     |

	
@Correto_Terceiros
Scenario: Terceiros funcionando normalmente
	And clico em através de terceiros
	When preencho os campos dos terceiros
	And clico em calcular terceiros
	Then os resultados terceiros aparecem na tela


@Incorreto_Terceiros
Scenario Outline: Terceiros com campos nulos
	And clico em através de terceiros
	When preencho os campos dos terceiros
	But  preencho o campo <campo> com um valor nulo
	And clico em calcular terceiros
	Then o sistema avisa que estão faltando dados

	Examples:
	| campo                  |
	| qt_sacas_c_id          |
	| preco_frete_id         |
	| preco_mao_de_obra_c_id |
