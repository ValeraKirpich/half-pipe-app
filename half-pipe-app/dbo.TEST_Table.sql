CREATE TABLE [dbo].[Покупатели] (
    [Id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Покупатели_ToTable] FOREIGN KEY ([id]) REFERENCES [Покупатели]([id]) 
);

