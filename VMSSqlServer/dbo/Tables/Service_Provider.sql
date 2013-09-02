CREATE TABLE [dbo].[Service_Provider] (
    [SP_ID]      INT            NOT NULL,
    [category]   NVARCHAR (20)  NULL,
    [SP_address] NVARCHAR (100) NULL,
    [Telephone]  NCHAR (13)     NULL,
    [Disable]    BIT            NULL,
    PRIMARY KEY CLUSTERED ([SP_ID] ASC),
    UNIQUE NONCLUSTERED ([SP_ID] ASC)
);

