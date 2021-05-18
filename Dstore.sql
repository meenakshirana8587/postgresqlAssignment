--create table roles
CREATE TABLE Role
(
	role_id SERIAL PRIMARY KEY,
	roles VARCHAR(30) NOT NULL
);

--insert data into roles table
INSERT INTO Role(roles)
VALUES('Cashier'),
('Store manager'),
('Assistant store manager'),
('Inventory control specilist'),
('Sales associate'),
('Security Guard'),
('Sweepers');
	


--create table Staff
CREATE TABLE Staff(
	staff_id SERIAL PRIMARY KEY,
	first_name VARCHAR(30) NOT NULL,
	last_name VARCHAR(20),
	date_of_birth Date,
	gender CHAR(1),
	phone VARCHAR(10),
	city VARCHAR(20),
	roles_id int REFERENCES Role(role_id)
	
);


--insert data into staff table
INSERT INTO Staff(first_name, last_name, date_of_birth, gender, phone, city, roles_id)
VALUES('Saumya','Malhotra', '1995-12-25', 'F', '1234567890', 'Delhi', '2');

INSERT INTO Staff(first_name, last_name, date_of_birth, gender, phone, city, roles_id)
VALUES('Rohit','Mishra', '1993-03-19', 'F', '1234567890', 'Delhi', '3'),
('Harshit','Verma', '1997-02-19', 'M', '9087654321', 'Delhi', '1'),
('Yanshik','Raina', '1998-03-19', 'M', '8097654321', 'Delhi', '1'),
('Ravi','Rai', '1978-04-19', 'M', '5098764321', 'Delhi', '6'),
('Ajay','Pal', '1997-08-15', 'M', '7098654321', 'Delhi', '4'),
('Aarushi','Rawat', '1997-12-19', 'F', '6098754321', 'Delhi', '4'),
('Anshita','Garg', '1995-05-17', 'F', '4098765321', 'Delhi', '5'),
('Anjali','Rai', '1994-07-21', 'F', '3098765421', 'Delhi', '5'),
('Rahul','Singh', '1990-05-19', 'M', '2098765431', 'Delhi', '7');






--create table supplier
CREATE TABLE Supplier
(
	supplier_id SERIAL PRIMARY KEY,
	supplier_name VARCHAR(30) NOT NULL,
	supplier_city VARCHAR(20),
	supplier_phone VARCHAR(10) UNIQUE NOT NULL,
	supplier_email VARCHAR(50)
	
	
);



--insert data into supplier
INSERT INTO Supplier(supplier_name, supplier_city, supplier_phone, supplier_email)
VALUES('Anusha Yadav', 'Chennai', '1029384756', 'anu@mail.com'),
('Michael Morris', 'US', '9012345678', 'mm@mail.com'),
('John Doe', 'Africa', '8012345679', 'jd@mail.com'),
('Rahul Nayak', 'Delhi', '6012345789', 'rn@mail.com'),
('Satyam Joshi', 'Rajasthan', '5012346789', 'sj@mail.com');





--create table products
CREATE TABLE Product(
	product_id SERIAL PRIMARY KEY,
	product_name VARCHAR(40) NOT NULL,
	product_brand VARCHAR(30),
	product_short_code VARCHAR(4) NOT NULL UNIQUE,
	product_manufacturer VARCHAR(40),
	product_cost_price NUMERIC(6,2),
	product_selling_price NUMERIC(6,2),
	date_of_supply date,
	supplier_id INT REFERENCES Supplier(supplier_id)
	
);

--insert into products table
INSERT INTO Product(product_name,product_brand,product_short_code,product_manufacturer,product_cost_price,product_selling_price,date_of_supply,supplier_id)
VALUES('Milk','Amul','amlk','Amul',40.23,45.00,'2020-12-13',1);
INSERT INTO Product(product_name,product_brand,product_short_code,product_manufacturer,product_cost_price,product_selling_price,date_of_supply,supplier_id)
VALUES('Chocolate','Dairy MILk','dmch','DairyMilk',200.23,250.00,'2020-11-15',2),
('Butter','Mother Dairy','mdbt','Mother Dairy',25.00,30.00,'2021-03-13',3),

