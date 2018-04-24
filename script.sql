//
//Inclusão de registros na tabela PRODUTO
//
USE [Venda]
GO

INSERT INTO [dbo].[Produto]
           ([Descricao]
           ,[Preco])
     VALUES
           ('Seguro Incêndio'
           ,127.98)
GO

INSERT INTO [dbo].[Produto]
           ([Descricao]
           ,[Preco])
     VALUES
           ('Seguro Saúde '
           ,131.67)
GO

//
//Inclusão de registros na tabela VENDEDOR
//
USE [Venda]
GO

INSERT INTO [dbo].[Vendedor]
           ([Nome])
     VALUES
           ('Alex')
GO

INSERT INTO [dbo].[Vendedor]
           ([Nome])
     VALUES
           ('Joana')
GO

INSERT INTO [dbo].[Vendedor]
           ([Nome])
     VALUES
           ('Pedro')
GO

USE [Venda]
GO
//
//Inclusão de registros na tabela VENDA
//
INSERT INTO [dbo].[Venda]
           ([Id]
           ,[Comissao]
           ,[DataVenda]
           ,[ProdutoId]
           ,[VendedorId])
     VALUES
           (1
           ,5.34
           ,'2018-04-22'
           ,1
           ,1)
GO

INSERT INTO [dbo].[Venda]
           ([Id]
           ,[Comissao]
           ,[DataVenda]
           ,[ProdutoId]
           ,[VendedorId])
     VALUES
           (2
           ,5.34
           ,'2018-04-22'
           ,2
           ,2)
GO

INSERT INTO [dbo].[Venda]
           ([Id]
           ,[Comissao]
           ,[DataVenda]
           ,[ProdutoId]
           ,[VendedorId])
     VALUES
           (3
           ,5.34
           ,'2018-04-22'
           ,1
           ,3)
GO
//
