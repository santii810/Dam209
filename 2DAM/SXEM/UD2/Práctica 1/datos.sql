CREATE TABLE Profesor(
DNI text PRIMARY KEY,
Nombre text not null);

CREATE TABLE Modulos(
codigo text PRIMARY KEY,
nombre text not null,
dniProfesor text);


CREATE TABLE Alumnos(
numExp text PRIMARY KEY,
nombre text not null,
apellidos text not null,
fechaNac date,
curso text);

CREATE TABLE Curso(
codigo text PRIMARY KEY,
numExpDelegado text);

CREATE TABLE Matriculado(
codigoModulo text,
numExpAlumno text);




ALTER TABLE Matriculado 
	ADD CONSTRAINT PK_Matriculado PRIMARY KEY(codigoModulo, NumExpAlumno);
ALTER TABLE Alumnos add
	CONSTRAINT "FK_Alumnos_Curso" FOREIGN KEY (Curso)
		REFERENCES Curso (codigo) MATCH SIMPLE
		ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE Modulos add
	CONSTRAINT "FK_Alumnos_Curso" FOREIGN KEY (DniProfesor)
		REFERENCES Profesor (dni) MATCH SIMPLE
		ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE CURSO
	ADD CONSTRAINT "FK_Cusro_Alumno" FOREIGN KEY (numExpDelegado)
		REFERENCES Alumnos(numExp) MATCH SIMPLE
		ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE Matriculado
	ADD CONSTRAINT "FK_Matriculado_Modulo" FOREIGN KEY (codigoModulo)
		REFERENCES Modulos(codigo) MATCH SIMPLE
		ON UPDATE NO ACTION ON DELETE NO ACTION,
	ADD CONSTRAINT "FK_Matriculado_Alumno" FOREIGN KEY (numExpAlumno)
		REFERENCES Alumnos(numExp) MATCH SIMPLE
		ON UPDATE NO ACTION ON DELETE NO ACTION;


INSERT INTO Curso VALUES ('01'),('02'),('03'),('04'),('05');
INSERT INTO Alumnos VALUES 
('02','Nombre1','Apellido1','1993-10-08','01'),
('03','Nombre2','Apellido2','1963-08-06','02'),
('04','Nombre3','Apellido2','1973-11-05','03'),
('05','Nombre4','Apellido3','1983-10-02','04'),
('06','Nombre5','Apellido2','1999-12-12','05');

INSERT INTO Profesor VALUES
('12345678a','Nombre1'),
('12345678b','Nombre5'),
('12345678c','Nombre4'),
('12345678d','Nombre3'),
('12345678r','Nombre2');

INSERT INTO Modulos VALUES
('01','Modulo1','12345678a'),
('02','Modulo2','12345678a'),
('03','Modulo3','12345678a'),
('04','Modulo4','12345678a'),
('05','Modulo5','12345678a');

INSERT INTO Matriculado VALUES 
('01','01'),
('01','02'),
('01','03'),
('01','04'),
('01','05');

 