('Strawberries','fresh farm','ffst','fresh farms',40.23,45.00,'2021-04-13',4),
('Facial Cream','Lakme','lkfc','Lakme',50.23,52.00,'2020-05-13',5),
('Apples','fresh farm','ffap','fresh farms',800.23,805.00,'2021-01-13',1),
('chocholate','Amul','amch','Amul',100.23,103.00,'2020-10-13',2),
('Lipstick','Stay beautiful','sblp','stay beautiful',200.23,196.00,'2020-09-13',3),
('jeans','calvin klien','ckjn','ck',108.23,100.00,'2021-02-13',4),
('shirt','pantaloons','plsh','pantaloons',75.23,80.00,'2020-12-13',5);


--create table category
Create Table Category
(
	category_id SERIAL PRIMARY KEY,
	category_name VARCHAR(50) NOT NULL
);


--insert data into categories
INSERT INTO Category(category_name)
Values('perishable products'),
('Dairy Products'),
('sweets'),
('fruits'),
('cosmetics'),
('skin care'),
('clothing'),
('fasion');

--create junction table products_categories
CREATE TABLE ProductCategory
(
	product_id int REFERENCES Product(product_id),
	category_id int REFERENCES Category(category_id)
);


--insert data into products_categories table
INSERT INTO ProductCategory(product_id, category_id)
Values(1,1),
(1,2),
(2,3),
(2,2),
(3,1),
(3,2),
(4,1),
(4,4),
(5,5),
(5,6),
(6,1),
(6,4),
(7,3),
(7,2),
(8,5),
(8,6),
(9,7),
(9,8),
(10,7),
(10,8);


--create inventory table
CREATE TABLE Inventory
(
	inventory_id SERIAL PRIMARY KEY,
	product_id int REFERENCES Product(product_id),
	quantity INT
);

--insert data into inventory table
INSERT INTO Inventory(product_id,quantity)
Values(1,20),
(2,10),
(3,30),
(4,50),
(5,260),
(6,0),
(7,70),
(8,80),
(9,200),
(10,0);





 
CREATE TABLE Orders
(
	order_id SERIAL PRIMARY KEY,
	
	order_item_quantity int,
	order_date date,
	product_id int REFERENCES Product(product_id)
	
);

--insert data into orders table
INSERT INTO Orders(order_item_quantity,order_date,product_id)
VALUES(30,'2020-12-20',1),
(30,'2020-11-20',2),
(30,'2020-10-20',3),
(30,'2020-09-20',4),
(30,'2020-08-20',5),
(30,'2021-01-20',1),
(30,'2021-02-20',2),
(30,'2021-03-20',3),
(30,'2021-04-20',4),
(30,'2021-05-20',5);

--1)Query Staff using name or phone number or both
SELECT * FROM Staff WHERE first_name='Ajay';
SELECT * FROM Staff WHERE phone='9087654321';

--2)Query Staff using their Role
SELECT s.first_name, s.last_name, r.roles FROM Staff s
JOIN Role r
ON s.roles_id= r.role_id
ORDER BY r.roles;

--3)Query Product based on -
--a)Name
SELECT * FROM Product WHERE product_name LIKE 'c%';

--b)Category
SELECT pr.product_name, pr.product_selling_price, cat.category_name FROM Product pr
JOIN ProductCategory pcat
ON pcat.product_id= pr.product_id
JOIN Category cat
ON cat.category_id= pcat.category_id
WHERE cat.category_name LIKE 'D%'
ORDER BY pr.product_selling_price;

--c)InStock, OUTofstock
SELECT pr.product_name, pr.product_manufacturer, inv.inventory_id FROM Product pr
JOIN Inventory inv 
ON inv.product_id= pr.product_id
WHERE inv.quantity=0;

