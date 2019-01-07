CREATE TABLE [dbo].[myusers] (
    [FIR.NO]     VARCHAR (50)  NOT NULL,
    [COMP.NO]    VARCHAR (50)  NULL,
    [NAME]       VARCHAR (50)  NULL,
    [DATE]       DATE          NULL,
    [CRIME TYPE] NVARCHAR (50) NULL,
    [ADDRESS]    VARCHAR (50)  NULL,
    [PHOTO] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([FIR.NO] ASC)
);