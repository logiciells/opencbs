/****** Object:  Table [dbo].[SqlAccounts]    Script Date: 02/04/2010 13:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SqlAccounts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SqlAccounts](
	[account_name] [nvarchar](50) NOT NULL,
	[database_name] [nvarchar](50) NOT NULL,
	[user_name] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_SqlAccounts_1] PRIMARY KEY CLUSTERED 
(
	[account_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
