USE [ClassBookingDB]
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C001', N'United States', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C002', N'Canada', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C003', N'United Kingdom', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C004', N'Australia', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C005', N'Germany', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C006', N'France', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C007', N'Japan', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C008', N'India', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C009', N'Brazil', 1)
GO
INSERT [dbo].[Country] ([countryID], [countryName], [active]) VALUES (N'C010', N'Mexico', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL001', N'Yoga Beginner', CAST(N'2024-11-01T00:00:00.000' AS DateTime), CAST(3 AS Decimal(2, 0)), CAST(100.00 AS Decimal(18, 2)), 4, 15, N'C001', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL002', N'Advanced Pilates', CAST(N'2024-11-15T00:00:00.000' AS DateTime), CAST(4 AS Decimal(2, 0)), CAST(150.00 AS Decimal(18, 2)), 4, 10, N'C002', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL003', N'Photography Workshop', CAST(N'2024-12-05T00:00:00.000' AS DateTime), CAST(2 AS Decimal(2, 0)), CAST(200.00 AS Decimal(18, 2)), 4, 20, N'C003', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL004', N'Cooking Masterclass', CAST(N'2024-11-20T00:00:00.000' AS DateTime), CAST(3 AS Decimal(2, 0)), CAST(250.00 AS Decimal(18, 2)), 4, 12, N'C004', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL005', N'Business Strategy 101', CAST(N'2024-12-01T00:00:00.000' AS DateTime), CAST(5 AS Decimal(2, 0)), CAST(500.00 AS Decimal(18, 2)), 4, 8, N'C005', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL006', N'French for Beginners', CAST(N'2024-11-10T00:00:00.000' AS DateTime), CAST(2 AS Decimal(2, 0)), CAST(120.00 AS Decimal(18, 2)), 4, 18, N'C006', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL007', N'Japanese Culture and Language', CAST(N'2024-12-10T00:00:00.000' AS DateTime), CAST(3 AS Decimal(2, 0)), CAST(180.00 AS Decimal(18, 2)), 4, 16, N'C007', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL008', N'Indian Cooking Special', CAST(N'2024-11-25T00:00:00.000' AS DateTime), CAST(2 AS Decimal(2, 0)), CAST(90.00 AS Decimal(18, 2)), 4, 20, N'C008', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL009', N'Brazilian Dance Class', CAST(N'2024-11-12T00:00:00.000' AS DateTime), CAST(2 AS Decimal(2, 0)), CAST(85.00 AS Decimal(18, 2)), 4, 15, N'C009', 1)
GO
INSERT [dbo].[sysClass] ([classID], [className], [classStartDate], [classCredit], [classPrice], [availableRefundHour], [availableSlot], [countryID], [active]) VALUES (N'CL010', N'Mexican Street Food', CAST(N'2024-12-15T00:00:00.000' AS DateTime), CAST(3 AS Decimal(2, 0)), CAST(130.00 AS Decimal(18, 2)), 4, 10, N'C010', 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U001', N'John Doe', N'JD001', N'pass1234', CAST(103.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U002', N'Jane Smith', N'JS002', N'pass5678', CAST(200.50 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U003', N'Mike Johnson', N'MJ003', N'mikepass', CAST(43.75 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U004', N'Emily Davis', N'ED004', N'emilypass', CAST(153.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U005', N'David Wilson', N'DW005', N'david123', CAST(300.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U006', N'Sophia Brown', N'SB006', N'sophia678', CAST(80.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U007', N'Chris Martin', N'CM007', N'chrispass', CAST(250.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U008', N'Emma White', N'EW008', N'emma1234', CAST(175.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U009', N'Liam Walker', N'LW009', N'liampass', CAST(90.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[sysUser] ([userID], [userName], [userCode], [password], [userCredit], [active]) VALUES (N'U010', N'Olivia Harris', N'OH010', N'olivia567', CAST(220.50 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'8C8286AF-FD20-4CAA-8F19-5731AEA8A278', N'CL001', N'U003', CAST(3.00 AS Decimal(18, 2)), N'Booked', CAST(N'2024-10-25T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'A7B0D72E-BE24-4614-9479-6A1F284E54B3', N'CL002', N'U003', CAST(4.00 AS Decimal(18, 2)), N'Booked', CAST(N'2024-10-25T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B001', N'CL001', N'U001', CAST(100.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2024-10-01T00:00:00.000' AS DateTime), CAST(N'2024-10-25T11:21:30.900' AS DateTime), 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B002', N'CL002', N'U002', CAST(150.00 AS Decimal(18, 2)), N'booked', CAST(N'2024-10-05T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B003', N'CL003', N'U003', CAST(200.00 AS Decimal(18, 2)), N'booked', CAST(N'2024-10-10T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B004', N'CL004', N'U004', CAST(250.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2024-10-15T00:00:00.000' AS DateTime), CAST(N'2024-10-25T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B005', N'CL005', N'U005', CAST(500.00 AS Decimal(18, 2)), N'booked', CAST(N'2024-10-20T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B006', N'CL006', N'U006', CAST(120.00 AS Decimal(18, 2)), N'booked', CAST(N'2024-10-25T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B007', N'CL007', N'U007', CAST(180.00 AS Decimal(18, 2)), N'booked', CAST(N'2024-10-30T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B008', N'CL008', N'U008', CAST(90.00 AS Decimal(18, 2)), N'booked', CAST(N'2024-10-25T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B009', N'CL009', N'U009', CAST(85.00 AS Decimal(18, 2)), N'booked', CAST(N'2024-10-28T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Booking] ([bookingID], [classID], [userID], [bookingCredit], [bookingStatus], [bookingSubmitDate], [bookingCancelDate], [active]) VALUES (N'B010', N'CL010', N'U010', CAST(130.00 AS Decimal(18, 2)), N'booked', CAST(N'2024-10-30T00:00:00.000' AS DateTime), NULL, 1)
GO