SELECT pr.product_name, pr.product_manufacturer, inv.inventory_id, inv.quantity FROM Product pr
JOIN Inventory inv 
ON inv.product_id= pr.product_id
WHERE inv.quantity>0;

--d)SP less than, greater than or between
SELECT product_name, product_selling_price from Product 
WHERE product_selling_price<200
ORDER BY product_selling_price;

SELECT product_name, product_selling_price from Product 
WHERE product_selling_price>200
ORDER BY product_selling_price;

SELECT product_name, product_selling_price from Product 
WHERE product_selling_price BETWEEN 100 AND 500
ORDER BY product_selling_price;

--4)Number of Products out of stock
SELECT COUNT(*) AS total_products_outofstock FROM Product pr
JOIN Inventory inv
ON inv.product_id= pr.product_id
WHERE inv.quantity=0;

--5)Number of Products within a category
SELECT cat.category_name , COUNT(*) As number_of_products FROM Category cat
JOIN ProductCategory pcat
ON pcat.category_id= cat.category_id
GROUP BY cat.category_name;


--6)Product-Categories listed in descending with highest number of products to the 
--lowest number of products
SELECT cat.category_name , COUNT(*) As number_of_products FROM Category cat
JOIN ProductCategory pcat
ON pcat.category_id= cat.category_id
GROUP BY cat.category_name
ORDER by number_of_products DESC;

--7)List of Suppliers -
--a) Name
SELECT * FROM Supplier WHERE supplier_name LIKE'A%';

--b) phone
SELECT * FROM Supplier WHERE supplier_phone='1029384756';

--c) email

SELECT * FROM Supplier WHERE supplier_email LIKE 'j%';

--d) city/state
SELECT * FROM Supplier WHERE supplier_city='Rajasthan';

--8)List of Product with different suppliers, with the recent date of supply 
--and the amount supplied on the most recent occasion. Here this can also be filtered based on -
SELECT pr.product_name,s.supplier_name, o.order_item_quantity, o.order_date FROM Product pr
JOIN Supplier s
ON s.supplier_id= pr.supplier_id
JOIN Orders o
ON o.product_id= pr.product_id
ORDER BY o.order_date DESC LIMIT 5;--showing 5 most recent orders.

--a)Product Name
SELECT pr.product_name,s.supplier_name, o.order_item_quantity, o.order_date FROM Product pr
JOIN Supplier s
ON s.supplier_id= pr.supplier_id
JOIN Orders o
ON o.product_id= pr.product_id
WHERE pr.product_name LIKE 'M%'
ORDER BY o.order_date DESC ;

--b)supplier name
SELECT pr.product_name,s.supplier_name, o.order_item_quantity, o.order_date FROM Product pr
JOIN Supplier s
ON s.supplier_id= pr.supplier_id
JOIN Orders o
ON o.product_id= pr.product_id
WHERE s.supplier_name Like 'J%'
ORDER BY o.order_date DESC;

--c)product code
SELECT pr.product_name,s.supplier_name, o.order_item_quantity, o.order_date FROM Product pr
JOIN Supplier s
ON s.supplier_id= pr.supplier_id
JOIN Orders o
ON o.product_id= pr.product_id
WHERE pr.product_short_code LIKE 'a%'
ORDER BY o.order_date DESC;

--d)supplied after a particular date
SELECT pr.product_name,s.supplier_name, o.order_item_quantity, o.order_date FROM Product pr
JOIN Supplier s
ON s.supplier_id= pr.supplier_id
JOIN Orders o
ON o.product_id= pr.product_id
WHERE pr.date_of_supply>'2021-01-01'
ORDER BY o.order_date DESC;

--e)Product has inventory more than or less than a given qty
SELECT pr.product_name,s.supplier_name, o.order_item_quantity, o.order_date, inv.quantity FROM Product pr
JOIN Inventory inv
ON inv.product_id= pr.product_id
JOIN Supplier s
ON s.supplier_id= pr.supplier_id
JOIN Orders o
ON o.product_id= pr.product_id
WHERE inv.quantity>40
ORDER BY o.order_date DESC;
