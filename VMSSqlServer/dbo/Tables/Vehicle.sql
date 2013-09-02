﻿CREATE TABLE [dbo].[Vehicle] (
    [Stock_Code]              INT           NOT NULL,
    [Manufacturer_ID]         INT           NOT NULL,
    [Model_ID]                INT           NOT NULL,
    [Location_ID]             INT           NOT NULL,
    [Supplier_Code]           INT           NOT NULL,
    [Transaction_Code]        INT           NULL,
    [Improvement_ID]          INT           NULL,
    [Cost_Price]              MONEY         NOT NULL,
    [Retail_Price]            MONEY         NOT NULL,
    [Wholesale_Price]         MONEY         NOT NULL,
    [Updated_Cost_Price]      MONEY         NOT NULL,
    [Colour]                  NVARCHAR (20) NOT NULL,
    [Picture_1]               IMAGE         NULL,
    [Picture_2]               IMAGE         NULL,
    [Picture_3]               IMAGE         NULL,
    [Chassis_Number]          NVARCHAR (30) NOT NULL,
    [Engine_Number]           NVARCHAR (30) NOT NULL,
    [Registration_Number]     NVARCHAR (10) NULL,
    [Vehicle_Register_Number] NVARCHAR (10) NULL,
    [Stock_Book_Number]       NVARCHAR (8)  NULL,
    [Extra_Features]          NVARCHAR (50) NULL,
    [Mileage]                 NVARCHAR (7)  NOT NULL,
    [Automatic_Transmission]  BIT           NOT NULL,
    [COR]                     BIT           NULL,
    [AC]                      BIT           NULL,
    [Cl]                      BIT           NULL,
    [PS]                      BIT           NULL,
    [AL]                      BIT           NULL,
    [Leather]                 BIT           NULL,
    [RT]                      BIT           NULL,
    [CD]                      BIT           NULL,
    [MP3]                     BIT           NULL,
    [FSH]                     BIT           NULL,
    [SR]                      BIT           NULL,
    [Sports_Kit]              BIT           NULL,
    [Airbag]                  BIT           NULL,
    [Mags]                    BIT           NULL,
    [Gearlock]                BIT           NULL,
    [Condition]               NVARCHAR (10) NULL,
    [Arrival_Date]            DATE          NULL,
    [Vehicle_Status]          NVARCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([Stock_Code] ASC),
    FOREIGN KEY ([Location_ID]) REFERENCES [dbo].[Location] ([Location_ID]),
    FOREIGN KEY ([Model_ID]) REFERENCES [dbo].[Model] ([Model_ID]),
    FOREIGN KEY ([Supplier_Code]) REFERENCES [dbo].[Supplier] ([Supplier_Code]),
    UNIQUE NONCLUSTERED ([Stock_Code] ASC)
);

