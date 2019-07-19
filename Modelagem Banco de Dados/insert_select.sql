INSERT INTO Produtor VALUES 
(null,'32441223867547','Teste','Teste','2000-02-04','98274-1234','TesteTeste','SP','Limeiras','09590-039','teste@gmail.com','123456'),
(null,'98751223867598','Matheus','Risovas','2001-06-19','94235-8579','MatheusRisovas','RS','Ameixas','05560-259','matheusrisovas@gmail.com','832434'),
(null,'15568122386787','Guilherme','Fran�a','2002-03-23','97685-0395','GuilhermeFranca','SC','Palmeiras','01290-139','guilhermefranca@outlook.com','923852'),
(null,'79675223867234','Efrain','Lezama','2000-12-09','91285-3239','EfrainLezama','PR','Bananeiras','19540-358','efrainlezama@yahoo.com','095684'),
(null,'09586223867653','Hiago','Maitan','2003-01-14','98745-2345','HiagoMaitan','SP','Limeiras','43624-987','hiagomaitan@outlook.com','154954');

SELECT * FROM Produtor;

INSERT INTO Cultura VALUES
(null,'Soja',-2.0,10.0,8.0,12.0),
(null,'Milho',-7.0,15.0,6.0,14.0);

SELECT * FROM Cultura;

INSERT INTO Silo VALUES
(null,'1',3),
(null,'2',3),
(null,'3',3),
(null,'4',3),
(null,'23',5),
(null,'24',5);

SELECT * FROM Silo;

SELECT * FROM Produtor, Silo
WHERE fkProdutor = idProdutor;

INSERT INTO Sensor VALUES
(null,'1',1),
(null,'2',1),
(null,'3',1),
(null,'4',1),
(null,'1',2),
(null,'2',2),
(null,'3',2),
(null,'4',2),
(null,'1',3),
(null,'2',3),
(null,'3',3),
(null,'4',3),
(null,'1',4),
(null,'2',4),
(null,'3',4),
(null,'4',4);

SELECT * FROM Sensor;

INSERT INTO Producao VALUES 
(null,'2018-09-29','2019-03-12',1,1),
(null,'2018-08-15','2019-02-20',1,2),
(null,'2019-01-30',NULL,1,3),
(null,'2019-03-05',NULL,1,4);

SELECT * FROM Producao;

SELECT * FROM Leitura;

INSERT INTO Relatorio_Vendas VALUES
(null,110,8000,5500,'2019-05-19',3,2),
(null,120,5500,4500,'2019-05-31',3,1),
(null,115,6000,5000,'2019-06-10',3,3),
(null,135,7500,5500,'2019-06-20',3,4),
(null,160,6500,5000,'2019-06-30',3,2),
(null,175,8500,7000,'2019-07-11',3,1),
(null,130,7000,5000,'2019-05-05',3,4),
(null,120,6000,5000,'2019-03-16',3,1),
(null,110,5500,4500,'2019-04-05',3,2),
(null,90,4000,3000,'2019-04-28',3,3);

SELECT * FROM Relatorio_Vendas;

INSERT INTO Relatorio_Qualidade VALUES
(null,'2018-03-16',5.0,4.5,4.3,4.0,3.5,4.0,10.0,10.6,10.7,10.7,10.8,10.0,94.9,3,1),
(null,'2018-04-09',5.2,4.7,4.5,4.2,3.7,4.2,10.2,10.8,10.9,10.1,10.1,10.6,89.5,3,1),
(null,'2018-05-18',5.4,4.9,4.7,4.4,3.8,4.4,10.4,10.0,10.0,10.4,10.2,10.3,95.4,3,1),
(null,'2018-06-10',5.6,4.0,4.9,4.6,3.0,4.6,10.6,10.1,10.1,10.7,10.8,10.7,90.2,3,1),
(null,'2018-07-24',5.8,4.2,4.0,4.8,3.2,4.9,10.8,10.3,10.3,10.2,10.5,10.8,98.1,3,1),
(null,'2018-08-16',5.1,4.6,4.2,4.1,3.3,4.1,10.1,10.5,10.2,10.6,10.7,10.3,99.3,3,1),
(null,'2019-01-05',5.3,4.8,4.4,4.3,3.6,4.5,10.3,10.7,10.6,10.9,10.5,10.1,96.7,3,2),
(null,'2019-02-28',5.5,4.1,4.6,4.7,3.3,4.2,10.5,10.9,10.9,10.3,10.3,10.2,93.4,3,3);

SELECT * FROM Relatorio_Qualidade;

DROP TABLE Relatorio_Qualidade,Relatorio_Vendas,Leitura,Producao,Cultura,Sensor,Silo,Produtor;