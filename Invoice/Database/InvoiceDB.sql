USE [master]
GO
/****** Object:  Database [invoiceDB]    Script Date: 28.11.2018 16:35:49 ******/
CREATE DATABASE [invoiceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'invoicesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\invoicesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'invoicesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\invoicesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [invoiceDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [invoiceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [invoiceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [invoiceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [invoiceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [invoiceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [invoiceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [invoiceDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [invoiceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [invoiceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [invoiceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [invoiceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [invoiceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [invoiceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [invoiceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [invoiceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [invoiceDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [invoiceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [invoiceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [invoiceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [invoiceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [invoiceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [invoiceDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [invoiceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [invoiceDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [invoiceDB] SET  MULTI_USER 
GO
ALTER DATABASE [invoiceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [invoiceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [invoiceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [invoiceDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [invoiceDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [invoiceDB] SET QUERY_STORE = OFF
GO
USE [invoiceDB]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 28.11.2018 16:35:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [int] NOT NULL,
	[ArtName] [nvarchar](100) NULL,
	[Units] [nvarchar](50) NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[NetAmount] [money] NOT NULL,
	[Tax] [money] NOT NULL,
	[TaxRate] [float] NOT NULL,
	[TaxAmount] [float] NOT NULL,
	[GrossAmount] [money] NOT NULL,
	[Country] [nvarchar](50) NULL,
	[CdNumber] [nvarchar](50) NULL,
 CONSTRAINT [Article$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 28.11.2018 16:35:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNum] [nvarchar](50) NULL,
	[InvoiceDate] [datetime2](0) NULL,
	[SupplierName] [nvarchar](250) NULL,
	[SupplierAddr] [nvarchar](100) NULL,
	[SupplierINN] [nvarchar](20) NULL,
	[SupplierKPP] [nvarchar](20) NULL,
	[DeliverFrom] [nvarchar](250) NULL,
	[DeliverTo] [nvarchar](250) NULL,
	[OrderNum] [nvarchar](50) NULL,
	[OrderDate] [datetime2](0) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[CustomerAddr] [nvarchar](100) NULL,
	[CustomerINN] [nvarchar](20) NULL,
	[CustomerKPP] [nvarchar](20) NULL,
	[OpCode] [nvarchar](2) NULL,
	[OptionField] [nvarchar](50) NULL,
 CONSTRAINT [Invoice$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Param]    Script Date: 28.11.2018 16:35:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Param](
	[Id] [int] NOT NULL,
	[SupplierName] [nvarchar](250) NULL,
	[SupplierAddr] [nvarchar](250) NULL,
	[SupplierINN] [nvarchar](50) NULL,
	[SupplierKPP] [nvarchar](50) NULL,
	[DeliverFrom] [nvarchar](250) NULL,
	[InvNumPref] [nvarchar](10) NULL,
	[InvNumCnt] [int] NULL,
	[InvNumYear] [smallint] NULL,
 CONSTRAINT [PK_Param] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [Article$InvoiceArticle]    Script Date: 28.11.2018 16:35:49 ******/
CREATE NONCLUSTERED INDEX [Article$InvoiceArticle] ON [dbo].[Article]
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Article$InvoiceID]    Script Date: 28.11.2018 16:35:49 ******/
CREATE NONCLUSTERED INDEX [Article$InvoiceID] ON [dbo].[Article]
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Invoice$IX_Invoices]    Script Date: 28.11.2018 16:35:49 ******/
CREATE UNIQUE NONCLUSTERED INDEX [Invoice$IX_Invoices] ON [dbo].[Invoice]
(
	[InvoiceNum] ASC,
	[InvoiceDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Invoice$IX_SupplierINN]    Script Date: 28.11.2018 16:35:49 ******/
CREATE NONCLUSTERED INDEX [Invoice$IX_SupplierINN] ON [dbo].[Invoice]
(
	[SupplierINN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [DF__Article__Invoice__4D94879B]  DEFAULT ((0)) FOR [InvoiceId]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [DF__Article__ArtQuan__4E88ABD4]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [DF__Article__ArtPric__4F7CD00D]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [DF__Article__NetAmou__5070F446]  DEFAULT ((0)) FOR [NetAmount]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [DF__Article__ArtTax__5165187F]  DEFAULT ((0)) FOR [Tax]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [DF__Article__TaxRate__52593CB8]  DEFAULT ((0)) FOR [TaxRate]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [DF__Article__TaxAmou__534D60F1]  DEFAULT ((0)) FOR [TaxAmount]
GO
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [DF__Article__GrossAm__5441852A]  DEFAULT ((0)) FOR [GrossAmount]
GO
ALTER TABLE [dbo].[Param] ADD  CONSTRAINT [DF_Param_Id]  DEFAULT ((1)) FOR [Id]
GO
ALTER TABLE [dbo].[Param] ADD  CONSTRAINT [DF__OfisParam__InvNu__5535A963]  DEFAULT ((0)) FOR [InvNumCnt]
GO
ALTER TABLE [dbo].[Param] ADD  CONSTRAINT [DF__OfisParam__InvNu__5629CD9C]  DEFAULT ((0)) FOR [InvNumYear]
GO
ALTER TABLE [dbo].[Article]  WITH NOCHECK ADD  CONSTRAINT [Article$InvoiceArticle] FOREIGN KEY([InvoiceId])
REFERENCES [dbo].[Invoice] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [Article$InvoiceArticle]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[ArtID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[InvoiceID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'InvoiceId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[ArtName]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ArtName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[ArtUnits]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Units'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[ArtQuantity]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Quantity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[ArtPrice]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[NetAmount]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'NetAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[ArtTax]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Tax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[TaxRate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'TaxRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[TaxAmount]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'TaxAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[GrossAmount]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'GrossAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[ArtCountry]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Country'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[CDNumber]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'CdNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'CONSTRAINT',@level2name=N'Article$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[InvoiceArticle]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'INDEX',@level2name=N'Article$InvoiceArticle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[InvoiceID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'INDEX',@level2name=N'Article$InvoiceID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Article].[InvoiceArticle]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'CONSTRAINT',@level2name=N'Article$InvoiceArticle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код счета-фактуры' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[InvoiceID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'№ счета-фактуры' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'InvoiceNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[InvoiceNum]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'InvoiceNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата счета-фактуры' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'InvoiceDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[InvoiceDate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'InvoiceDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[SupplierName]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'SupplierName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[SupplierAddr]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'SupplierAddr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[SupplierINN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'SupplierINN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[SupplierKPP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'SupplierKPP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[DeliverFrom]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'DeliverFrom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[DeliverTo]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'DeliverTo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[OrderNum]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'OrderNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[OrderDate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'OrderDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[CustomerName]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'CustomerName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[CustomerAddr]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'CustomerAddr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[CustomerINN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'CustomerINN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[CustomerKPP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'CustomerKPP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[KodVO]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'OpCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[PriznakKP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'COLUMN',@level2name=N'OptionField'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'CONSTRAINT',@level2name=N'Invoice$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[IX_Invoices]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'INDEX',@level2name=N'Invoice$IX_Invoices'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice].[IX_SupplierINN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice', @level2type=N'INDEX',@level2name=N'Invoice$IX_SupplierINN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[Invoice]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams].[Supplier_Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param', @level2type=N'COLUMN',@level2name=N'SupplierName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams].[Supplier_Addr]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param', @level2type=N'COLUMN',@level2name=N'SupplierAddr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams].[Supplier_INN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param', @level2type=N'COLUMN',@level2name=N'SupplierINN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams].[Supplier_KPP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param', @level2type=N'COLUMN',@level2name=N'SupplierKPP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams].[Deliver_From]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param', @level2type=N'COLUMN',@level2name=N'DeliverFrom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams].[InvNumPref]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param', @level2type=N'COLUMN',@level2name=N'InvNumPref'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams].[InvNumCnt]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param', @level2type=N'COLUMN',@level2name=N'InvNumCnt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams].[InvNumYear]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param', @level2type=N'COLUMN',@level2name=N'InvNumYear'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'invoices.[OfisParams]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param'
GO
USE [master]
GO
ALTER DATABASE [invoiceDB] SET  READ_WRITE 
GO
