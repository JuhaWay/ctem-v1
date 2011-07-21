USE [CTEM-DB-v1]
GO

/****** Object:  Table [dbo].[RoadMap]    Script Date: 07/21/2011 08:39:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RoadMap](
	[RoadMapID] [bigint] IDENTITY(1,1) NOT NULL,
	[FromPlace] [nvarchar](50) NULL,
	[ToPlace] [nvarchar](50) NULL,
	[Reason] [nvarchar](50) NULL,
	[Kilomet] [float] NULL,
 CONSTRAINT [PK_RoadMap] PRIMARY KEY CLUSTERED 
(
	[RoadMapID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

