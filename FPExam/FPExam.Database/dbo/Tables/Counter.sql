CREATE TABLE [dbo].[Counter] (
    [ID]      SMALLINT IDENTITY (1, 1) NOT NULL,
    [Counter] INT      NULL,
    CONSTRAINT [PK_Counter] PRIMARY KEY CLUSTERED ([ID] ASC)
);

