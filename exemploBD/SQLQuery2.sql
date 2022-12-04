CREATE TABLE Produtos(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Cor VARCHAR(50) NULL,
	Preco DECIMAL(13,2) NOT NULL,
	Tamanho VARCHAR(5) NULL,
	Genero char(1)
)


SELECT COUNT(*) QuantidadeProdutosTamanhoM from Produtos where Tamanho = 'M'

--select * from Clientes
--order by Nome; 

--INSERT INTO Clientes(Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
--values ('Maria','Denise','email@email.com',1,GETDATE());

--INSERT INTO Clientes VALUES ('José','Mario','mail@email.com',0,GETDATE());

UPDATE Clientes
SET Email = 'emailatualizado@gmail.com'
WHERE Id = 1 

SELECT * FROM Clientes
ORDER BY Nome

DELETE Clientes
WHERE Id = 8;