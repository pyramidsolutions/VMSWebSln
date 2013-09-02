CREATE TABLE [dbo].[Improvement] (
    [Improvement_ID]          INT            NOT NULL,
    [SP_ID]                   INT            NOT NULL,
    [Stock_Code]              INT            NOT NULL,
    [Improvement_Description] NVARCHAR (100) NOT NULL,
    [Improvement_price]       MONEY          NOT NULL,
    PRIMARY KEY CLUSTERED ([Improvement_ID] ASC),
    FOREIGN KEY ([SP_ID]) REFERENCES [dbo].[Service_Provider] ([SP_ID]),
    FOREIGN KEY ([Stock_Code]) REFERENCES [dbo].[Vehicle] ([Stock_Code]),
    UNIQUE NONCLUSTERED ([Improvement_ID] ASC)
);

