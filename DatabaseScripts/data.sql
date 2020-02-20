SET IDENTITY_INSERT [dbo].[Bank] ON
INSERT INTO [dbo].[Bank] ([Id], [BankName], [FixedDepositPercentage]) VALUES (1, N'Bank of Auckland', 5)
INSERT INTO [dbo].[Bank] ([Id], [BankName], [FixedDepositPercentage]) VALUES (2, N'Bank of Wellington', 10)
SET IDENTITY_INSERT [dbo].[Bank] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Id], [CustomerName], [CustomerNumber], [BankId]) VALUES (1, N'John Wilkinson', N'021888723456', 1)
INSERT INTO [dbo].[Customer] ([Id], [CustomerName], [CustomerNumber], [BankId]) VALUES (2, N'David James', N'024445678', 2)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Account] ON
INSERT INTO [dbo].[Account] ([Id], [AccountNumber], [Balance], [CustomerId]) VALUES (1, N'99990000111', 5000, 1)
INSERT INTO [dbo].[Account] ([Id], [AccountNumber], [Balance], [CustomerId]) VALUES (2, N'88899999999', 4600, 2)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[CalculatedBalance] ON
INSERT INTO [dbo].[CalculatedBalance] ([Id], [AccountId], [NumberOfYears]) VALUES (1, 1, 10)
INSERT INTO [dbo].[CalculatedBalance] ([Id], [AccountId], [NumberOfYears]) VALUES (2, 2, 7)
SET IDENTITY_INSERT [dbo].[CalculatedBalance] OFF
