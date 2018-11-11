/****** Object:  Table [dbo].[Categories]    Script Date: 30/10/2016 15:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] NULL,
	[CategoryName] [varchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 30/10/2016 15:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] NULL,
	[CompanyName] [varchar](50) NULL,
	[ContactName] [varchar](30) NULL,
	[ContactTitle] [varchar](30) NULL,
	[Address] [varchar](60) NULL,
	[City] [varchar](15) NULL,
	[Region] [varchar](15) NULL,
	[PostalCode] [varchar](10) NULL,
	[Country] [varchar](10) NULL,
	[Phone] [varchar](25) NULL,
	[Fax] [varchar](25) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 30/10/2016 15:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] NULL,
	[Lastname] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[Title] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Country] [varchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 30/10/2016 15:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] NULL,
	[CategoryId] [int] NULL,
	[ProductName] [varchar](50) NULL,
	[UnitsInStock] [int] NULL,
	[UnitPrice] [decimal](18, 0) NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[VistaProductos]    Script Date: 30/10/2016 15:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaProductos]
AS
SELECT        ProductId AS Codigo, ProductName AS Nombre, CategoryId AS Categoria, UnitPrice AS Precio, UnitsInStock AS Stock
FROM            dbo.Products

GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Categoria 1')
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Categoria 2')
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Categoria 3')
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Categoria 4')
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (5, N'Categoria 5')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (1, N'Arcor', N'info@arcor.com', N'email', N'Calle 1234 Barraca', N'Capital', N'Centro', N'5909', N'Brasil', N'1145456768', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (2, N'Empresa 1', N'info@emp1.com', N'email', N'Oca 44 Escalada', N'Lanus', N'Sur', N'1826', N'Argentina', N'1149055768', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (3, N'Horizonte', N'info@horizonte.com', N'email', N'Loto 44 Flores', N'Capital', N'Centro', N'5910', N'Argentina', N'1149900987', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (4, N'coto', N'info@coto.com', N'email', N'Hornos 340 Barraca', N'Capital', N'Centro', N'5909', N'Argentina', N'1142324567', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (5, N'Empresa 2', N'info@emp2.com', N'email', N'victoria 987 Pacheco', N'Tigre', N'Norte', N'8888', N'Argentina', N'1146789000', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (6, N'Clarin', N'info@clarin.com', N'email', N'rioja 1234 Once', N'Capital', N'Centro', N'5911', N'Argentina', N'1145450921', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (7, N'Mercado Libre', N'info@ml.com', N'email', N'Rivadavia 5434 Caballito', N'Capital', N'Centro', N'5921', N'Argentina', N'1145451111', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (8, N'Garbarino', N'info@garba.com', N'email', N'Alem 6768 San Telmo', N'Capital', N'Centro', N'8900', N'Argentina', N'1148098745', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (9, N'Fravega', N'info@fravega.com', N'email', N'Chubut 4044 Belgrano', N'Montevideo', N'Centro', N'3333', N'Uruguay', N'1148900903', N'-')
GO
INSERT [dbo].[Customer] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (10, N'Rafael', N'rdi@mail.com', NULL, NULL, N'Lanus', NULL, NULL, N'Argentina', NULL, NULL)
GO
INSERT [dbo].[Employees] ([Id], [Lastname], [FirstName], [Title], [City], [Country]) VALUES (1, N'Olmos', N'Carlos', N'Contador', N'Lanus', N'Argentina')
GO
INSERT [dbo].[Employees] ([Id], [Lastname], [FirstName], [Title], [City], [Country]) VALUES (2, N'Lopez', N'Luis', N'Ingeniero', N'Capital', N'Argentina')
GO
INSERT [dbo].[Employees] ([Id], [Lastname], [FirstName], [Title], [City], [Country]) VALUES (3, N'Rodriguez', N'Ricardo', N'Administrativo', N'Bogota', N'Colombia')
GO
INSERT [dbo].[Employees] ([Id], [Lastname], [FirstName], [Title], [City], [Country]) VALUES (4, N'Marquez', N'Lucas', N'Gerente', N'Montevideo', N'Uruguay')
GO
INSERT [dbo].[Employees] ([Id], [Lastname], [FirstName], [Title], [City], [Country]) VALUES (5, N'Chavez', N'Pablo', N'Administrativo', N'Lomas', N'Argentina')
GO
INSERT [dbo].[Employees] ([Id], [Lastname], [FirstName], [Title], [City], [Country]) VALUES (6, N'Ponce', N'Carlos', N'Publicista', N'Capital', N'Argentina')
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (1, 1, N'Producto Beta', 5, CAST(25 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (2, 1, N'Producto Especial', 1, CAST(20 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (3, 2, N'Producto Comun', 8, CAST(25 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (4, 3, N'Producto Extra', 15, CAST(5 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (5, 4, N'Producto Gama', 50, CAST(2 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (6, 2, N'Producto Nivel', 10, CAST(12 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (7, 4, N'Producto 2da', 3, CAST(30 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (8, 5, N'Producto 3ra', 20, CAST(50 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (9, 5, N'Producto Flow', 57, CAST(8 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (10, 2, N'ProductoLunes', 11, CAST(12 AS Decimal(18, 0)))
GO
/****** Object:  StoredProcedure [dbo].[p_alta_cliente]    Script Date: 30/10/2016 15:53:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_alta_cliente]
(
	@idCliente int,
	@Cliente   varchar(50),
	@Contacto    varchar(50),
	@Ciudad varchar(50),
	@Pais varchar(50)
)
AS  



	SET NOCOUNT ON;
	BEGIN 
		BEGIN TRANSACTION 
			insert into Customer (CustomerID, CompanyName, ContactName,City,Country)
			values (@idCliente,@Cliente,@Contacto,@Ciudad,@Pais)
  
	COMMIT

	END  


GO
