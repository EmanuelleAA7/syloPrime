CREATE TABLE Produtor(
	idProdutor INT PRIMARY KEY AUTO_INCREMENT,
    cnpj VARCHAR(14),
    nome VARCHAR(50) NOT NULL,
    sobrenome VARCHAR(50) NOT NULL,
    dataNasc DATE,
    telefone VARCHAR(14),
    nomeUsuario VARCHAR(50) NOT NULL,
    estado VARCHAR(30) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    cep VARCHAR(9),
    email VARCHAR(50) NOT NULL,
    senha VARCHAR(50) NOT NULL
)AUTO_INCREMENT=1;

CREATE TABLE Silo(
	idSilo INT PRIMARY KEY AUTO_INCREMENT,
    descricao VARCHAR(10) NOT NULL
)AUTO_INCREMENT=1;

CREATE TABLE Sensor(
	idSensor INT PRIMARY KEY AUTO_INCREMENT,
    descricao char(1) NOT NULL
)AUTO_INCREMENT=1;

CREATE TABLE Cultura(
	idCultura INT  PRIMARY KEY AUTO_INCREMENT,
    nomeCultura VARCHAR(50) NOT NULL,
    tempMin DECIMAL(3,1) NOT NULL,
    tempMax DECIMAL(3,1) NOT NULL,
    umidMin DECIMAL(3,1) NOT NULL,
    umidMax DECIMAL(3,1) NOT NULL
)AUTO_INCREMENT=1;

CREATE TABLE Leitura(
	temperatura DECIMAL(3,1) NOT NULL,
    umidade DECIMAL(3,1) NOT NULL,
    momentoLeitura DATETIME NOT NULL
);

CREATE TABLE Producao(
    idProducao INT PRIMARY KEY AUTO_INCREMENT,
    dataArmazenagem DATE NOT NULL,
    dataVenda DATE
)AUTO_INCREMENT=1;

CREATE TABLE Relatorio_Vendas(
	idRelatorioVendas INT PRIMARY KEY AUTO_INCREMENT,
    qtdSacas INT NOT NULL,
    receita FLOAT NOT NULL,
    lucro FLOAT NOT NULL,
    dataVenda DATE NOT NULL
)AUTO_INCREMENT=1;
    
CREATE TABLE Relatorio_Qualidade(
	idRelatorioQualidade INT PRIMARY KEY AUTO_INCREMENT,
    data_relatorio DATE NOT NULL,
    mediaTempMes1 DECIMAL(3,1) NOT NULL,
    mediaTempMes2 DECIMAL(3,1) NOT NULL,
    mediaTempMes3 DECIMAL(3,1) NOT NULL,
    mediaTempMes4 DECIMAL(3,1) NOT NULL,
    mediaTempMes5 DECIMAL(3,1) NOT NULL,
    mediaTempMes6 DECIMAL(3,1) NOT NULL,
    mediaUmidMes1 DECIMAL(3,1) NOT NULL,
    mediaUmidMes2 DECIMAL(3,1) NOT NULL,
    mediaUmidMes3 DECIMAL(3,1) NOT NULL,
    mediaUmidMes4 DECIMAL(3,1) NOT NULL,
    mediaUmidMes5 DECIMAL(3,1) NOT NULL,
    mediaUmidMes6 DECIMAL(3,1) NOT NULL,
    porcentagem DECIMAL(3,1) NOT NULL
)AUTO_INCREMENT=1;


ALTER TABLE Silo ADD fkProdutor INT;
ALTER TABLE Silo ADD FOREIGN KEY(fkProdutor) REFERENCES Produtor(idProdutor);
    
ALTER TABLE Sensor ADD fkSilo INT;
ALTER TABLE Sensor ADD FOREIGN KEY(fkSilo) REFERENCES Silo(idSilo);

ALTER TABLE Producao ADD fkCultura INT;
ALTER TABLE Producao ADD FOREIGN KEY (fkCultura) REFERENCES Cultura (idCultura);

ALTER TABLE Producao ADD fkSilo INT;
ALTER TABLE Producao ADD FOREIGN KEY (fkSilo) REFERENCES Silo (idSilo);

ALTER TABLE Leitura ADD fkSensor INT;
ALTER TABLE Leitura ADD FOREIGN KEY(fkSensor) REFERENCES Sensor(idSensor);

ALTER TABLE Leitura ADD fkProducao INT;
ALTER TABLE Leitura ADD FOREIGN KEY(fkProducao) REFERENCES Producao (idProducao);
    
ALTER TABLE Relatorio_Vendas ADD fkProdutor INT;
ALTER TABLE Relatorio_Vendas ADD FOREIGN KEY(fkProdutor) REFERENCES Produtor(idProdutor);
    
ALTER TABLE Relatorio_Vendas ADD fkProducao INT;
ALTER TABLE Relatorio_Vendas ADD FOREIGN KEY(fkProducao) REFERENCES Producao(idProducao);
    
ALTER TABLE Relatorio_Qualidade ADD fkProdutor INT;
ALTER TABLE Relatorio_Qualidade ADD FOREIGN KEY(fkProdutor) REFERENCES Produtor(idProdutor);
    
ALTER TABLE Relatorio_Qualidade ADD fkProducao INT;
ALTER TABLE Relatorio_Qualidade ADD FOREIGN KEY(fkProducao) REFERENCES Producao(idProducao);