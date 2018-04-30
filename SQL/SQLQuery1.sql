-- create database
create database QCDB;

use QCDB;
go

-- create tables
create table products (
[id] int not null constraint PK_PRODUCTS_ID primary key identity(1,1),
[name] nvarchar(20) not null,
[price] float not null,
);

create table customers (
[id] int not null constraint PK_CUSTOMER_ID primary key identity(1,1),
[firstname] nvarchar(20) not null,
[lastname] nvarchar(20) not null,
[cardnumber] int not null
);

create table [order] (
[id] int not null constraint PK_ORDER_ID primary key identity(1,1),
[product_id] int not null constraint FK_PRODUCT_ID foreign key (product_id) references products(id),
[customer_id] int not null constraint FK_CUSTOMER_ID foreign key (customer_id) references customers(id)
);

-- insert three records products 
insert into dbo.products
values ('Product 1', 12.00);

insert into dbo.products
values ('Product 2', 20.15);

insert into dbo.products
values ('Product 3', 99.99);

-- insert three records customers
insert into dbo.customers
VALUES ('Mark','Abby', 123456789);

insert into dbo.customers
values ('Dane','Qual', 456789123);

insert into dbo.customers
values ('Ashly','Carter', 789123456);

--insert order
insert into dbo.[order]
values (1,2);

insert into dbo.[order]
values (2,3);

insert into dbo.[order]
values (3,1);

--add iphone
insert into dbo.products
values('iphone',200);

--add tina
insert into dbo.customers
values('Tina','Smith',123456789);

--Tina buys an iphone
insert into dbo.[order]
values(4,4);

--report tinas order
select * from 

--report revenue from iphone sales
-- get number of orders with id = 4
-- multiply that number with results from (select price from dbo.products where name == 'iphone')
select count(*) from [order] where id = 4;
select * from [order]

--increase iphone price
