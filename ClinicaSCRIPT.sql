/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      ER.DM1
 *
 * Date Created : Saturday, April 29, 2023 00:43:54
 * Target DBMS : Microsoft SQL Server 2017
 */

/* 
 * TABLE: Cliente 
 */

CREATE TABLE Cliente(
    idPac              int             NOT NULL,
    nombre             varchar(20)     NOT NULL,
    segNomCliente      nvarchar(18)    NULL,
    apellidoCliente    nvarchar(18)    NOT NULL,
    segapCliente       nvarchar(18)    NULL,
    telefono           nvarchar(18)    NULL,
    direccion          varchar(10)     NULL,
    email              varchar(20)     NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idPac)
)
go



IF OBJECT_ID('Cliente') IS NOT NULL
    PRINT '<<< CREATED TABLE Cliente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cliente >>>'
go

/* 
 * TABLE: Consulta 
 */

CREATE TABLE Consulta(
    consultaID    int         NOT NULL,
    fecha         datetime    NOT NULL,
    estado        int         NOT NULL,
    idPac         int         NULL,
    ServicioID    int         NULL,
    idDoc         int         NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (consultaID)
)
go



IF OBJECT_ID('Consulta') IS NOT NULL
    PRINT '<<< CREATED TABLE Consulta >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Consulta >>>'
go

/* 
 * TABLE: Empresa 
 */

CREATE TABLE Empresa(
    EmpresaID           int              NOT NULL,
    nombreEmpresa       nvarchar(50)     NOT NULL,
    direccionEmpresa    nvarchar(100)    NULL,
    numRucEmpresa       int              NOT NULL,
    correoEmpresa       nvarchar(50)     NULL,
    telEmpresa          nvarchar(10)     NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (EmpresaID)
)
go



IF OBJECT_ID('Empresa') IS NOT NULL
    PRINT '<<< CREATED TABLE Empresa >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Empresa >>>'
go

/* 
 * TABLE: Expediente 
 */

CREATE TABLE Expediente(
    expedienteID       int             NOT NULL,
    fechaExpediente    datetime        NULL,
    diagnostico        nvarchar(50)    NULL,
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
    facturaID     int      NOT NULL,
    fecha         int      NOT NULL,
    costo         float    NOT NULL,
    ServicioID    int      NULL,
    idPac         int      NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (facturaID)
)
go



IF OBJECT_ID('Factura') IS NOT NULL
    PRINT '<<< CREATED TABLE Factura >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Factura >>>'
go

/* 
 * TABLE: Rol 
 */

CREATE TABLE Rol(
    rolID        int         NOT NULL,
    nombreRol    char(10)    NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (rolID)
)
go



IF OBJECT_ID('Rol') IS NOT NULL
    PRINT '<<< CREATED TABLE Rol >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Rol >>>'
go

/* 
 * TABLE: Servicio 
 */

CREATE TABLE Servicio(
    ServicioID        int             NOT NULL,
    costoServicio     float           NULL,
    nombreServicio    nvarchar(50)    NULL,
    CONSTRAINT PK8 PRIMARY KEY NONCLUSTERED (ServicioID)
)
go



IF OBJECT_ID('Servicio') IS NOT NULL
    PRINT '<<< CREATED TABLE Servicio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Servicio >>>'
go

/* 
 * TABLE: Usuario 
 */

CREATE TABLE Usuario(
    idDoc            int            NOT NULL,
    nombreUsuario    varchar(20)    NOT NULL,
    contraseņa       int            NOT NULL,
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

ALTER TABLE Consulta ADD CONSTRAINT RefCliente27 
    FOREIGN KEY (idPac)
    REFERENCES Cliente(idPac)
go

ALTER TABLE Consulta ADD CONSTRAINT RefServicio28 
    FOREIGN KEY (ServicioID)
    REFERENCES Servicio(ServicioID)
go

ALTER TABLE Consulta ADD CONSTRAINT RefUsuario29 
    FOREIGN KEY (idDoc)
    REFERENCES Usuario(idDoc)
go


/* 
 * TABLE: Factura 
 */

ALTER TABLE Factura ADD CONSTRAINT RefServicio25 
    FOREIGN KEY (ServicioID)
    REFERENCES Servicio(ServicioID)
go

ALTER TABLE Factura ADD CONSTRAINT RefCliente26 
    FOREIGN KEY (idPac)
    REFERENCES Cliente(idPac)
go


