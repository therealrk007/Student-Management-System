USE [DBStudentManage]
GO

/****** Object:  Table [dbo].[TBLStudent]    Script Date: 06/02/2024 5:55:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TBLStudent](
	[IdSt] [int] IDENTITY(1,1) NOT NULL,
	[NameSt] [nvarchar](255) NULL,
	[BirthDateSt] [date] NULL,
	[AddressSt] [nvarchar](1000) NULL,
	[CreateDateSt] [datetime] NULL,
	[IdCr] [int] NULL,
 CONSTRAINT [PK_TBLStudent] PRIMARY KEY CLUSTERED 
(
	[IdSt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TBLStudent]  WITH CHECK ADD  CONSTRAINT [FK_TBLStudent_TBLClassRoom] FOREIGN KEY([IdCr])
REFERENCES [dbo].[TBLClassRoom] ([IdCr])
GO

ALTER TABLE [dbo].[TBLStudent] CHECK CONSTRAINT [FK_TBLStudent_TBLClassRoom]
GO


