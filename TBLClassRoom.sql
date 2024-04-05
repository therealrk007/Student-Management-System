USE [DBStudentManage]
GO

/****** Object:  Table [dbo].[TBLClassRoom]    Script Date: 06/02/2024 5:55:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TBLClassRoom](
	[IdCr] [int] IDENTITY(1,1) NOT NULL,
	[NameCr] [nvarchar](255) NULL,
	[CreateDateCr] [datetime] NULL,
 CONSTRAINT [PK_TBLClassRoom] PRIMARY KEY CLUSTERED 
(
	[IdCr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

