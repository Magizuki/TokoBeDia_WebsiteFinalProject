CREATE TABLE [dbo].[Products] (
    [ProductID]     INT           IDENTITY (1, 1) NOT NULL,
    [ProductTypeID] INT           NOT NULL,
    [ProductName]   VARCHAR (255) NOT NULL,
    [ProductPrice]  INT           NULL,
    [ProductStock]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC),
    FOREIGN KEY ([ProductTypeID]) REFERENCES [dbo].[ProductTypes] ([ProductTypeID])
);

