INSERT INTO Statuses ([name])
VALUES
('Ordered'),
('In Preparation'),
('Prepared'),
('In Delivery'),
('Delivered');

INSERT INTO Roles ([name])
VALUES
('Manager'),
('Courier'),
('Cook');

INSERT INTO Users ([name], login, password, user_role_id)
VALUES
    ('Sofya Chaika', 'bestgirl', 'doroguPeDaGoGu', 1),
    ('Anton Denisov', 'eto_stephan', 'lublu_dotu_2', 2),
    ('Dobrynya Nikitich', 'zaskamilMam0nta', 'egipetskayasila', 2),
    ('Zmey Denysov', 'gorynych', 'uml_er', 3),
    ('David Dusseault', 'moriyama2_0', 'straydog200', 2),
    ('Daniel Kartoshkin', 'bff_Andrey', 'polshastrong', 1),
    ('Andrey Scherbenok', 'bff_Danila', 'tyuzismylove999', 1),
    ('Miron Fedorov', 'oxxxymiron', 'Shulmanl0ve', 3),
    ('Agatha Christie', 'ladyWestmacott', 'u_n_0wen', 3),
    ('Andrew Bumblebee', 'aristotleFan01', 'plat0srave123', 2),
    ('Zachary Reyna', 'depression4ever', 'siniy_winston200', 3),
    ('Vladimir Tikhonenko', 'David_MoyKumir', 'Kvartirnikn43', 3),
    ('Anastasia Rusakova', 'coolgirl99', 'BorisViansGrave', 2),
    ('Alexander Tankhilevich', 'pylkiy', 'wovn346fv2', 1),
    ('Saint Augustin', 'greatest_sinner', 'JesusHearMe', 2);

INSERT INTO Transactions ([amount], [date])
VALUES
(468, '20120618 10:34:09 AM'),
(580, '20211213 06:35:09 PM'),
(330, '20211213 02:35:09 PM'),
(250, '20211213 05:32:09 PM'),
(640, '20211213 06:17:09 PM'),
(630, '20211213 07:48:25 PM'),
(650, '20211203 11:18:23 AM'),
(450, '20210901 01:52:28 PM'),
(590, '20211213 02:43:25 PM'),
(220, '20211213 08:12:25 PM');

INSERT INTO Coupons ([name], [discount])
VALUES
    ('10off', '0.1'),
    ('15off', '0.15'),
    ('BirthdayDiscount', '0.2');

INSERT INTO Orders (courier_id, manager_id, coupon_id, trans_id, ordered_at, delivered_at, status_id, [comments], phone, [name], cook_id, [address])
VALUES
    (2, 1, 1, 1, '20120618 10:34:09 AM', '20120618 12:12:38 AM', 5, '', '89285619374', 'Maxim', 4, 'Lenina st, 25, 7'),
    (3, 6, NULL, 2, '20211213 06:35:09 PM', NULL, 3, '', '89452497622', 'Yaroslav', 8, 'Yamskaya st, 72, 44'),
    (5, 7, NULL, 3, '20211213 02:35:09 PM', NULL, 4, '', '89048398142', 'Alexey', 9,  'Respubliki st, 48, 3'),
    (10, 14, NULL, 4, '20211213 05:32:09 PM', NULL, 1, 'Do not put sesame seeds', '89702764518', 'Sofya', 11, 'Eletskaya st, 3, 3'),
    (13, 6, NULL, 5, '20211213 06:17:09 PM', NULL, 2, '', '89405728135', 'Andrey', 12, 'Yamskaya st, 110, 2'),
    (15, 6, NULL, 6, '20211213 07:48:25 PM', NULL, 3, '', '84510463882', 'Fedor', 4, 'Profsoyuznaya st, 76, 90'),
    (10, 7, NULL, 7, '20211203 11:18:23 AM', '20211203 01:03:26 PM', 3, '', '83049177243', 'Pavel', 8, 'Yeletskaya st, 67, 123'),
    (5, 1, NULL, 8, '20210901 01:52:28 PM', '20210901 02:51:3 PM', 5, '', '84091287621', 'Kirill', 9, 'Belinskogo st, 2, 156'),
    (5, 1, NULL, 9, '20211213 02:43:25 PM', NULL, 2, '', '89471809836', 'Anton', 11,  'Orlovskaya st, 89, 5'),
    (10, 6, NULL, 10, '20211213 08:12:25 PM', NULL, 1, 'Please put additional napkins', '89220746964', 'Stanislav', 12, 'Polevaya st, 37, 7');

