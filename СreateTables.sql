USE [DeliveryDB]
GO
/****** Object:  Table [dbo].[AddIngredients]    Script Date: 24/12/2021 18:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddIngredients](
	[custom_dish_id] [int] NOT NULL,
	[ingredient_id] [int] NOT NULL
 CONSTRAINT [PK_AddIngredients] PRIMARY KEY CLUSTERED 
(
	[custom_dish_id] ASC,
	[ingredient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coupons]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coupons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](30) NOT NULL,
	[discount] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_Coupons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomDishes]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomDishes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dish_id] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_CustomDishes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dishes]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dishes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
	[price] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_Dishes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DishToCategory]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DishToCategory](
	[category_id] [int] NOT NULL,
	[dish_id] [int] NOT NULL,
 CONSTRAINT [PK_DishToCategory] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC,
	[dish_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Ingredients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IngredientToDish]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredientToDish](
	[dish_id] [int] NOT NULL,
	[ingredient_id] [int] NOT NULL,
 CONSTRAINT [PK_IngredientToDish] PRIMARY KEY CLUSTERED 
(
	[dish_id] ASC,
	[ingredient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[order_id] [int] NOT NULL,
	[dish_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC,
	[dish_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[courier_id] [int] NULL,
	[manager_id] [int] NOT NULL,
	[coupon_id] [int] NULL,
	[trans_id] [int] NULL,
	[ordered_at] [datetime] NOT NULL,
	[delivered_at] [datetime] NULL,
	[status_id] [int] NOT NULL,
	[comments] [nchar](300) NULL,
	[phone] [nchar](15) NOT NULL,
	[name] [nchar](50) NULL,
	[cook_id] [int] NULL,
	[address] [nchar](300) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RemoveIngredients]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RemoveIngredients](
	[custom_dish_id] [int] NOT NULL,
	[ingredient_id] [int] NOT NULL,
 CONSTRAINT [PK_RemoveIngredients] PRIMARY KEY CLUSTERED 
(
	[custom_dish_id] ASC,
	[ingredient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](25) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statuses]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Statuses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[amount] [decimal](19, 4) NOT NULL,
	[date] [datetime] NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24/12/2021 18:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
	[login] [nchar](50) NOT NULL,
	[password] [nchar](100) NOT NULL,
	[user_role_id] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AddIngredients]  WITH CHECK ADD  CONSTRAINT [FK_AddIngredients_CustomDishes] FOREIGN KEY([custom_dish_id])
REFERENCES [dbo].[CustomDishes] ([id])
GO
ALTER TABLE [dbo].[AddIngredients] CHECK CONSTRAINT [FK_AddIngredients_CustomDishes]
GO
ALTER TABLE [dbo].[AddIngredients]  WITH CHECK ADD  CONSTRAINT [FK_AddIngredients_Ingredients] FOREIGN KEY([ingredient_id])
REFERENCES [dbo].[Ingredients] ([id])
GO
ALTER TABLE [dbo].[AddIngredients] CHECK CONSTRAINT [FK_AddIngredients_Ingredients]
GO
ALTER TABLE [dbo].[CustomDishes]  WITH CHECK ADD  CONSTRAINT [FK_CustomDishes_Dishes] FOREIGN KEY([dish_id])
REFERENCES [dbo].[Dishes] ([id])
GO
ALTER TABLE [dbo].[CustomDishes] CHECK CONSTRAINT [FK_CustomDishes_Dishes]
GO
ALTER TABLE [dbo].[CustomDishes]  WITH CHECK ADD  CONSTRAINT [FK_CustomDishes_Orders] FOREIGN KEY([order_id])
REFERENCES [dbo].[Orders] ([id])
GO
ALTER TABLE [dbo].[CustomDishes] CHECK CONSTRAINT [FK_CustomDishes_Orders]
GO
ALTER TABLE [dbo].[DishToCategory]  WITH CHECK ADD  CONSTRAINT [FK_DishToCategory_Categories] FOREIGN KEY([category_id])
REFERENCES [dbo].[Categories] ([id])
GO
ALTER TABLE [dbo].[DishToCategory] CHECK CONSTRAINT [FK_DishToCategory_Categories]
GO
ALTER TABLE [dbo].[DishToCategory]  WITH CHECK ADD  CONSTRAINT [FK_DishToCategory_Dishes] FOREIGN KEY([dish_id])
REFERENCES [dbo].[Dishes] ([id])
GO
ALTER TABLE [dbo].[DishToCategory] CHECK CONSTRAINT [FK_DishToCategory_Dishes]
GO
ALTER TABLE [dbo].[IngredientToDish]  WITH CHECK ADD  CONSTRAINT [FK_IngredientToDish_Dishes] FOREIGN KEY([dish_id])
REFERENCES [dbo].[Dishes] ([id])
GO
ALTER TABLE [dbo].[IngredientToDish] CHECK CONSTRAINT [FK_IngredientToDish_Dishes]
GO
ALTER TABLE [dbo].[IngredientToDish]  WITH CHECK ADD  CONSTRAINT [FK_IngredientToDish_Ingredients] FOREIGN KEY([ingredient_id])
REFERENCES [dbo].[Ingredients] ([id])
GO
ALTER TABLE [dbo].[IngredientToDish] CHECK CONSTRAINT [FK_IngredientToDish_Ingredients]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Dishes] FOREIGN KEY([dish_id])
REFERENCES [dbo].[Dishes] ([id])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Dishes]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY([order_id])
REFERENCES [dbo].[Orders] ([id])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Coupons] FOREIGN KEY([coupon_id])
REFERENCES [dbo].[Coupons] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Coupons]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Statuses] FOREIGN KEY([status_id])
REFERENCES [dbo].[Statuses] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Statuses]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Transactions] FOREIGN KEY([trans_id])
REFERENCES [dbo].[Transactions] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Transactions]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([courier_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users1] FOREIGN KEY([manager_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users1]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users2] FOREIGN KEY([cook_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users2]
GO
ALTER TABLE [dbo].[RemoveIngredients]  WITH CHECK ADD  CONSTRAINT [FK_RemoveIngredients_CustomDishes] FOREIGN KEY([custom_dish_id])
REFERENCES [dbo].[CustomDishes] ([id])
GO
ALTER TABLE [dbo].[RemoveIngredients] CHECK CONSTRAINT [FK_RemoveIngredients_CustomDishes]
GO
ALTER TABLE [dbo].[RemoveIngredients]  WITH CHECK ADD  CONSTRAINT [FK_RemoveIngredients_Ingredients] FOREIGN KEY([ingredient_id])
REFERENCES [dbo].[Ingredients] ([id])
GO
ALTER TABLE [dbo].[RemoveIngredients] CHECK CONSTRAINT [FK_RemoveIngredients_Ingredients]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([user_role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
