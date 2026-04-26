USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'PatitasFelicesDB')
    DROP DATABASE PatitasFelicesDB;
GO

CREATE DATABASE PatitasFelicesDB;
GO

USE PatitasFelicesDB;
GO

CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL,
    Clave VARCHAR(50) NOT NULL,
    Rol VARCHAR(20) NOT NULL,
    CONSTRAINT CHK_Rol CHECK (Rol IN ('cliente', 'admin'))
);
GO

CREATE TABLE Agendamientos (
    IdAgendamiento INT IDENTITY(1,1) PRIMARY KEY,
    NombreDueno VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20) NOT NULL,
    Correo VARCHAR(100) NOT NULL,
    NombreMascota VARCHAR(50) NOT NULL,
    TipoMascota VARCHAR(50) NOT NULL,
    EdadMascota INT NOT NULL,
    FechaAtencion DATE NOT NULL,
    HoraAtencion TIME NOT NULL,
    MotivoConsulta VARCHAR(255) NOT NULL,
    Estado VARCHAR(20) NOT NULL DEFAULT 'Pendiente',
    CONSTRAINT CHK_Estado CHECK (Estado IN ('Pendiente','Confirmada','Atendida','Cancelada'))
);
GO

INSERT INTO Usuarios (NombreUsuario, Clave, Rol)
VALUES
    ('admin123', 'admin123', 'admin'),
    ('cliente123', 'cliente123', 'cliente');
GO
