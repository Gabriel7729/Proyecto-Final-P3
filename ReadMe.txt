DATABASE

USE [master]
GO
/****** Object:  Database [Alquiler_Vehiculo]    Script Date: 12/04/2021 3:15:44 ******/
CREATE DATABASE [Alquiler_Vehiculo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Alquiler_Vehiculo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Alquiler_Vehiculo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Alquiler_Vehiculo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Alquiler_Vehiculo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Alquiler_Vehiculo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Alquiler_Vehiculo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Alquiler_Vehiculo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET RECOVERY FULL 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET  MULTI_USER 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Alquiler_Vehiculo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Alquiler_Vehiculo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Alquiler_Vehiculo', N'ON'
GO
ALTER DATABASE [Alquiler_Vehiculo] SET QUERY_STORE = OFF
GO
USE [Alquiler_Vehiculo]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](250) NOT NULL,
	[ID_Institucion] [nvarchar](250) NULL,
	[Nombre] [nvarchar](250) NOT NULL,
	[Apellido] [nvarchar](250) NOT NULL,
	[Correo] [nvarchar](250) NOT NULL,
	[Licencia] [nvarchar](250) NOT NULL,
	[Nacionalidad] [nvarchar](250) NOT NULL,
	[Tipo_Sangre] [nvarchar](250) NOT NULL,
	[Foto_Persona] [nvarchar](250) NOT NULL,
	[Foto_Licencia] [nvarchar](250) NOT NULL,
	[Estado] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[ID_Factura] [int] IDENTITY(1,1) NOT NULL,
	[ID_Institucion] [nvarchar](250) NOT NULL,
	[ID_Cliente] [nvarchar](25) NOT NULL,
	[ID_Vehiculo] [nvarchar](25) NOT NULL,
	[Nombre_Cliente] [nvarchar](250) NOT NULL,
	[Apellido_Cliente] [nvarchar](250) NOT NULL,
	[Cedula_Cliente] [nvarchar](250) NOT NULL,
	[Fecha_inc] [date] NOT NULL,
	[Fecha_Fin] [date] NOT NULL,
	[Monto_pagar] [real] NOT NULL,
	[Marca] [nvarchar](250) NOT NULL,
	[Color] [nvarchar](250) NOT NULL,
	[Tipo] [nvarchar](250) NOT NULL,
	[Matricula] [nvarchar](250) NOT NULL,
	[Pago] [bit] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[ID_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Institucion]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institucion](
	[ID_Institucion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](25) NOT NULL,
	[ID_login] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Institucion] PRIMARY KEY CLUSTERED 
(
	[ID_Institucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[ID_login] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](25) NOT NULL,
	[passID] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[ID_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[ID_Reserva] [int] IDENTITY(1,1) NOT NULL,
	[ID_Institucion] [nvarchar](250) NOT NULL,
	[ID_Cliente] [nvarchar](25) NOT NULL,
	[ID_Vehiculo] [nvarchar](25) NOT NULL,
	[Fecha_Inc] [date] NOT NULL,
	[Fecha_Fin] [date] NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[ID_Reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](250) NOT NULL,
	[ID_Institucion] [nvarchar](1) NOT NULL,
	[Modelo] [nvarchar](250) NOT NULL,
	[Año] [date] NOT NULL,
	[Precio_Dia] [real] NOT NULL,
	[Tipo] [nvarchar](250) NOT NULL,
	[Capacidad_Carga] [real] NOT NULL,
	[Pasajeros] [int] NOT NULL,
	[Matricula] [nvarchar](250) NOT NULL,
	[NO_Seguro] [nvarchar](250) NOT NULL,
	[Foto] [nvarchar](250) NOT NULL,
	[Generado] [real] NOT NULL,
	[Veces_Reservados] [int] NOT NULL,
	[Latitud] [real] NOT NULL,
	[Longitud] [real] NOT NULL,
	[Estado] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Article] ON 

INSERT [dbo].[Article] ([ID], [Title]) VALUES (1, N'Antony PAJRAZOZO')
SET IDENTITY_INSERT [dbo].[Article] OFF
GO
SET IDENTITY_INSERT [dbo].[Institucion] ON 

INSERT [dbo].[Institucion] ([ID_Institucion], [Nombre], [ID_login]) VALUES (1, N'Honda.inc', N'1')
INSERT [dbo].[Institucion] ([ID_Institucion], [Nombre], [ID_login]) VALUES (2, N'Toyota.inc', N'2')
SET IDENTITY_INSERT [dbo].[Institucion] OFF
GO
SET IDENTITY_INSERT [dbo].[login] ON 

INSERT [dbo].[login] ([ID_login], [UserID], [passID]) VALUES (1, N'Honda', N'123')
INSERT [dbo].[login] ([ID_login], [UserID], [passID]) VALUES (2, N'Toyota', N'123')
SET IDENTITY_INSERT [dbo].[login] OFF
GO
/****** Object:  StoredProcedure [dbo].[Add_Factura]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Add_Factura]    
	 @ID_Factura NVARCHAR(25),
	 @ID_Institucion NVARCHAR(25),
	 @ID_Cliente Date,
	 @ID_vehiculo Date,
	 @Nombre_Cliente NVARCHAR(250),
	 @Apellido_Cliente NVARCHAR(250),
	 @Cedula_Cliente NVARCHAR(250),
	 @Fecha_inc Date,
	 @Fecha_Fin Date,
	 @Marca NVARCHAR(250),
	 @Monto_pagar NVARCHAR(250),
	 @Color NVARCHAR(250),
	 @Tipo NVARCHAR(250),
	 @Matricula NVARCHAR(250),
	 @Pago bit
	 
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Factura] (ID_Factura,ID_Institucion,ID_Cliente,ID_Vehiculo,Nombre_Cliente,Apellido_Cliente,Cedula_Cliente,Fecha_inc,Fecha_Fin,Marca,Monto_pagar,Color,Tipo,Matricula,Pago)    
        VALUES  ( @ID_Factura,@ID_Institucion,@ID_Cliente,@ID_vehiculo,@Nombre_Cliente,@Apellido_Cliente,@Cedula_Cliente,@Fecha_inc,@Fecha_Fin,@Marca,@Monto_pagar,@Color,@Tipo,@Matricula,@Pago);   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ReservaID;    
    END;  
GO
/****** Object:  StoredProcedure [dbo].[Add_Institucion]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*AGREGA LOS DATOS A LA INSTITUCION*/
CREATE PROCEDURE [dbo].[Add_Institucion]
    @Nombre NVARCHAR(25),
	@ID_login int
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Institucion] (Nombre,ID_login)    
        VALUES  (@Nombre,@ID_login);   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ArticleID;    
    END; 
