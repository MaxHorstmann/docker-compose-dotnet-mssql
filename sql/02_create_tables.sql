if not exists (select 1 from sys.tables where name='Customers')
BEGIN
	create table Customers
	(
	  id int not null identity(1,1) constraint pk_customers primary key,
	  name nvarchar(100) not null
	)

	insert into customers (name) values ('John')
	insert into customers (name) values ('Ella')
	insert into customers (name) values ('Peter')
END