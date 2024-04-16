/*
	Name:                   ScriptInitDatabase.sql
	Author:                 Juan Carlos Valera Velazquez
	Proyect:                PORTAFOLIO DE NEGOCIOS S.A. DE C.V. SOFOM ER.
	Creation:               26/03/2024
	Last Modification:      26/03/2014

	Modify by:              Juan Carlos Valera Velazquez
	Description:            Script to ceate a database TestSol

*/

CREATE DATABASE TestSol
GO

USE TestSol
GO

CREATE TABLE Employees(
	Id INT IDENTITY,
	[Name] VARCHAR(100) NOT NULL,
	FirstSurname VARCHAR(100) NOT NULL,
	SecondSurname VARCHAR(100) NOT NULL,
	Area VARCHAR(100) NOT NULL,
	BirthDate DATE NOT NULL,
	Salary FLOAT NOT NULL
	CONSTRAINT PK_Empleados PRIMARY KEY (Id)
)
GO

INSERT INTO Employees 
	([Name], FirstSurname, SecondSurname, Area, BirthDate, Salary)
	VALUES ('Juan Carlos', 'Valera', 'Velazquez', 'IT', '01-08-1981', 5000)
GO