GO
/****** Object:  StoredProcedure [dbo].[Add_login]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*AGREGA LOS DATOS A LA TABLA LOGIN*/
CREATE PROCEDURE [dbo].[Add_login]
    @UserID NVARCHAR(25),
	 @passID NVARCHAR(25)
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [login] (UserID,passID)    
        VALUES  ( @UserID,@passID);   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ArticleID;    
    END;   
GO
/****** Object:  StoredProcedure [dbo].[Add_Reserva]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Add_Reserva]    
	 @ID_Cliente NVARCHAR(25),
	 @ID_Institucion NVARCHAR(25),
	 @ID_Vehiculo NVARCHAR(25),
	 @Fecha_Inc Date,
	 @Fecha_Fin Date
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Reserva] (ID_Cliente,ID_Institucion,ID_Vehiculo,Fecha_Inc,Fecha_Fin)    
        VALUES  ( @ID_Cliente,@ID_Institucion,@ID_Vehiculo,@Fecha_Inc,@Fecha_Fin);   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ReservaID;    
    END; 
GO
/****** Object:  StoredProcedure [dbo].[SP_Add_Article]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Add_Article]    
    @Title NVARCHAR(250) 
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Article]    
                (Title
             )    
        VALUES  ( @Title       
             );   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ArticleID;    
    END;  
GO
/****** Object:  StoredProcedure [dbo].[SP_Add_Clientes]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Add_Clientes]
	@Cedula NVARCHAR(250),
	@ID_Institucion NVARCHAR(250),
	@Nombre NVARCHAR(250),
	@Apellido NVARCHAR(250),
	@Correo NVARCHAR(250),
	@Licencia NVARCHAR(250),
	@Nacionalidad NVARCHAR(250),
	@Tipo_Sangre NVARCHAR(250),
	@Foto_Persona NVARCHAR(250),
	@Foto_Licencia NVARCHAR(250),
	@Estado NVARCHAR(250)
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Clientes]    
                (Cedula,
				Nombre,
				ID_Institucion,
				Apellido,
				Correo,
				Licencia,
				Nacionalidad,
				Tipo_Sangre,
				Foto_Persona,
				Foto_Licencia,
				Estado

             )    
        VALUES  (@Cedula,
				@ID_Institucion,
				@Nombre,
				@Apellido,
				@Correo,
				@Licencia,
				@Nacionalidad,
				@Tipo_Sangre,
				@Foto_Persona,
				@Foto_Licencia,
				@Estado
             );   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ClienteID;    
    END;   
GO
/****** Object:  StoredProcedure [dbo].[SP_Add_Vehiculos]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Add_Vehiculos]
    @Marca NVARCHAR(250),
	@ID_Institucion NVARCHAR(250),
	@Modelo NVARCHAR(250),
	@Año DATE,
	@Precio_Dia REAL,
	@Tipo NVARCHAR(250),
	@Capacidad_Carga REAL,
	@Pasajeros INT,
	@Matricula NVARCHAR(250),
	@NO_Seguro NVARCHAR(250),
	@Foto NVARCHAR(250),
	@Generado REAL,
	@Veces_Reservados int,
	@Latitud REAL,
	@Longitud REAL,
	@Estado NVARCHAR(250)
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Vehiculos]    
                (Marca,
				ID_Institucion,
				Modelo,
				Año,
				Precio_Dia,
				Tipo,
				Capacidad_Carga,
				Pasajeros,
				Matricula,
				NO_Seguro,
				Foto,
				Generado,
				Veces_Reservados,
				Latitud,
				Longitud,
				Estado
             )    
        VALUES  (@Marca,
				@ID_Institucion,
				@Modelo,
				@Año,
				@Precio_Dia,
				@Tipo,
				@Capacidad_Carga,
				@Pasajeros,
				@Matricula,
				@NO_Seguro,
				@Foto,
				@Generado,
				@Veces_Reservados,
				@Latitud,
				@Longitud,
				@Estado
             );   
		SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS VehiculoID;    
    END;  
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Article]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[SP_Update_Article] 
		@Id INT,   
		@Title NVARCHAR(250)   
	AS    
		BEGIN    

		UPDATE [Article] SET Title = @Title WHERE ID = @Id 
	           
		END;    
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Clientes]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_Clientes] 
		@id int,
		@Cedula NVARCHAR(250),
		@Nombre NVARCHAR(250),		
		@Apellido NVARCHAR(250),
		@Correo NVARCHAR(250),
		@Licencia NVARCHAR(250),
		@Nacionalidad NVARCHAR(250),
		@Tipo_Sangre NVARCHAR(250),
		@Foto_Persona NVARCHAR(250),
		@Foto_Licencia NVARCHAR(250)
	AS    
		BEGIN    

		UPDATE [Clientes] SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Licencia = @Licencia, Nacionalidad = @Nacionalidad, Tipo_Sangre = @Tipo_Sangre, Foto_Persona = @Foto_Persona, Foto_Licencia = @Foto_Licencia WHERE ID = @Id 
	           
		END;
		
		/*Altualizar estado Cliente*/
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Clientes_Estado]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_Clientes_Estado] 
		@id int,
		@Estado NVARCHAR(250)
	AS    
		BEGIN    

		UPDATE [Clientes] SET Estado = @Estado WHERE ID = @id 
	           
		END;
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Vehiculos]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_Vehiculos] 
		@Id INT,   
		@Marca NVARCHAR(250),
		@Modelo NVARCHAR(250),
		@Año DATE,
		@Precio_Dia REAL,
		@Tipo NVARCHAR(250),
		@Capacidad_Carga REAL,
		@Pasajeros INT,
		@Matricula NVARCHAR(250),
		@NO_Seguro NVARCHAR(250),
		@Foto NVARCHAR(250),
		@Latitud REAL,
		@Longitud REAL
	AS  
		BEGIN    

		UPDATE [Vehiculos] SET Marca = @Marca, Modelo = @Modelo, Año = @Año, Precio_Dia = @Precio_Dia, Tipo = @Tipo, Capacidad_Carga = @Capacidad_Carga, Pasajeros = @Pasajeros, Matricula = @Matricula, NO_Seguro = @NO_Seguro, Foto = @Foto, Latitud = @Latitud, Longitud = @Longitud WHERE ID = @Id 
	           
		END;

		/*Update reservado*/
