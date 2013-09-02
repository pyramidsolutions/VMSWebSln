CREATE TABLE [dbo].[Supplier] (
    [Supplier_Code]      INT           NOT NULL,
    [Supplier_name]      NVARCHAR (20) NOT NULL,
    [Address_Line_1]     NVARCHAR (30) NOT NULL,
    [Address_Line_2]     NVARCHAR (30) NULL,
    [City]               NVARCHAR (20) NOT NULL,
    [Code]               NCHAR (4)     NOT NULL,
    [telephone_1]        NCHAR (13)    NOT NULL,
    [telephone_2]        NCHAR (13)    NULL,
    [Cellphone]          NCHAR (13)    NULL,
    [fax]                NCHAR (13)    NULL,
    [email]              NVARCHAR (40) NULL,
    [wholesale_supplier] BIT           NOT NULL,
    [VAT_number]         NVARCHAR (15) NOT NULL,
    [Representative]     NVARCHAR (50) NULL,
    [CK_number]          NVARCHAR (20) NULL,
    [Disable]            BIT           NULL,
    PRIMARY KEY CLUSTERED ([Supplier_Code] ASC),
    UNIQUE NONCLUSTERED ([Supplier_Code] ASC)
);

