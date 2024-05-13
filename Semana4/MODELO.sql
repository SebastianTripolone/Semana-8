create DATABASE MODELO

CREATE TABLE MODELO (
    Id INT PRIMARY KEY,
    Titulo NVARCHAR(100),
    FechaRealizacion DATE,
    Genero NVARCHAR(50),
    Precio DECIMAL(18, 2)
);

select * 
FROM MODELO