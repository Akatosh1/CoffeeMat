DROP TABLE IF exists coffee_items_db
DROP TABLE IF exists purchase_db
DROP TABLE IF exists resources_db
DROP TABLE IF exists money_items_db

CREATE TABLE coffee_items_db(
id INT IDENTITY(1,1) NOT NULL,
coffee_name VARCHAR(50) NOT NULL,
price INT NOT NULL,
picture varbinary(Max) NOT NULL,
coffee INT NOT NULL,
water INT NOT NULL,
milk INT NOT NULL
);

CREATE TABLE purchase_items_db(
id int IDENTITY(1,1) NOT NULL,
purchase_name VARCHAR(50) NOT NULL,
price int NOT NULL
);

/* добавить уникальности ключам*/
CREATE TABLE resource_items_db(
id int IDENTITY(1,1) NOT NULL,
resource_name varchar(50) NOT NULL,
resource_amount int NOT NULL,
picture varbinary(Max) NOT NULL
);

/* добавить уникальности ключам*/
CREATE TABLE money_items_db(
id int IDENTITY(1,1) NOT NULL,
money_name varchar(50) NOT NULL,
money_amount int NOT NULL,
picture varbinary(Max) NOT NULL
);

Select * from money_items_db