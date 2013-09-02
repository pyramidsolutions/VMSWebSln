CREATE TABLE [dbo].[Location] (
    [Location_ID]          INT           NOT NULL,
    [Location_Description] NVARCHAR (25) NOT NULL,
    [Disable]              BIT           NULL,
    PRIMARY KEY CLUSTERED ([Location_ID] ASC),
    UNIQUE NONCLUSTERED ([Location_ID] ASC)
);

