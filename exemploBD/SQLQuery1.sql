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