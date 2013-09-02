CREATE TABLE [dbo].[Manufacturer] (
    [Manufacturer_ID]   INT           NOT NULL,
    [Manufacturer_Name] NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Manufacturer_ID] ASC),
    UNIQUE NONCLUSTERED ([Manufacturer_ID] ASC)
);

