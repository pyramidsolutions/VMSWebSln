CREATE TABLE [dbo].[Transactions] (
    [Transaction_Code] INT           NOT NULL,
    [Stock_Code]       INT           NOT NULL,
    [account_ID]       INT           NOT NULL,
    [transaction_type] NVARCHAR (30) NOT NULL,
    [transaction_date] DATE          NOT NULL,
    [price]            MONEY         NOT NULL,
    [Vat_Amount]       MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([Transaction_Code] ASC),
    FOREIGN KEY ([account_ID]) REFERENCES [dbo].[User_Account] ([account_ID]),
    FOREIGN KEY ([Stock_Code]) REFERENCES [dbo].[Vehicle] ([Stock_Code]),
    UNIQUE NONCLUSTERED ([Transaction_Code] ASC)
);

