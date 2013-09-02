CREATE TABLE [dbo].[Company_Info] (
    [Company_ID]     INT            NOT NULL,
    [Company_name]   NVARCHAR (20)  NOT NULL,
    [Address_Line_1] NVARCHAR (30)  NOT NULL,
    [Address_Line_2] NVARCHAR (30)  NULL,
    [City]           NVARCHAR (20)  NOT NULL,
    [Code]           NCHAR (4)      NOT NULL,
    [telephone_1]    NCHAR (13)     NOT NULL,
    [telephone_2]    NCHAR (13)     NULL,
    [fax]            NCHAR (13)     NULL,
    [email]          NVARCHAR (40)  NULL,
    [website]        NVARCHAR (30)  NULL,
    [VAT_number]     NVARCHAR (15)  NOT NULL,
    [VAT_percentage] DECIMAL (3, 2) NOT NULL,
    [ForceMonthend]  BIT            NOT NULL,
    [Invoice_Footer] NVARCHAR (100) NULL,
    [Company_logo]   IMAGE          NULL,
    [Disable]        BIT            NULL,
    PRIMARY KEY CLUSTERED ([Company_ID] ASC),
    UNIQUE NONCLUSTERED ([Company_ID] ASC)
);

