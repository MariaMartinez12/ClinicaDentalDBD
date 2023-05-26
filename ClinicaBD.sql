/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      ClinicaER23.dm1
 *
 * Date Created : Friday, May 26, 2023 10:42:23
 * Target DBMS : Microsoft SQL Server 2012
 */

/* 
 * TABLE: Consulta 
 */

CREATE TABLE Consulta(
    consultaID       int              NOT NULL,
    cantServicios    int              NULL,
    fecha            datetime         NOT NULL,
    estado           nvarchar(200)    NOT NULL,
    idPac            int              NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (consultaID)
)
go



IF OBJECT_ID('Consulta') IS NOT NULL
    PRINT '<<< CREATED TABLE Consulta >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Consulta >>>'
go

/* 
 * TABLE: Expediente 
 */

CREATE TABLE Expediente(
    expedienteID       int              NOT NULL,
    fechaExpediente    datetime         NOT NULL,
    diagnostico        nvarchar(200)    NOT NULL,
    idPac              int              NOT NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (expedienteID)
)
go



IF OBJECT_ID('Expediente') IS NOT NULL
    PRINT '<<< CREATED TABLE Expediente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Expediente >>>'
go

/* 
 * TABLE: Factura 
 */

CREATE TABLE Factura(
    facturaID     int         NOT NULL,
    consultaID    int         NULL,
    fecha         datetime    NOT NULL,
    costo         float       NOT NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (facturaID)
)
go



IF OBJECT_ID('Factura') IS NOT NULL
    PRINT '<<< CREATED TABLE Factura >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Factura >>>'
go

/* 
 * TABLE: Paciente 
 */

CREATE TABLE Paciente(
    idPac              int             NOT NULL,
    nombre             nvarchar(50)    NOT NULL,
    apellidoCliente    nvarchar(50)    NOT NULL,
    telefono           nvarchar(18)    NULL,
    direccion          nvarchar(50)    NULL,
    email              nvarchar(50)    NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idPac)
)
go



IF OBJECT_ID('Paciente') IS NOT NULL
    PRINT '<<< CREATED TABLE Paciente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Paciente >>>'
go

/* 
 * TABLE: Usuario 
 */

CREATE TABLE Usuario(
    idDoc            int             NOT NULL,
    nombreUsuario    nvarchar(20)    NOT NULL,
    contraseña       nvarchar(20)    NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (idDoc)
)
go



IF OBJECT_ID('Usuario') IS NOT NULL
    PRINT '<<< CREATED TABLE Usuario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Usuario >>>'
go

/* 
 * TABLE: Consulta 
 */

ALTER TABLE Consulta ADD CONSTRAINT RefPaciente27 
    FOREIGN KEY (idPac)
    REFERENCES Paciente(idPac)
go


/* 
 * TABLE: Expediente 
 */

ALTER TABLE Expediente ADD CONSTRAINT RefPaciente53 
    FOREIGN KEY (idPac)
    REFERENCES Paciente(idPac)
go


/* 
 * TABLE: Factura 
 */

ALTER TABLE Factura ADD CONSTRAINT RefConsulta51 
    FOREIGN KEY (consultaID)
    REFERENCES Consulta(consultaID)
go


