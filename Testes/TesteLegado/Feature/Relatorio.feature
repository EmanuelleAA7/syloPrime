Feature: Relatorio

Background:
	Given que o usuario ja logou com seu login e sua senha
	And já se encontra na pagina inicial

@vendas_pdf
Scenario: Vendas Pdf
	When eu clico em relatório - vendas
	And clico em Gerar Relatorio PDF
	Then uma nova aba se abre com um documento em PDF

@vendas_excel
Scenario: Vendas Excel
	When eu clico em relatório - vendas
	And clico em Gerar Relatorio Excel
	Then um dowload é feito pela página web


@qualidade_pdf
Scenario: Qualidade Pdf
	When eu clico em relatório - qualidade
	And clico em Gerar Relatorio PDF qualidade
	Then uma nova aba se abre com um documento em PDF


@qualidade_excel
Scenario: Qualidade Excel
	When eu clico em relatório - qualidade
	And clico em Gerar Relatorio Excel qualidade
	Then um dowload é feito pela página
