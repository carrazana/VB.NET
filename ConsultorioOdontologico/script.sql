USE [ConsultorioOdontologicoFInal]
GO
/****** Object:  Table [dbo].[insumos]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[insumos](
	[id] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_insumos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (1, N'Porcelana')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (2, N'Acrilico')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (3, N'Aleacion Metalica')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (4, N'Silicona')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (5, N'Kit Exploracion')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (6, N'Sustancia Reveladora')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (7, N'Pasta Blanqueadora')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (8, N'Yeso')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (9, N'Alginato')
INSERT [dbo].[insumos] ([id], [descripcion]) VALUES (10, N'Cera')
/****** Object:  Table [dbo].[historiales]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historiales](
	[nroHistorial] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_historiales] PRIMARY KEY CLUSTERED 
(
	[nroHistorial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[especializaciones]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[especializaciones](
	[id] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_especializaciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[especializaciones] ([id], [descripcion]) VALUES (1, N'ODONTOLOGIA')
INSERT [dbo].[especializaciones] ([id], [descripcion]) VALUES (2, N'IMPLANTES')
INSERT [dbo].[especializaciones] ([id], [descripcion]) VALUES (3, N'PROTESIS FIJA')
INSERT [dbo].[especializaciones] ([id], [descripcion]) VALUES (4, N'ORTODONCIA')
INSERT [dbo].[especializaciones] ([id], [descripcion]) VALUES (5, N'CIRUGIA')
INSERT [dbo].[especializaciones] ([id], [descripcion]) VALUES (6, N'ESTETICA')
/****** Object:  Table [dbo].[empleadoXhorario]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleadoXhorario](
	[codEmpleado] [int] NULL,
	[horaIngreso] [time](7) NULL,
	[horaSalida] [time](7) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[empleadoXhorario] ([codEmpleado], [horaIngreso], [horaSalida]) VALUES (1, CAST(0x070040230E430000 AS Time), CAST(0x070010ACD1530000 AS Time))
INSERT [dbo].[empleadoXhorario] ([codEmpleado], [horaIngreso], [horaSalida]) VALUES (2, CAST(0x070010ACD1530000 AS Time), CAST(0x0700E03495640000 AS Time))
/****** Object:  Table [dbo].[empleadoXespecializacion]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleadoXespecializacion](
	[codEmpleado] [int] NULL,
	[codEspecializacion] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[empleadoXespecializacion] ([codEmpleado], [codEspecializacion]) VALUES (1, 1)
INSERT [dbo].[empleadoXespecializacion] ([codEmpleado], [codEspecializacion]) VALUES (2, 2)
/****** Object:  Table [dbo].[empleadoXcargos]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleadoXcargos](
	[idCargo] [int] NULL,
	[codEmpleado] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[empleadoXcargos] ([idCargo], [codEmpleado]) VALUES (1, 1)
INSERT [dbo].[empleadoXcargos] ([idCargo], [codEmpleado]) VALUES (1, 2)
/****** Object:  Table [dbo].[empleados]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[codigoEmpleado] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[idTipoDoc] [int] NULL,
	[documento] [nchar](10) NULL,
	[fechaNac] [date] NULL,
	[telefono] [nchar](30) NULL,
	[celular] [nchar](30) NULL,
	[calle] [nvarchar](50) NULL,
	[numero] [nchar](10) NULL,
	[idLocalidad] [int] NULL,
	[piso] [nchar](10) NULL,
	[depto] [nvarchar](50) NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[codigoEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[empleados] ([codigoEmpleado], [nombre], [apellido], [idTipoDoc], [documento], [fechaNac], [telefono], [celular], [calle], [numero], [idLocalidad], [piso], [depto]) VALUES (1, N'Lionel', N'Messi', 1, N'66666666  ', CAST(0x2F250B00 AS Date), N'                              ', N'                              ', N'ituzaingo', N'11        ', 2, N'          ', N'')
INSERT [dbo].[empleados] ([codigoEmpleado], [nombre], [apellido], [idTipoDoc], [documento], [fechaNac], [telefono], [celular], [calle], [numero], [idLocalidad], [piso], [depto]) VALUES (2, N'Carlos', N'Tevez', 1, N'22222222  ', CAST(0xC5190B00 AS Date), N'                              ', N'                              ', N'Obispo Trejo', N'23        ', 1, N'          ', N'')
/****** Object:  Table [dbo].[detalleCompraInsumos]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleCompraInsumos](
	[codProveedor] [int] NULL,
	[fechaHora] [date] NULL,
	[codInsumo] [int] NULL,
	[cantidad] [nchar](10) NULL,
	[precioUnitario] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compraInsumos]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compraInsumos](
	[codProveedor] [int] NULL,
	[fechaHora] [date] NULL,
	[montoTotal] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cargos]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cargos](
	[id] [int] NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[cargos] ([id], [descripcion]) VALUES (1, N'ODONTOLOGIA')
INSERT [dbo].[cargos] ([id], [descripcion]) VALUES (2, N'LIMPIEZA')
/****** Object:  Table [dbo].[buscador]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buscador](
	[id] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_buscador] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[buscador] ([id], [descripcion]) VALUES (1, N'DOCUMENTO')
INSERT [dbo].[buscador] ([id], [descripcion]) VALUES (2, N'APELLIDO')
INSERT [dbo].[buscador] ([id], [descripcion]) VALUES (3, N'NOMBRE')
/****** Object:  Table [dbo].[proveedores]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[idProveedores] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[nombre_responsable] [nvarchar](50) NULL,
	[telefono] [nchar](50) NULL,
	[mail] [nvarchar](50) NULL,
	[calle] [nvarchar](50) NULL,
	[numero] [nchar](10) NULL,
	[departamento] [nvarchar](50) NULL,
	[piso] [nchar](10) NULL,
	[idLocalidad] [int] NULL,
 CONSTRAINT [PK_proveedores] PRIMARY KEY CLUSTERED 
(
	[idProveedores] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[proveedores] ([idProveedores], [nombre], [nombre_responsable], [telefono], [mail], [calle], [numero], [departamento], [piso], [idLocalidad]) VALUES (1, N'Pedro', N'Gonzalez', N'                                                  ', N'', N'Ituzaingo', N'12        ', N'', N'          ', 5)
/****** Object:  Table [dbo].[pacientes]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pacientes](
	[idTipoDoc] [int] NOT NULL,
	[nroDoc] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[nroHistorial] [nvarchar](50) NULL,
	[telefono] [nvarchar](50) NULL,
	[idLocalidad] [int] NULL,
	[fechaNacimiento] [nvarchar](50) NULL,
	[celular] [nvarchar](50) NULL,
	[calle] [nvarchar](50) NULL,
	[nroCalle] [int] NULL,
	[piso] [nvarchar](50) NULL,
	[departamento] [nvarchar](50) NULL,
 CONSTRAINT [PK_pacientes] PRIMARY KEY NONCLUSTERED 
(
	[nroDoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[pacientes] ([idTipoDoc], [nroDoc], [nombre], [apellido], [nroHistorial], [telefono], [idLocalidad], [fechaNacimiento], [celular], [calle], [nroCalle], [piso], [departamento]) VALUES (1, N'11111111', N'Lionel', N'Messi', N'1', N'', 6, N'23/10/2000', N'', N'Indepencia', 12, N'', N'')
/****** Object:  Table [dbo].[localidades]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[localidades](
	[id] [int] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (0, N'SAN IGNACIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (1, N'ACHIRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (2, N'ADELIA MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (3, N'AGUA DE LAS PIEDRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (4, N'AGUA DE ORO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (5, N'AGUA DEL TALA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (6, N'AGUAS DE RAMON')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (7, N'AGUILA BLANCA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (8, N'ALCIRA ,EST.GIGENA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (9, N'ALEJANDRO ROCA ,EST. ALEJANDRO.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (10, N'ALEJO LEDESMA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (11, N'ALICIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (12, N'ALMAFUERTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (13, N'ALPA CORRAL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (14, N'ALTA CORDOBA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (15, N'ALTA CORDOBA ,EST.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (16, N'ALTA GRACIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (17, N'ALTAUTINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (18, N'ALTO ALEGRE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (19, N'ALTO DEL TALA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (20, N'ALTO FRESCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (21, N'ALTO SAN PEDRO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (22, N'ALTOS DE CHIPION')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (23, N'AMBOY')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (24, N'AMBUL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (25, N'ANA ZUMARAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (26, N'ARBOL BLANCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (27, N'ARGUELLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (28, N'ARIAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (29, N'ARROYITO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (30, N'ARROYO ALGODON')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (31, N'ARROYO CABRAL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (32, N'ASCOCHINGA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (33, N'ASSUNTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (34, N'ATAHONA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (35, N'ATOS PAMPA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (36, N'AUSONIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (37, N'AVELLANEDA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (38, N'BAJO CHICO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (39, N'BALDE DE LA MORA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (40, N'BALLESTEROS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (41, N'BALLESTEROS SUR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (42, N'BALNEARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (43, N'BAÑADO DE SOTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (44, N'BARRANCA YACO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (45, N'BARRETO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (46, N'BARRIO FLORES ,EMB.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (47, N'BELL VILLE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (48, N'BENGOLEA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (49, N'BENJAMIN GOULD')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (50, N'BERROTARAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (51, N'BIALET MASSE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (52, N'BLAS DE ROSALES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (53, N'BOCA DEL TIGRE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (54, N'BOUWER')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (55, N'BRINKMANN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (56, N'BUCHARDO ,EST.HIPOLITO BOUCHARD')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (57, N'BUEN RETIRO ,AP.EL VADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (58, N'BUENA VISTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (59, N'BUEY MUERTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (60, N'BULNES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (61, N'BURMEISTER')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (62, N'CABANA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (63, N'CACHI YACO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (64, N'CACHIYUYO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (65, N'CALCHIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (66, N'CALMAYO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (67, N'CAMILO ALDAO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (68, N'CAMINIAGA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (69, N'CAMPO GRANDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (70, N'CAÑADA DE ALVAREZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (71, N'CAÑADA DE JUME')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (72, N'CAÑADA DE LUQUE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (73, N'CAÑADA DE MACHADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (74, N'CAÑADA DE RIO PINTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (75, N'CAÑADA DE SALAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (76, N'CAÑADA DEL CORO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (77, N'CAÑADA HONDA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (78, N'CANALS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (79, N'CANDELARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (80, N'CANDELARIA NORTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (81, N'CANDELARIA SUD')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (82, N'CANDONGA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (83, N'CANTERAS EL SAUCE ,EST.EMP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (84, N'CANTERAS QUILPO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (85, N'CAPILLA DE LA SAGRADA FAMILIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (86, N'CAPILLA DE LOS REMEDIOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (87, N'CAPILLA DE SITON')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (88, N'CAPILLA DEL CARMEN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (89, N'CAPILLA DEL MONTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (90, N'CAPITAN GENERAL BERNARDO O HIGGINS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (91, N'CARCANO, RAMON J.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (92, N'CARNERILLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (93, N'CAROLINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (94, N'CAROYA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (95, N'CARRILOBO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (96, N'CASA BAMBA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (97, N'CASA GRANDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (98, N'CASERIO LA LONJA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (99, N'CASSAFOUSTH')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (100, N'CASTRO URDIALES')
GO
print 'Processed 100 total records'
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (101, N'CAVALANGO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (102, N'CAVANAGH')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (103, N'CAYUQUEO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (104, N'CERRO COLORADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (105, N'CHAJAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (106, N'CHALACEA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (107, N'CHALACEA CENTRO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (108, N'CHAMICO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (109, N'CHAÑAR VIEJO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (110, N'CHAÑARITOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (111, N'CHANCANI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (112, N'CHARBONIER')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (113, N'CHARRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (114, N'CHAZON')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (115, N'CHILIBROSTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (117, N'CHUCHIRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (118, N'CHUCUL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (119, N'CHUÑA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (120, N'CHUÑA HUASI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (121, N'CHURQUI CAÑADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (122, N'CIENAGA DE ALLENDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (123, N'CIENAGA DE BRITOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (124, N'CIENAGA DEL CORO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (125, N'CINTRA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (126, N'COLAZO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (127, N'COLONIA 10 DE JULIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (128, N'COLONIA ALMADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (129, N'COLONIA ALMADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (130, N'COLONIA ANITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (131, N'COLONIA ANITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (132, N'COLONIA BISMARCK')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (133, N'COLONIA BREMEN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (134, N'COLONIA CAROYA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (135, N'COLONIA COYUNDA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (136, N'COLONIA EL CARMEN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (137, N'COLONIA LA TORDILLA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (138, N'COLONIA LAS CUATRO ESQUINAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (139, N'COLONIA MACKINLAY')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (140, N'COLONIA MALBERTINA ,EMB.KILOMETRO 531')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (141, N'COLONIA MARINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (142, N'COLONIA PROSPERIDAD')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (143, N'COLONIA RIO CHICO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (144, N'COLONIA SAN BARTOLOME')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (145, N'COLONIA SAN PEDRO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (146, N'COLONIA SAN RAFAEL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (147, N'COLONIA SANTA MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (148, N'COLONIA SANTA MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (149, N'COLONIA TIROLESA ,EST.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (150, N'COLONIA VEINTICINCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (151, N'COLONIA VIDELA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (152, N'COLONIA VIGNAUD')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (153, N'COLONIA WALTELINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (154, N'CONLARA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (155, N'COPACABANA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (156, N'CORDOBA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (157, N'CORONEL BAIGORRIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (158, N'CORONEL MOLDES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (159, N'CORONEL OLMEDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (160, N'CORRAL DE BARRANCA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (161, N'CORRAL DE BUSTOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (162, N'CORRAL DEL BAJO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (163, N'CORRALITO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (164, N'CORTES, JERONIMO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (165, N'COSME')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (166, N'COSQUIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (167, N'COSTA SACATE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (168, N'COTAGAITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (169, N'CRAIK, JAMES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (170, N'CRUZ ALTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (171, N'CRUZ CHICA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (172, N'CRUZ DE CAÑA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (173, N'CRUZ DEL EJE ,EST.NORTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (174, N'CRUZ DEL QUEMADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (175, N'CRUZ GRANDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (176, N'CRUZ MOJADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (177, N'CUATRO CAMINOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (178, N'CUATRO VIENTOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (179, N'CUCHI CORRAL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (180, N'CUEVA DE INDIOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (181, N'CUEVA DE LOS PAJARITOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (182, N'CURAPALIGUE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (183, N'DE LA QUINTANA, JOSE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (184, N'DE LA SERNA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (185, N'DEAN FUNES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (186, N'DEL CAMPILLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (187, N'DESPEÑADEROS ,EST.DR.LUCAS A.DE OLMOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (188, N'DEVOTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (189, N'DIQUE SAN ROQUE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (190, N'DOCTOR NICASIO SALAS OROÑO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (191, N'DOLORES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (192, N'DUMESNIL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (193, N'EL ARAÑADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (194, N'EL BAÑADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (195, N'EL BAÑADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (196, N'EL BRETE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (197, N'EL CADILLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (198, N'EL CANO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (199, N'EL CHACHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (200, N'EL CRISPIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (201, N'EL DIQUECITO ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (202, N'EL DURAZNO')
GO
print 'Processed 200 total records'
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (203, N'EL DURAZNO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (204, N'EL FARO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (205, N'EL FLORENTINO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (206, N'EL FORTIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (207, N'EL FUERTECITO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (208, N'EL GATEADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (209, N'EL MANZANO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (210, N'EL MIRADOR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (211, N'EL PAMPERO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (212, N'EL PAYADOR ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (213, N'EL PERCHEL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (214, N'EL PERCHEL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (215, N'EL PONIENTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (216, N'EL PORTEZUELO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (217, N'EL QUEBRACHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (218, N'EL QUEBRACHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (219, N'EL RASTREADOR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (220, N'EL RETIRO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (221, N'EL ROSARIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (222, N'EL SAUCE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (223, N'EL SUNCHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (224, N'EL TAMBO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (225, N'EL TIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (226, N'EL TOSTADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (227, N'EL TUSCAL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (228, N'EL VENCE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (229, N'EL ZAINO ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (230, N'EL ZAPATO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (231, N'ELCANO, SEBASTIAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (232, N'ELENA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (233, N'EMBALSE MINISTRO JUAN PISTARINI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (234, N'ENCRUCIJADAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (235, N'ESCALANTE, WENCESLAO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (236, N'ESCUELA PARACAIDISTAS ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (237, N'ESPINILLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (238, N'ESQUINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (239, N'ESTANCIA DE GUADALUPE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (240, N'ETRURIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (241, N'FALDA DEL CARMEN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (242, N'FERREYRA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (243, N'FLORA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (244, N'FRAGUEIRO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (245, N'FRAY CAYETANO RODRIGUEZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (246, N'FREYRE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (247, N'FUNES, DOMINGO ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (248, N'FUNES, PEDRO E.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (249, N'GARCIA, RAFAEL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (250, N'GAVILAN ,EST.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (251, N'GENERAL BALDISSERA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (252, N'GENERAL CABRERA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (253, N'GENERAL DEHEZA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (254, N'GENERAL FOTHERINGHAM')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (255, N'GENERAL LEVALLE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (256, N'GENERAL ORTIZ DE OCAMPO ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (257, N'GENERAL PAZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (258, N'GENERAL ROCA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (259, N'GENERAL SOLER')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (260, N'GIGENA ESTACION')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (261, N'GOULD, BENJAMIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (262, N'GUANACO MUERTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (263, N'GUARDIA VIEJA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (264, N'GUASAPAMPA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (265, N'GUATIMOZIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (266, N'GUIÑAZU')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (267, N'GUTEMBERG')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (268, N'HERNANDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (269, N'HUANCHILLA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (270, N'HUASCHA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (271, N'HUERTA GRANDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (272, N'HUINCA RENANCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (273, N'IDIAZABAL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (274, N'IGLESIA VIEJA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (275, N'IMPIRA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (276, N'INGENIERO MALMEN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (277, N'INRIVILLE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (278, N'ISCHILIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (279, N'ISCHILIN VIEJO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (280, N'ISLA DE SAN ANTONIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (281, N'ISLA VERDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (282, N'ITALO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (283, N'JEANMAIRE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (284, N'JESUS MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (285, N'JUAREZ CELMAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (286, N'JUAREZ, MARCOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (287, N'KILOMETRO 1,5 AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (288, N'KILOMETRO 136 ,EMP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (289, N'KILOMETRO 16')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (290, N'KILOMETRO 16')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (291, N'KILOMETRO 182 ,DV.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (292, N'KILOMETRO 23')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (293, N'KILOMETRO 23')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (294, N'KILOMETRO 25')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (295, N'KILOMETRO 271 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (296, N'KILOMETRO 316 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (297, N'KILOMETRO 394 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (298, N'KILOMETRO 466 ,DV.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (299, N'KILOMETRO 480 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (300, N'KILOMETRO 541 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (301, N'KILOMETRO 563 ,DV.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (302, N'KILOMETRO 57 ,EST.EMB.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (303, N'KILOMETRO 579 ,AP.')
GO
print 'Processed 300 total records'
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (304, N'KILOMETRO 581 ,EMB.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (305, N'KILOMETRO 608 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (306, N'KILOMETRO 618 ,DV.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (307, N'KILOMETRO 636 ,DV.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (308, N'KILOMETRO 651 ,DV.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (309, N'KILOMETRO 679')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (310, N'KILOMETRO 691 ,DV.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (311, N'KILOMETRO 7')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (312, N'KILOMETRO 730 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (313, N'KILOMETRO 745')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (314, N'KILOMETRO 859 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (315, N'KILOMETRO 865 ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (316, N'KILOMETRO 881 ,EMB.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (317, N'KILOMETRO 9')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (318, N'KILOMETRO 907 ,EST.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (319, N'KILOMETRO 931')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (320, N'LA AGUADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (321, N'LA ARGENTINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (322, N'LA BISMUTINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (324, N'LA BUENA PARADA ,EST.COMECHINGONES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (325, N'LA CALERA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (326, N'LA CAÑADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (327, N'LA CAÑADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (328, N'LA CARLOTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (329, N'LA CAUTIVA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (330, N'LA CORTADERA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (331, N'LA CRUZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (332, N'LA CUESTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (333, N'LA CUMBRE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (334, N'LA ESPERANZA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (335, N'LA ESQUINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (336, N'LA ESTANCIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (337, N'LA FALDA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (338, N'LA FRANCIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (339, N'LA GILDA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (340, N'LA GRANJA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (341, N'LA HERRADURA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (342, N'LA HIGUERA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (343, N'LA JUANITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (344, N'LA LAGUNA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (345, N'LA MAJADILLA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (346, N'LA MUDANA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (347, N'LA NACIONAL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (348, N'LA PALESTINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (349, N'LA PAMPA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (350, N'LA PAQUITA ,EST.PRESIDENTE F.ALCORTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (351, N'LA PARA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (352, N'LA PATRIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (353, N'LA PAZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (354, N'LA PENCA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (355, N'LA PLAYA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (356, N'LA PLAYOSA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (357, N'LA POBLACION')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (358, N'LA POSTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (359, N'LA PUERTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (360, N'LA PUERTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (361, N'LA RAMADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (362, N'LA REPRESA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (363, N'LA RINCONADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (364, N'LA SERRANITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (365, N'LA TABLADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (366, N'LA TABLADA ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (367, N'LA TIGRA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (368, N'LA TOMA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (369, N'LA TOMA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (370, N'LABORDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (371, N'LABOULAYE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (372, N'LAGUNA DEL MONTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (373, N'LAGUNA DEL SUNCHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (374, N'LAGUNA LARGA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (375, N'LAGUNA OSCURA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (376, N'LAGUNILLA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (377, N'LARSEN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (378, N'LAS ACEQUIAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (379, N'LAS ARRIAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (380, N'LAS AVERIAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (381, N'LAS BAJADAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (382, N'LAS CALLES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (383, N'LAS CAÑITAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (384, N'LAS CHACRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (385, N'LAS CHACRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (386, N'LAS CHACRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (387, N'LAS CHACRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (388, N'LAS ENSENADAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (389, N'LAS GAMAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (390, N'LAS HIGUERAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (391, N'LAS ISLETILLAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (392, N'LAS JUNTURAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (393, N'LAS MOJARRAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (394, N'LAS MOSTAZAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (395, N'LAS MOSTAZAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (396, N'LAS PALMAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (397, N'LAS PEÑAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (398, N'LAS PEÑAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (399, N'LAS PERDICES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (400, N'LAS RABONAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (401, N'LAS SALADAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (402, N'LAS TAPIAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (403, N'LAS TAPIAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (404, N'LAS TOSCAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (405, N'LAS TOSCAS')
GO
print 'Processed 400 total records'
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (406, N'LAS VARAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (407, N'LAS VARILLAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (408, N'LAS VERTIENTES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (409, N'LASPIUR, SATURNINO M.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (410, N'LECUEDER')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (411, N'LEDESMA, ALEJO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (412, N'LEGUIZAMON')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (413, N'LEONES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (414, N'LOA ALAMOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (415, N'LOA ALGARROBOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (416, N'LOMAS DE SAN JOSE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (417, N'LOS ALFALFARES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (418, N'LOS ALTOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (419, N'LOS CADILLOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (420, N'LOS CALLEJONES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (421, N'LOS CERRILLOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (422, N'LOS CERRILLOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (423, N'LOS CHAÑARES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (424, N'LOS CHAÑARITOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (425, N'LOS CISNES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (426, N'LOS COCOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (427, N'LOS COMETIERRA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (428, N'LOS CONDORES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (429, N'LOS GIGANTES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (430, N'LOS HORNILLOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (431, N'LOS HOYOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (432, N'LOS JAGUELES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (433, N'LOS MANANTIALES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (434, N'LOS MEDANITOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (435, N'LOS MISTOLES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (436, N'LOS MOLINOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (437, N'LOS MOLLES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (438, N'LOS MOLLES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (439, N'LOS MORTERITOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (440, N'LOS PORONGOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (441, N'LOS POZOS ,AP.KILOMETRO 827')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (442, N'LOS QUEBRACHITOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (443, N'LOS QUEBRACHITOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (444, N'LOS REARTES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (445, N'LOS SAUCES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (446, N'LOS SURGENTES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (447, N'LOS TARTAROS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (448, N'LOS ZORROS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (449, N'LOZADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (450, N'LUCA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (452, N'LUGONES, LEOPOLDO ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (453, N'LUQUE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (454, N'LUTTI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (455, N'LUXARDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (456, N'LUYABA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (457, N'MACHA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (458, N'MAGIGASTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (459, N'MAJADA DE SANTIAGO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (460, N'MALAGUENO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (461, N'MALENA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (462, N'MALLIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (463, N'MALVINAS ARGENTINAS ,EST.KILOMETRO 711')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (464, N'MANANTIALES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (465, N'MANFREDI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (466, N'MANSILLA, LUCIO V.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (467, N'MAQUINISTA GALLINI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (468, N'MARULL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (469, N'MATORRALES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (470, N'MATTALDI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (471, N'MEDIA LUNA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (472, N'MEDIA NARANJA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (473, N'MELO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (474, N'MENDIOLAZA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (475, N'MINA CLAVERO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (476, N'MIRAMAR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (477, N'MOLINARI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (478, N'MONTE BUEY')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (479, N'MONTE CRISTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (480, N'MONTE DE LOS GAUCHOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (481, N'MONTE DEL ROSARIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (482, N'MONTE LEÑA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (483, N'MONTE MAIZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (484, N'MONTE RALO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (485, N'MONTE REDONDO ,EST.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (486, N'MORRISON')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (487, N'MORTEROS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (488, N'MULA MUERTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (489, N'MUSSI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (490, N'NARVAJA, TRISTAN ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (491, N'NAZCA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (492, N'NINALQUIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (493, N'NOETINGER')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (494, N'NONO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (495, N'NUEVA ALDALUCIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (496, N'NUÑEZ DEL ORADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (497, N'OBISPO TREJO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (498, N'OJO DE AGUA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (499, N'OJO DE AGUA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (500, N'OLAEN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (501, N'OLAETA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (502, N'OLIVA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (503, N'OLMOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (504, N'ONAGOITY')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (505, N'ONCATIVO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (506, N'ONGAMIRA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (507, N'ORDOÑEZ')
GO
print 'Processed 500 total records'
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (508, N'ORO GRUESO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (509, N'PACHANGO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (510, N'PACHECO DE MELO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (511, N'PAJAS BLANCAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (512, N'PAMPAYASTA NORTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (513, N'PAMPAYASTA SUR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (514, N'PAN DE AZUCAR ,AP.KILOMETRO 592')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (515, N'PANAHOLMA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (516, N'PASCANAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (517, N'PASCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (518, N'PASO DEL RIO SECO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (519, N'PASO VIEJO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (520, N'PAUNERO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (521, N'PAVIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (522, N'PEGASANO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (523, N'PELLICO, SILVIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (524, N'PETER, JAIME')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (525, N'PICHANAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (526, N'PIEDRA BLANCA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (527, N'PIEDRAS ANCHAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (528, N'PIEDRAS BLANCAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (529, N'PIEDRITA BLANCA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (530, N'PIEDRITAS ROSADAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (531, N'PILAR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (532, N'PINAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (533, N'PINCEN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (534, N'PINTOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (535, N'PIQUILLIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (536, N'PIZARRO, MODESTINO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (537, N'PLAYA GRANDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (538, N'PLAZA BRUNO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (539, N'PLAZA COLAZO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (540, N'PLAZA DE MERCEDES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (541, N'PLAZA DEHEZA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (542, N'PLAZA LUXARDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (543, N'PLAZA SAN FRANCISCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (544, N'PLAZA VIDELA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (545, N'POCHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (546, N'PORTEÑA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (547, N'POSSE, JUSTINIANO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (548, N'POZO DE LA LOMA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (549, N'POZO DE LA PAMPA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (550, N'POZO DE LAS OLLAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (551, N'POZO DEL CHAÑAR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (552, N'POZO DEL MOLLE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (553, N'POZO DEL MORO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (554, N'POZO DEL TIGRE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (555, N'PRETOT FREYRE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (556, N'PUEBLO ITALIANO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (557, N'PUEBLO VIEJO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (558, N'PUERTA COLORADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (559, N'PUESTO DE AFUERA ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (560, N'PUESTO DE CASTRO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (561, N'PUESTO DEL ROSARIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (562, N'PUESTO PUCHETA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (563, N'PUESTO SAN JOSE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (564, N'PUNILLA ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (565, N'PUNTA DEL AGUA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (566, N'PUNTA DEL AGUA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (567, N'PUNTA DEL AGUA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (568, N'QUEBRACHO HERRADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (569, N'QUEBRADA DE LOS POZOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (570, N'QUILINO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (571, N'QUISQUIZACATE ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (572, N'RANGEL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (573, N'RANQUELES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (574, N'RARA FORTUNA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (575, N'RAYO CORTADO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (576, N'RINCON')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (577, N'RINCON DE LUNA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (578, N'RIO BAMBA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (579, N'RIO CEBALLOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (580, N'RIO CUARTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (581, N'RIO CUARTO NORTE ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (582, N'RIO DE LOS MOLINOS ,PDA.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (583, N'RIO DE LOS SAUCES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (584, N'RIO HONDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (585, N'RIO PRIMERO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (586, N'RIO SEGUNDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (587, N'RIO TERCERO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (588, N'RIVERA INDARTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (589, N'ROCA, ALEJANDRO ,EST.ALEJANDRO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (590, N'RODEO GRANDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (591, N'RODEO VIEJO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (592, N'RODRIGUEZ DEL BUSTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (593, N'ROJAS, DIEGO DE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (594, N'ROSALES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (595, N'ROSALES, BLAS DE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (596, N'RUIZ DIAZ DE GUZMAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (597, N'RUMIYACO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (598, N'SACANTA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (599, N'SAGUION')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (600, N'SAIRA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (601, N'SALADILLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (602, N'SALAS, MIGUEL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (603, N'SALDAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (604, N'SALGUERO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (605, N'SALSACATE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (606, N'SALSIPUEDES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (607, N'SAMPACHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (608, N'SAN AGUSTIN')
GO
print 'Processed 600 total records'
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (609, N'SAN AGUSTIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (610, N'SAN AMBROSIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (611, N'SAN ANTINIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (612, N'SAN ANTONIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (613, N'SAN ANTONIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (614, N'SAN ANTONIO DE ARREDONDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (615, N'SAN ANTONIO DE LITIN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (616, N'SAN BARTOLOME')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (617, N'SAN BASILIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (618, N'SAN BUENAVENTURA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (619, N'SAN BUENAVENTURA ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (620, N'SAN CARLOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (621, N'SAN CARLOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (622, N'SAN CLEMENTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (623, N'SAN ESTEBAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (624, N'SAN FERNANDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (625, N'SAN FRANCISCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (626, N'SAN FRANCISCO DEL CHAÑAR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (627, N'SAN GERONIMO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (628, N'SANTA MAGDALENA ,EST.JOVITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (629, N'SANTA MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (630, N'SANTA MARIA DE PUNILLA ,EST.SANTA MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (631, N'SANTA ROSA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (632, N'SANTA ROSA DE CALAMUCHITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (633, N'SANTA ROSA DE RIO PRIMERO ,EST.V.S.ROSA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (634, N'SANTA SABINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (635, N'SANTA TERESA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (636, N'SANTA VICTORIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (637, N'SARMIENTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (638, N'SAUCE DE LOS QUEVEDOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (639, N'SEEBER')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (640, N'SERRANO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (641, N'SERREZUELA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (642, N'SIMBOLAR')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (643, N'SINSACATE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (644, N'SOCONCHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (645, N'SOTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (646, N'SUCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (647, N'SUQUIA ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (648, N'SVILLA NUEVA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (649, N'TABAQUILLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (650, N'TALA CAÑADA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (651, N'TALA CRUZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (652, N'TALA NORTE ,EST.EL ALCALDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (653, N'TALAINI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (654, N'TANCACHA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (655, N'TANTI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (656, N'TANTI NUEVO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (657, N'TASMA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (658, N'TEGUA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (659, N'TEMPLE, SANTIAGO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (660, N'THEA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (661, N'TICINO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (662, N'TILQUICHO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (663, N'TINOCO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (664, N'TIO PUJIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (665, N'TOLEDO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (666, N'TOSNO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (667, N'TOSQUITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (668, N'TOTORALEJOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (669, N'TRANSITO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (670, N'TRAVESIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (671, N'TRES ARBOLES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (672, N'TRINCHERA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (673, N'TUCLAME')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (674, N'UCACHA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (675, N'UNQUILLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (676, N'VALLE HERMOSO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (677, N'VELEZ SARSFIELD, DALMACIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (678, N'VELEZ SARSFIELD, DALMACIO ,AP.')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (679, N'VIAMONTE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (680, N'VICUÑA MACKENNA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (681, N'VILLA AIZACATE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (682, N'VILLA ALICIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (683, N'VILLA ALLENDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (684, N'VILLA ASCASUBI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (685, N'VILLA BUSTOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (686, N'VILLA CANDELARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (687, N'VILLA CARLOS PAZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (688, N'VILLA CERRO AZUL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (689, N'VILLA COLANCHANGA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (690, N'VILLA COLONIA ITALIANA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (691, N'VILLA CONCEPCION DEL TIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (692, N'VILLA CORAZON DE MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (693, N'VILLA CURA BROCHERO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (694, N'VILLA DE LAS ROSAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (695, N'VILLA DE MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (696, N'VILLA DE SOTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (697, N'VILLA DEL DIQUE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (698, N'VILLA DEL LAGO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (699, N'VILLA DEL ROSARIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (700, N'VILLA DEL TOTORAL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (701, N'VILLA DEL TRANSITO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (702, N'VILLA DOLORES')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (703, N'VILLA ELISA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (704, N'VILLA ESQUIU')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (705, N'VILLA FONTANA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (706, N'VILLA GARCIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (707, N'VILLA GENERAL BELGRANO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (708, N'VILLA GIARDINO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (709, N'VILLA GUTIERREZ ,EMB. KM. 807')
GO
print 'Processed 700 total records'
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (710, N'VILLA HUIDOBRO ,EST.CAÑADA VERDE')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (711, N'VILLA ICHO CRUZ')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (712, N'VILLA INDEPENDENCIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (713, N'VILLA LOS MOLINOS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (714, N'VILLA MARIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (715, N'VILLA MODERNA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (716, N'VILLA ÑU PORA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (717, N'VILLA QUILINO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (718, N'VILLA RAFAEL BENEGAS')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (719, N'VILLA REDUCCION')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (720, N'VILLA ROSARIO DEL SALADILLO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (721, N'VILLA ROSSI')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (723, N'VILLA RUMIPAL')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (724, N'VILLA SAN ANTONIO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (725, N'VILLA SAN ESTEBAN')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (726, N'VILLA SARMIENTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (727, N'VILLA TULUMBA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (728, N'VILLA VALERIA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (729, N'VILLA VAUDAGNA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (730, N'VILLA VISO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (731, N'VIVAS, PEDRO E. ,EMB.KILOMETRO 658')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (732, N'VIVERO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (733, N'WASHINGTON')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (734, N'WATT ,EST.MELIDEO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (735, N'YACANTO')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (736, N'YACANTO DE CALAMUCHITA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (737, N'YOCSINA')
INSERT [dbo].[localidades] ([id], [descripcion]) VALUES (738, N'ZUMARAN, ANA')
/****** Object:  Table [dbo].[intervencion]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[intervencion](
	[codIntervencion] [int] IDENTITY(1,1) NOT NULL,
	[fechaHora] [date] NULL,
	[codTratamiento] [int] NULL,
	[nroHistorial] [int] NULL,
	[montonTotal] [nchar](10) NULL,
	[observaciones] [nvarchar](300) NULL,
 CONSTRAINT [PK_intervencion] PRIMARY KEY CLUSTERED 
(
	[codIntervencion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[turnos]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turnos](
	[codEmpleado] [int] NULL,
	[idTipoDocPaciente] [int] NULL,
	[nroDocPaciente] [nchar](10) NULL,
	[fecha] [date] NULL,
	[hora] [time](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tratamientos]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tratamientos](
	[id] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[costo] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tratamientos] ([id], [descripcion], [costo]) VALUES (1, N'Caries', N'100       ')
INSERT [dbo].[tratamientos] ([id], [descripcion], [costo]) VALUES (2, N'Blanqueamiento', N'300       ')
INSERT [dbo].[tratamientos] ([id], [descripcion], [costo]) VALUES (3, N'Consulta', N'100       ')
/****** Object:  Table [dbo].[tipoDocumentos]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoDocumentos](
	[id] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_tipoDocumentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tipoDocumentos] ([id], [descripcion]) VALUES (1, N'DNI')
INSERT [dbo].[tipoDocumentos] ([id], [descripcion]) VALUES (2, N'LE')
INSERT [dbo].[tipoDocumentos] ([id], [descripcion]) VALUES (3, N'LC')
INSERT [dbo].[tipoDocumentos] ([id], [descripcion]) VALUES (4, N'CEDULA')
INSERT [dbo].[tipoDocumentos] ([id], [descripcion]) VALUES (5, N'PASAPORTE')
INSERT [dbo].[tipoDocumentos] ([id], [descripcion]) VALUES (6, N'S/D')
/****** Object:  Table [dbo].[stock]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[codInsumo] [int] NOT NULL,
	[cantidad] [nvarchar](50) NULL,
	[puntoReposicion] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (1, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (2, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (3, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (4, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (5, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (6, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (7, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (8, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (9, N'0', N'COMPRAR')
INSERT [dbo].[stock] ([codInsumo], [cantidad], [puntoReposicion]) VALUES (10, N'0', N'COMPRAR')
/****** Object:  Table [dbo].[insumosXintervencion]    Script Date: 10/23/2015 14:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[insumosXintervencion](
	[codIntervencion] [int] NOT NULL,
	[codInsumo] [int] NOT NULL,
	[cantidadInsumos] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_stock_insumos]    Script Date: 10/23/2015 14:56:47 ******/
ALTER TABLE [dbo].[stock]  WITH CHECK ADD  CONSTRAINT [FK_stock_insumos] FOREIGN KEY([codInsumo])
REFERENCES [dbo].[insumos] ([id])
GO
ALTER TABLE [dbo].[stock] CHECK CONSTRAINT [FK_stock_insumos]
GO
/****** Object:  ForeignKey [FK_insumosXtratamientos_insumos]    Script Date: 10/23/2015 14:56:47 ******/
ALTER TABLE [dbo].[insumosXintervencion]  WITH CHECK ADD  CONSTRAINT [FK_insumosXtratamientos_insumos] FOREIGN KEY([codInsumo])
REFERENCES [dbo].[insumos] ([id])
GO
ALTER TABLE [dbo].[insumosXintervencion] CHECK CONSTRAINT [FK_insumosXtratamientos_insumos]
GO
