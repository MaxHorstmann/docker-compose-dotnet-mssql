create table Customers
(
  id int not null identity(1,1) constraint pk_customers primary key,
  name nvarchar(100) not null
)