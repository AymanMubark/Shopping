-- -------------------------------------------------------------
-- TablePlus 5.0.0(454)
--
-- https://tableplus.com/
--
-- Database: ShoppingDB
-- Generation Time: 2022-10-12 16:16:34.4340
-- -------------------------------------------------------------


INSERT INTO [dbo].[Categories] ([Id], [Name], [ParentId], [CreatedDate]) VALUES
('778BFDA0-91FE-40E5-4A09-08DAA64A7B90', N'Clothes', NULL, '0001-01-01 00:00:00.0000000'),
('778BFDA0-91FE-40E5-4A09-08DAA64A7B91', N'Electronic', NULL, '0001-01-01 00:00:00.0000000'),
('778BFDA0-91FE-40E5-4A09-08DAA64A7B92', N'Man', '778BFDA0-91FE-40E5-4A09-08DAA64A7B90', '0001-01-01 00:00:00.0000000'),
('778BFDA0-91FE-40E5-4A09-08DAA64A7B93', N'Woemn', '778BFDA0-91FE-40E5-4A09-08DAA64A7B90', '0001-01-01 00:00:00.0000000');

INSERT INTO [dbo].[ChoiceCategories] ([Id], [Name], [CreatedDate]) VALUES
('522C80D7-7216-45CE-1DF1-08DAA6493EDB', N'Color', '0001-01-01 00:00:00.0000000'),
('F5633167-82FC-4887-1DF2-08DAA6493EDB', N'Size', '0001-01-01 00:00:00.0000000');

INSERT INTO [dbo].[Choices] ([Id], [Name], [ChoiceCategoryId], [CreatedDate]) VALUES
('B6F261E9-54F9-415D-0CCB-08DAA6493EE5', N'#17a2b8', '522C80D7-7216-45CE-1DF1-08DAA6493EDB', '0001-01-01 00:00:00.0000000'),
('E71CFFCB-511E-4B5F-0CCC-08DAA6493EE5', N'#1d2124', '522C80D7-7216-45CE-1DF1-08DAA6493EDB', '0001-01-01 00:00:00.0000000'),
('B084D659-9E3A-4167-0CCD-08DAA6493EE5', N'#dc3545', '522C80D7-7216-45CE-1DF1-08DAA6493EDB', '0001-01-01 00:00:00.0000000'),
('55321943-9F5A-4528-0CCE-08DAA6493EE5', N'S', 'F5633167-82FC-4887-1DF2-08DAA6493EDB', '0001-01-01 00:00:00.0000000'),
('4F6619E6-9B7D-481C-0CCF-08DAA6493EE5', N'L', 'F5633167-82FC-4887-1DF2-08DAA6493EDB', '0001-01-01 00:00:00.0000000'),
('9826D213-A2EC-4BA9-0CD0-08DAA6493EE5', N'XL', 'F5633167-82FC-4887-1DF2-08DAA6493EDB', '0001-01-01 00:00:00.0000000'),
('A6C0EB1D-B22C-427E-0CD1-08DAA6493EE5', N'XXL', 'F5633167-82FC-4887-1DF2-08DAA6493EDB', '0001-01-01 00:00:00.0000000');