GO
/****** Object:  StoredProcedure [dbo].[Update_Pago_Factura]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[Update_Pago_Factura]
		@id int,
		@Pago bit
	AS    
		BEGIN    

		UPDATE [Factura] SET Pago = @Pago WHERE ID_Factura = @id 
	           
		END;
GO
/****** Object:  StoredProcedure [dbo].[Update_Vehiculo_Estado]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[Update_Vehiculo_Estado]
		@id int,
		@Estado INT
	AS    
		BEGIN    

		UPDATE [Vehiculos] SET Estado = @Estado WHERE ID = @id 
	           
		END;
GO
/****** Object:  StoredProcedure [dbo].[Update_Vehiculo_Generado]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[Update_Vehiculo_Generado]
		@id int,
		@Generado REAL
	AS    
		BEGIN    

		UPDATE [Vehiculos] SET Generado = @Generado WHERE ID = @id 
	           
		END;

		/*Update reservado*/
GO
/****** Object:  StoredProcedure [dbo].[Update_Vehiculo_Reservado]    Script Date: 12/04/2021 3:15:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[Update_Vehiculo_Reservado]
		@id int,
		@Veces_Reservados INT
	AS    
		BEGIN    

		UPDATE [Vehiculos] SET Veces_Reservados = @Veces_Reservados WHERE ID = @id 
	           
		END; 
GO
USE [master]
GO
ALTER DATABASE [Alquiler_Vehiculo] SET  READ_WRITE 
GO
