
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/07/2016 15:08:30
-- Generated from EDMX file: C:\Users\manu_\Desktop\SuperGit\MODELO\CATALOGO.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
create database SUPER_FINAL;
go
USE [SUPER_FINAL];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MODULOSUBMODULO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SUBMODULOS] DROP CONSTRAINT [FK_MODULOSUBMODULO];
GO
IF OBJECT_ID(N'[dbo].[FK_SUBMODULOFORMULARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FORMULARIOS] DROP CONSTRAINT [FK_SUBMODULOFORMULARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_FORMULARIOACCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ACCIONES] DROP CONSTRAINT [FK_FORMULARIOACCION];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOGRUPO_USUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIOGRUPO] DROP CONSTRAINT [FK_USUARIOGRUPO_USUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOGRUPO_GRUPO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIOGRUPO] DROP CONSTRAINT [FK_USUARIOGRUPO_GRUPO];
GO
IF OBJECT_ID(N'[dbo].[FK_GRUPOACCION_GRUPO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GRUPOACCION] DROP CONSTRAINT [FK_GRUPOACCION_GRUPO];
GO
IF OBJECT_ID(N'[dbo].[FK_GRUPOACCION_ACCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GRUPOACCION] DROP CONSTRAINT [FK_GRUPOACCION_ACCION];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOAUDITORIA_LOGIN]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AUDITORIAS_LOGIN] DROP CONSTRAINT [FK_USUARIOAUDITORIA_LOGIN];
GO
IF OBJECT_ID(N'[dbo].[FK_CLIENTEFACTURA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FACTURAS] DROP CONSTRAINT [FK_CLIENTEFACTURA];
GO
IF OBJECT_ID(N'[dbo].[FK_CLIENTERECIBO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RECIBOS] DROP CONSTRAINT [FK_CLIENTERECIBO];
GO
IF OBJECT_ID(N'[dbo].[FK_CLIENTENOTA_CREDITO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NOTAS_CREDITO] DROP CONSTRAINT [FK_CLIENTENOTA_CREDITO];
GO
IF OBJECT_ID(N'[dbo].[FK_CAJAMOVIMIENTO_CAJA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MOVIMIENTOS_CAJA] DROP CONSTRAINT [FK_CAJAMOVIMIENTO_CAJA];
GO
IF OBJECT_ID(N'[dbo].[FK_FACTURADETALLE_FACTURA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLES_FACTURA] DROP CONSTRAINT [FK_FACTURADETALLE_FACTURA];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODUCTODETALLE_FACTURA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DETALLES_FACTURA] DROP CONSTRAINT [FK_PRODUCTODETALLE_FACTURA];
GO
IF OBJECT_ID(N'[dbo].[FK_CLIENTEMOVIMIENTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MOVIMIENTOS] DROP CONSTRAINT [FK_CLIENTEMOVIMIENTO];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[USUARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIOS];
GO
IF OBJECT_ID(N'[dbo].[MODULOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MODULOS];
GO
IF OBJECT_ID(N'[dbo].[SUBMODULOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SUBMODULOS];
GO
IF OBJECT_ID(N'[dbo].[FORMULARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FORMULARIOS];
GO
IF OBJECT_ID(N'[dbo].[ACCIONES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ACCIONES];
GO
IF OBJECT_ID(N'[dbo].[GRUPOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GRUPOS];
GO
IF OBJECT_ID(N'[dbo].[AUDITORIAS_LOGIN]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AUDITORIAS_LOGIN];
GO
IF OBJECT_ID(N'[dbo].[CLIENTES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CLIENTES];
GO
IF OBJECT_ID(N'[dbo].[FACTURAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FACTURAS];
GO
IF OBJECT_ID(N'[dbo].[PRODUCTOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PRODUCTOS];
GO
IF OBJECT_ID(N'[dbo].[MOVIMIENTOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MOVIMIENTOS];
GO
IF OBJECT_ID(N'[dbo].[RECIBOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RECIBOS];
GO
IF OBJECT_ID(N'[dbo].[NOTAS_CREDITO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NOTAS_CREDITO];
GO
IF OBJECT_ID(N'[dbo].[CAJAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CAJAS];
GO
IF OBJECT_ID(N'[dbo].[MOVIMIENTOS_CAJA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MOVIMIENTOS_CAJA];
GO
IF OBJECT_ID(N'[dbo].[FORMAS_DE_PAGOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FORMAS_DE_PAGOS];
GO
IF OBJECT_ID(N'[dbo].[DETALLES_FACTURA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DETALLES_FACTURA];
GO
IF OBJECT_ID(N'[dbo].[TARJETAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TARJETAS];
GO
IF OBJECT_ID(N'[dbo].[USUARIOGRUPO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIOGRUPO];
GO
IF OBJECT_ID(N'[dbo].[GRUPOACCION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GRUPOACCION];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'USUARIOS'
CREATE TABLE [dbo].[USUARIOS] (
    [Id_Usuario] int IDENTITY(1,1) NOT NULL,
    [Nombre_Usuario] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DNI] int  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Clave] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL,
    [Resetear_Clave] bit  NOT NULL
);
GO

-- Creating table 'MODULOS'
CREATE TABLE [dbo].[MODULOS] (
    [Id_Modulo] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SUBMODULOS'
CREATE TABLE [dbo].[SUBMODULOS] (
    [Id_Submodulo] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [MODULO_Id_Modulo] int  NOT NULL
);
GO

-- Creating table 'FORMULARIOS'
CREATE TABLE [dbo].[FORMULARIOS] (
    [Id_Formulario] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Menu] bit  NOT NULL,
    [Clase] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL,
    [SUBMODULO_Id_Submodulo] int  NOT NULL
);
GO

-- Creating table 'ACCIONES'
CREATE TABLE [dbo].[ACCIONES] (
    [Id_Accion] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Control] nvarchar(max)  NOT NULL,
    [FORMULARIO_Id_Formulario] int  NOT NULL
);
GO

-- Creating table 'GRUPOS'
CREATE TABLE [dbo].[GRUPOS] (
    [Id_Grupo] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'AUDITORIAS_LOGIN'
CREATE TABLE [dbo].[AUDITORIAS_LOGIN] (
    [Id_Auditoria_Login] int IDENTITY(1,1) NOT NULL,
    [Entrada] datetime  NOT NULL,
    [Salida] datetime  NULL,
    [USUARIO_Id_Usuario] int  NOT NULL
);
GO

-- Creating table 'CLIENTES'
CREATE TABLE [dbo].[CLIENTES] (
    [Id_Cliente] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [DNI] int  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Ciudad] nvarchar(max)  NOT NULL,
    [Provincia] nvarchar(max)  NOT NULL,
    [Cuenta_Corriente] bit  NOT NULL
);
GO

-- Creating table 'FACTURAS'
CREATE TABLE [dbo].[FACTURAS] (
    [Id_Factura] int IDENTITY(1,1) NOT NULL,
    [Tipo_Factura] nvarchar(max)  NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Nro_Factura] int  NOT NULL,
    [CLIENTE_Id_Cliente] int  NOT NULL
);
GO

-- Creating table 'PRODUCTOS'
CREATE TABLE [dbo].[PRODUCTOS] (
    [Codigo_Producto] int  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [Precio_Costo] decimal(18,0)  NOT NULL,
    [Stock] decimal(18,0)  NOT NULL,
    [Stock_Minimo] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'MOVIMIENTOS'
CREATE TABLE [dbo].[MOVIMIENTOS] (
    [Id_Movimiento] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Tipo_Comprobante] nvarchar(max)  NULL,
    [Nro_Comprobante] int  NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Facturado] decimal(18,0)  NULL,
    [Pagado] decimal(18,0)  NOT NULL,
    [id_Cliente] int  NOT NULL,
    [Importe_Cancelado] decimal(18,0)  NULL,
    [Saldo] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'RECIBOS'
CREATE TABLE [dbo].[RECIBOS] (
    [Id_Recibo] int IDENTITY(1,1) NOT NULL,
    [Nro_Recibo] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [Constancia] nvarchar(max)  NOT NULL,
    [CLIENTE_Id_Cliente] int  NOT NULL
);
GO

-- Creating table 'NOTAS_CREDITO'
CREATE TABLE [dbo].[NOTAS_CREDITO] (
    [Id_Nc] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Nro_Nc] int  NOT NULL,
    [Nro_Factura] int  NOT NULL,
    [CLIENTE_Id_Cliente] int  NOT NULL
);
GO

-- Creating table 'CAJAS'
CREATE TABLE [dbo].[CAJAS] (
    [Id_Caja] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MOVIMIENTOS_CAJA'
CREATE TABLE [dbo].[MOVIMIENTOS_CAJA] (
    [Id_Movimiento] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Concepto] nvarchar(max)  NOT NULL,
    [Comprobante] nvarchar(max)  NOT NULL,
    [Número_Comprobante] int  NOT NULL,
    [Forma_de_Pago] nvarchar(max)  NULL,
    [Entrada] decimal(18,0)  NOT NULL,
    [Salida] decimal(18,0)  NOT NULL,
    [CAJA_Id_Caja] int  NOT NULL
);
GO

-- Creating table 'FORMAS_DE_PAGOS'
CREATE TABLE [dbo].[FORMAS_DE_PAGOS] (
    [Id_Forma] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DETALLES_FACTURA'
CREATE TABLE [dbo].[DETALLES_FACTURA] (
    [id_Factura] int  NOT NULL,
    [Codigo_Producto] int  NOT NULL,
    [Cantidad] decimal(18,0)  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'TARJETAS'
CREATE TABLE [dbo].[TARJETAS] (
    [Id_Tarjeta] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'USUARIOGRUPO'
CREATE TABLE [dbo].[USUARIOGRUPO] (
    [USUARIO_Id_Usuario] int  NOT NULL,
    [GRUPO_Id_Grupo] int  NOT NULL
);
GO

-- Creating table 'GRUPOACCION'
CREATE TABLE [dbo].[GRUPOACCION] (
    [GRUPO_Id_Grupo] int  NOT NULL,
    [ACCION_Id_Accion] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Usuario] in table 'USUARIOS'
ALTER TABLE [dbo].[USUARIOS]
ADD CONSTRAINT [PK_USUARIOS]
    PRIMARY KEY CLUSTERED ([Id_Usuario] ASC);
GO

-- Creating primary key on [Id_Modulo] in table 'MODULOS'
ALTER TABLE [dbo].[MODULOS]
ADD CONSTRAINT [PK_MODULOS]
    PRIMARY KEY CLUSTERED ([Id_Modulo] ASC);
GO

-- Creating primary key on [Id_Submodulo] in table 'SUBMODULOS'
ALTER TABLE [dbo].[SUBMODULOS]
ADD CONSTRAINT [PK_SUBMODULOS]
    PRIMARY KEY CLUSTERED ([Id_Submodulo] ASC);
GO

-- Creating primary key on [Id_Formulario] in table 'FORMULARIOS'
ALTER TABLE [dbo].[FORMULARIOS]
ADD CONSTRAINT [PK_FORMULARIOS]
    PRIMARY KEY CLUSTERED ([Id_Formulario] ASC);
GO

-- Creating primary key on [Id_Accion] in table 'ACCIONES'
ALTER TABLE [dbo].[ACCIONES]
ADD CONSTRAINT [PK_ACCIONES]
    PRIMARY KEY CLUSTERED ([Id_Accion] ASC);
GO

-- Creating primary key on [Id_Grupo] in table 'GRUPOS'
ALTER TABLE [dbo].[GRUPOS]
ADD CONSTRAINT [PK_GRUPOS]
    PRIMARY KEY CLUSTERED ([Id_Grupo] ASC);
GO

-- Creating primary key on [Id_Auditoria_Login] in table 'AUDITORIAS_LOGIN'
ALTER TABLE [dbo].[AUDITORIAS_LOGIN]
ADD CONSTRAINT [PK_AUDITORIAS_LOGIN]
    PRIMARY KEY CLUSTERED ([Id_Auditoria_Login] ASC);
GO

-- Creating primary key on [Id_Cliente] in table 'CLIENTES'
ALTER TABLE [dbo].[CLIENTES]
ADD CONSTRAINT [PK_CLIENTES]
    PRIMARY KEY CLUSTERED ([Id_Cliente] ASC);
GO

-- Creating primary key on [Id_Factura] in table 'FACTURAS'
ALTER TABLE [dbo].[FACTURAS]
ADD CONSTRAINT [PK_FACTURAS]
    PRIMARY KEY CLUSTERED ([Id_Factura] ASC);
GO

-- Creating primary key on [Codigo_Producto] in table 'PRODUCTOS'
ALTER TABLE [dbo].[PRODUCTOS]
ADD CONSTRAINT [PK_PRODUCTOS]
    PRIMARY KEY CLUSTERED ([Codigo_Producto] ASC);
GO

-- Creating primary key on [Id_Movimiento] in table 'MOVIMIENTOS'
ALTER TABLE [dbo].[MOVIMIENTOS]
ADD CONSTRAINT [PK_MOVIMIENTOS]
    PRIMARY KEY CLUSTERED ([Id_Movimiento] ASC);
GO

-- Creating primary key on [Id_Recibo] in table 'RECIBOS'
ALTER TABLE [dbo].[RECIBOS]
ADD CONSTRAINT [PK_RECIBOS]
    PRIMARY KEY CLUSTERED ([Id_Recibo] ASC);
GO

-- Creating primary key on [Id_Nc] in table 'NOTAS_CREDITO'
ALTER TABLE [dbo].[NOTAS_CREDITO]
ADD CONSTRAINT [PK_NOTAS_CREDITO]
    PRIMARY KEY CLUSTERED ([Id_Nc] ASC);
GO

-- Creating primary key on [Id_Caja] in table 'CAJAS'
ALTER TABLE [dbo].[CAJAS]
ADD CONSTRAINT [PK_CAJAS]
    PRIMARY KEY CLUSTERED ([Id_Caja] ASC);
GO

-- Creating primary key on [Id_Movimiento] in table 'MOVIMIENTOS_CAJA'
ALTER TABLE [dbo].[MOVIMIENTOS_CAJA]
ADD CONSTRAINT [PK_MOVIMIENTOS_CAJA]
    PRIMARY KEY CLUSTERED ([Id_Movimiento] ASC);
GO

-- Creating primary key on [Id_Forma] in table 'FORMAS_DE_PAGOS'
ALTER TABLE [dbo].[FORMAS_DE_PAGOS]
ADD CONSTRAINT [PK_FORMAS_DE_PAGOS]
    PRIMARY KEY CLUSTERED ([Id_Forma] ASC);
GO

-- Creating primary key on [id_Factura], [Codigo_Producto] in table 'DETALLES_FACTURA'
ALTER TABLE [dbo].[DETALLES_FACTURA]
ADD CONSTRAINT [PK_DETALLES_FACTURA]
    PRIMARY KEY CLUSTERED ([id_Factura], [Codigo_Producto] ASC);
GO

-- Creating primary key on [Id_Tarjeta] in table 'TARJETAS'
ALTER TABLE [dbo].[TARJETAS]
ADD CONSTRAINT [PK_TARJETAS]
    PRIMARY KEY CLUSTERED ([Id_Tarjeta] ASC);
GO

-- Creating primary key on [USUARIO_Id_Usuario], [GRUPO_Id_Grupo] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [PK_USUARIOGRUPO]
    PRIMARY KEY CLUSTERED ([USUARIO_Id_Usuario], [GRUPO_Id_Grupo] ASC);
GO

-- Creating primary key on [GRUPO_Id_Grupo], [ACCION_Id_Accion] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [PK_GRUPOACCION]
    PRIMARY KEY CLUSTERED ([GRUPO_Id_Grupo], [ACCION_Id_Accion] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MODULO_Id_Modulo] in table 'SUBMODULOS'
ALTER TABLE [dbo].[SUBMODULOS]
ADD CONSTRAINT [FK_MODULOSUBMODULO]
    FOREIGN KEY ([MODULO_Id_Modulo])
    REFERENCES [dbo].[MODULOS]
        ([Id_Modulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MODULOSUBMODULO'
CREATE INDEX [IX_FK_MODULOSUBMODULO]
ON [dbo].[SUBMODULOS]
    ([MODULO_Id_Modulo]);
GO

-- Creating foreign key on [SUBMODULO_Id_Submodulo] in table 'FORMULARIOS'
ALTER TABLE [dbo].[FORMULARIOS]
ADD CONSTRAINT [FK_SUBMODULOFORMULARIO]
    FOREIGN KEY ([SUBMODULO_Id_Submodulo])
    REFERENCES [dbo].[SUBMODULOS]
        ([Id_Submodulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SUBMODULOFORMULARIO'
CREATE INDEX [IX_FK_SUBMODULOFORMULARIO]
ON [dbo].[FORMULARIOS]
    ([SUBMODULO_Id_Submodulo]);
GO

-- Creating foreign key on [FORMULARIO_Id_Formulario] in table 'ACCIONES'
ALTER TABLE [dbo].[ACCIONES]
ADD CONSTRAINT [FK_FORMULARIOACCION]
    FOREIGN KEY ([FORMULARIO_Id_Formulario])
    REFERENCES [dbo].[FORMULARIOS]
        ([Id_Formulario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FORMULARIOACCION'
CREATE INDEX [IX_FK_FORMULARIOACCION]
ON [dbo].[ACCIONES]
    ([FORMULARIO_Id_Formulario]);
GO

-- Creating foreign key on [USUARIO_Id_Usuario] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [FK_USUARIOGRUPO_USUARIO]
    FOREIGN KEY ([USUARIO_Id_Usuario])
    REFERENCES [dbo].[USUARIOS]
        ([Id_Usuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [GRUPO_Id_Grupo] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [FK_USUARIOGRUPO_GRUPO]
    FOREIGN KEY ([GRUPO_Id_Grupo])
    REFERENCES [dbo].[GRUPOS]
        ([Id_Grupo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIOGRUPO_GRUPO'
CREATE INDEX [IX_FK_USUARIOGRUPO_GRUPO]
ON [dbo].[USUARIOGRUPO]
    ([GRUPO_Id_Grupo]);
GO

-- Creating foreign key on [GRUPO_Id_Grupo] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [FK_GRUPOACCION_GRUPO]
    FOREIGN KEY ([GRUPO_Id_Grupo])
    REFERENCES [dbo].[GRUPOS]
        ([Id_Grupo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ACCION_Id_Accion] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [FK_GRUPOACCION_ACCION]
    FOREIGN KEY ([ACCION_Id_Accion])
    REFERENCES [dbo].[ACCIONES]
        ([Id_Accion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GRUPOACCION_ACCION'
CREATE INDEX [IX_FK_GRUPOACCION_ACCION]
ON [dbo].[GRUPOACCION]
    ([ACCION_Id_Accion]);
GO

-- Creating foreign key on [USUARIO_Id_Usuario] in table 'AUDITORIAS_LOGIN'
ALTER TABLE [dbo].[AUDITORIAS_LOGIN]
ADD CONSTRAINT [FK_USUARIOAUDITORIA_LOGIN]
    FOREIGN KEY ([USUARIO_Id_Usuario])
    REFERENCES [dbo].[USUARIOS]
        ([Id_Usuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIOAUDITORIA_LOGIN'
CREATE INDEX [IX_FK_USUARIOAUDITORIA_LOGIN]
ON [dbo].[AUDITORIAS_LOGIN]
    ([USUARIO_Id_Usuario]);
GO

-- Creating foreign key on [CLIENTE_Id_Cliente] in table 'FACTURAS'
ALTER TABLE [dbo].[FACTURAS]
ADD CONSTRAINT [FK_CLIENTEFACTURA]
    FOREIGN KEY ([CLIENTE_Id_Cliente])
    REFERENCES [dbo].[CLIENTES]
        ([Id_Cliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CLIENTEFACTURA'
CREATE INDEX [IX_FK_CLIENTEFACTURA]
ON [dbo].[FACTURAS]
    ([CLIENTE_Id_Cliente]);
GO

-- Creating foreign key on [CLIENTE_Id_Cliente] in table 'RECIBOS'
ALTER TABLE [dbo].[RECIBOS]
ADD CONSTRAINT [FK_CLIENTERECIBO]
    FOREIGN KEY ([CLIENTE_Id_Cliente])
    REFERENCES [dbo].[CLIENTES]
        ([Id_Cliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CLIENTERECIBO'
CREATE INDEX [IX_FK_CLIENTERECIBO]
ON [dbo].[RECIBOS]
    ([CLIENTE_Id_Cliente]);
GO

-- Creating foreign key on [CLIENTE_Id_Cliente] in table 'NOTAS_CREDITO'
ALTER TABLE [dbo].[NOTAS_CREDITO]
ADD CONSTRAINT [FK_CLIENTENOTA_CREDITO]
    FOREIGN KEY ([CLIENTE_Id_Cliente])
    REFERENCES [dbo].[CLIENTES]
        ([Id_Cliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CLIENTENOTA_CREDITO'
CREATE INDEX [IX_FK_CLIENTENOTA_CREDITO]
ON [dbo].[NOTAS_CREDITO]
    ([CLIENTE_Id_Cliente]);
GO

-- Creating foreign key on [CAJA_Id_Caja] in table 'MOVIMIENTOS_CAJA'
ALTER TABLE [dbo].[MOVIMIENTOS_CAJA]
ADD CONSTRAINT [FK_CAJAMOVIMIENTO_CAJA]
    FOREIGN KEY ([CAJA_Id_Caja])
    REFERENCES [dbo].[CAJAS]
        ([Id_Caja])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CAJAMOVIMIENTO_CAJA'
CREATE INDEX [IX_FK_CAJAMOVIMIENTO_CAJA]
ON [dbo].[MOVIMIENTOS_CAJA]
    ([CAJA_Id_Caja]);
GO

-- Creating foreign key on [id_Factura] in table 'DETALLES_FACTURA'
ALTER TABLE [dbo].[DETALLES_FACTURA]
ADD CONSTRAINT [FK_FACTURADETALLE_FACTURA]
    FOREIGN KEY ([id_Factura])
    REFERENCES [dbo].[FACTURAS]
        ([Id_Factura])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Codigo_Producto] in table 'DETALLES_FACTURA'
ALTER TABLE [dbo].[DETALLES_FACTURA]
ADD CONSTRAINT [FK_PRODUCTODETALLE_FACTURA]
    FOREIGN KEY ([Codigo_Producto])
    REFERENCES [dbo].[PRODUCTOS]
        ([Codigo_Producto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODUCTODETALLE_FACTURA'
CREATE INDEX [IX_FK_PRODUCTODETALLE_FACTURA]
ON [dbo].[DETALLES_FACTURA]
    ([Codigo_Producto]);
GO

-- Creating foreign key on [id_Cliente] in table 'MOVIMIENTOS'
ALTER TABLE [dbo].[MOVIMIENTOS]
ADD CONSTRAINT [FK_CLIENTEMOVIMIENTO]
    FOREIGN KEY ([id_Cliente])
    REFERENCES [dbo].[CLIENTES]
        ([Id_Cliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CLIENTEMOVIMIENTO'
CREATE INDEX [IX_FK_CLIENTEMOVIMIENTO]
ON [dbo].[MOVIMIENTOS]
    ([id_Cliente]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------