INSERT INTO [dbo].[ProductChoices] ([Id], [ProductId], [PriceIncrease], [ChoiceId], [CreatedDate]) VALUES
('AEC4244F-B027-4738-D7A5-08DAA64A7B83', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0', 'B6F261E9-54F9-415D-0CCB-08DAA6493EE5', '0001-01-01 00:00:00.0000000'),
('D6882CCC-B5D9-4F48-D7A6-08DAA64A7B83', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0', 'E71CFFCB-511E-4B5F-0CCC-08DAA6493EE5', '0001-01-01 00:00:00.0000000'),
('0C6BF85D-EF8A-4A3C-D7A7-08DAA64A7B83', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0', 'B084D659-9E3A-4167-0CCD-08DAA6493EE5', '0001-01-01 00:00:00.0000000'),
('1884DAC8-53B4-4D40-D7A8-08DAA64A7B83', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0', '55321943-9F5A-4528-0CCE-08DAA6493EE5', '0001-01-01 00:00:00.0000000'),
('2AAD1825-307B-4F87-D7A9-08DAA64A7B83', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0', '4F6619E6-9B7D-481C-0CCF-08DAA6493EE5', '0001-01-01 00:00:00.0000000'),
('B5D6BF7F-BB5E-499F-D7AA-08DAA64A7B83', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0', '9826D213-A2EC-4BA9-0CD0-08DAA6493EE5', '0001-01-01 00:00:00.0000000'),
('D6882CCC-B5D9-4F48-D7A6-08DAA64A7B93', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0', 'E71CFFCB-511E-4B5F-0CCC-08DAA6493EE5', '0001-01-01 00:00:00.0000000'),
('1884DAC8-53B4-4D40-D7A8-08DAA64A7B93', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0', '55321943-9F5A-4528-0CCE-08DAA6493EE5', '0001-01-01 00:00:00.0000000'),
('2AAD1825-307B-4F87-D7A9-08DAA64A7B93', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0', '4F6619E6-9B7D-481C-0CCF-08DAA6493EE5', '0001-01-01 00:00:00.0000000');

INSERT INTO [dbo].[ProductImage] ([Id], [ImageId], [ImageUrl], [ProductId], [CreatedDate]) VALUES
('1EE3A6B3-CC7E-43EA-7AD8-08DAA64A7B86', NULL, N'https://res.cloudinary.com/nittaq-for-information-technology/image/upload/v1664913561/product-2_acatdu.jpg', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0001-01-01 00:00:00.0000000'),
('1EE3A6B3-CC7E-43EA-7AD8-08DAA64A7B87', NULL, N'https://res.cloudinary.com/nittaq-for-information-technology/image/upload/v1664913564/111_t3tfpv.jpg', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0001-01-01 00:00:00.0000000'),
('F83F2EB4-58AE-4C32-7AD7-08DAA64A7B96', NULL, N'https://res.cloudinary.com/nittaq-for-information-technology/image/upload/v1664913561/product-3_hy3y2g.jpg', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0001-01-01 00:00:00.0000000'),
('1EE3A6B3-CC7E-43EA-7AD8-08DAA64A7B96', NULL, N'https://res.cloudinary.com/nittaq-for-information-technology/image/upload/v1664913561/product-2_acatdu.jpg', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0001-01-01 00:00:00.0000000');

INSERT INTO [dbo].[ProductInformation] ([Id], [Name], [Description], [ProductId], [CreatedDate]) VALUES
('27696B0F-FF5B-46E3-A31B-08DAA64A7B71', N'Weight', N'400 g', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B72', N'Dimensions', N'10 x 10 x 15 cm', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B73', N'Materials', N'60% cotton, 40% polyester', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B77', N'Color', N'Blue, Gray, Green, Red, Yellow', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B78', N'Size', N'L, M, S, XL, XXL', '27696B0F-FF5B-46E3-A31B-08DAA64A7B83', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B83', N'Weight', N'400 g', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B85', N'Dimensions', N'10 x 10 x 15 cm', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B86', N'Materials', N'60% cotton, 40% polyester', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B87', N'Color', N'Blue, Gray, Green, Red, Yellow', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0001-01-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B88', N'Size', N'L, M, S, XL, XXL', '27696B0F-FF5B-46E3-A31B-08DAA64A7B84', '0001-01-01 00:00:00.0000000');

INSERT INTO [dbo].[Products] ([Id], [Name], [Description], [FullDescription], [SKU], [Price], [OldPrice], [CategoryId], [CreatedDate]) VALUES
('27696B0F-FF5B-46E3-A31B-08DAA64A7B83', N'Stylish dress', N'Takse', N'<p _ngcontent-swb-c58="">Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.</p>
<h4 _ngcontent-swb-c58="">Product Features</h4>
<ul _ngcontent-swb-c58=""><li _ngcontent-swb-c58="">Mapped with 3M™ Thinsulate™ Insulation [40G Body / Sleeves / Hood]</li><li _ngcontent-swb-c58="">Embossed Taffeta Lining</li><li _ngcontent-swb-c58="">DRYRIDE Durashell™ 2-Layer Oxford Fabric [10,000MM, 5,000G]</li></ul>', N'AB1563456789', '200', '119.90000000000001', '778BFDA0-91FE-40E5-4A09-08DAA64A7B93', '2021-10-01 00:00:00.0000000'),
('27696B0F-FF5B-46E3-A31B-08DAA64A7B84', N'Sleeve dress', N'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Laborum ipsum dicta quod, quia doloremque aut deserunt commodi quis. Totam a consequatur beatae nostrum, earum consequuntur? Eveniet consequatur ipsum dicta recusandae.', N'<p _ngcontent-swb-c58="">Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.</p>
<h4 _ngcontent-swb-c58="">Product Features</h4>
<ul _ngcontent-swb-c58=""><li _ngcontent-swb-c58="">Mapped with 3M™ Thinsulate™ Insulation [40G Body / Sleeves / Hood]</li><li _ngcontent-swb-c58="">Embossed Taffeta Lining</li><li _ngcontent-swb-c58="">DRYRIDE Durashell™ 2-Layer Oxford Fabric [10,000MM, 5,000G]</li></ul>', N'AB1563456789', '300', '119.90000000000001', '778BFDA0-91FE-40E5-4A09-08DAA64A7B92', '2022-01-01 00:00:00.0000000');

