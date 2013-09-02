CREATE TABLE [dbo].[User_Account] (
    [account_ID]       INT           NOT NULL,
    [account_name]     NVARCHAR (20) NOT NULL,
    [account_password] NVARCHAR (20) NOT NULL,
    [first_name]       NVARCHAR (15) NOT NULL,
    [surname]          NVARCHAR (20) NOT NULL,
    [account_type]     NVARCHAR (10) NOT NULL,
    [Disable]          INT           NULL,
    PRIMARY KEY CLUSTERED ([account_ID] ASC),
    UNIQUE NONCLUSTERED ([account_ID] ASC)
);