INSERT INTO Ingredients ([name])
VALUES
    ('Plain waffle'),
    ('Chocolate waffle'),
    ('Potato waffle'),
    ('Cottage cheese'),
    ('Bell pepper'),
    ('Bacon'),
    ('Cherry tomatoes'),
    ('Olives'),
    ('Vinegar'),
    ('Sesame seeds'),
    ('Sun-dried tomatoes'),
    ('Pesto sauce '),
    ('Pumpkin seeds '),
    ('Basil'),
    ('Tartare sauce'),
    ('Red fish'),
    ('Chicken liver pate'),
    ('Cranberry sauce'),
    ('Parsley'),
    ('Pine nut'),
    ('Pear'),
    ('Ice-cream'),
    ('Salted caramel'),
    ('Whipped cream'),
    ('Walnut'),
    ('Caramel'),
    ('Peanut  paste'),
    ('Banana'),
    ('Hazelnut'),
    ('Chocolate'),
    ('Bread '),
    ('Salami'),
    ('Cucumber'),
    ('Salad '),
    ('Cheese'),
    ('Tuna'),
    ('Brownie'),
    ('Poppy');

INSERT INTO Categories ([name])
VALUES
    ('Savory waffles'),
    ('Sweet waffles'),
    ('Sandwiches'),
    ('Deserts');

INSERT INTO Dishes ([name], [price])
VALUES
    ('Greek waffle', 250),
    ('Italian waffle', 270),
    ('Red fish waffle', 320),
    ('French waffle', 250),
    ('Classic sweet waffle', 180),
    ('Pear waffle', 200),
    ('Peanut waffle', 220),
    ('Tuna sandwich', 150),
    ('Salami sandwich', 150),
    ('Brownie', 180);

INSERT INTO IngredientToDish (dish_id, ingredient_id)
VALUES
    (1, 1),
    (1, 4),
    (1, 5),
    (1, 8),
    (1, 7),
    (1, 9),
    (1, 10),
    (2, 1),
    (2, 11),
    (2, 12),
    (2, 7),
    (2, 4),
    (2, 13),
    (2, 14),
    (3, 1),
    (3, 15),
    (3, 16),
    (3, 7),
    (3, 10),
    (3, 14),
    (4, 1),
    (4, 17),
    (4, 18),
    (4, 19),
    (4, 20),
    (5, 1),
    (5, 22),
    (5, 23),
    (6, 1),
    (6, 21),
    (6, 24),
    (6, 25),
    (6, 38),
    (6, 26),
    (7, 2),
    (7, 27),
    (7, 28),
    (7, 23),
    (7, 29),
    (8, 36),
    (8, 31),
    (8, 34),
    (8, 33),
    (8, 4),
    (9, 31),
    (9, 32),
    (9, 33),
    (9, 34),
    (9, 35),
    (10, 37),
    (10, 22),
    (10, 26);

INSERT INTO DishToCategory (dish_id, category_id)
VALUES
    (1, 1),
    (2, 1),
    (3, 1),
    (4, 1),
    (5, 2),
    (6, 2),
    (7, 2),
    (8, 3),
    (9, 3),
    (10, 4);

INSERT INTO OrderItems (order_id, dish_id, quantity)
VALUES
(1, 2, 1),
(1, 4, 1),
(2, 6, 2),
(3, 8, 1),
(3, 10, 1),
(4, 1, 1),
(5, 3, 1),
(6, 5, 1),
(6, 2, 1),
(6, 10, 1),
(7, 9, 1),
(7, 1, 1),
(8, 4, 1),
(8, 6, 1),
(9, 2, 1),
(9, 3, 1),
(10, 7, 1);

INSERT INTO CustomDishes (dish_id, order_id, quantity)
VALUES
(3, 5, 1),
(5, 2, 1),
(1, 7, 1); 

INSERT INTO AddIngredients (custom_dish_id, ingredient_id)
VALUES
(2, 10),
(2, 24),
(3, 12)

INSERT INTO RemoveIngredients (custom_dish_id, ingredient_id)
VALUES
(1, 14),
(3, 5)




