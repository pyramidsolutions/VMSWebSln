CREATE TABLE [dbo].[Model] (
    [Model_ID]        INT           NOT NULL,
    [Manufacturer_ID] INT           NOT NULL,
    [Model_Name]      NVARCHAR (20) NOT NULL,
    [Vehicle_Type]    NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Model_ID] ASC),
    FOREIGN KEY ([Manufacturer_ID]) REFERENCES [dbo].[Manufacturer] ([Manufacturer_ID]),
    UNIQUE NONCLUSTERED ([Model_ID] ASC)
);

