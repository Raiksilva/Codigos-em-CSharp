SELECT *, 
	FORMAT(DataCadastro, 'dd/MM/yyyy')
FROM Produtos

ALTER TABLE Produtos 
ADD DataCadastro DATETIME2

UPDATE Produtos SET DataCadastro = GETDATE()

CREATE TABLE Endereco(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente INT NULL,
	Rua VARCHAR(100) NULL,
	Bairro VARCHAR(100) NULL,
	Cidade VARCHAR(100) NULL,
	Estado char(2) NULL,
	CONSTRAINT FK_Endereco_Cliente FOREIGN KEY(IdCliente)
	REFERENCES Clientes(Id)
)

SELECT * FROM Clientes
SELECT * FROM Endereco