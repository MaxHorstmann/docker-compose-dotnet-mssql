using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;


namespace test
{
    public static class Config
    {
        public const string ConnectionStringMasterDb = "Data Source=sql;Initial Catalog=master;User Id=sa;Password=Password!";
        public const string ConnectionString = "Data Source=sql;Initial Catalog=test;User Id=sa;Password=Password!";

        public static void SetupSqlDb() // TODO use proper sql migration tool
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionStringMasterDb))   
            {
                connection.Execute(@"
                    if not exists(select 1 from sys.databases where name='test')
                    create database test
                    ");
            }

            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))   
            {
                connection.Execute(@"
                    create table Customers
                    (
                      id int not null identity(1,1) constraint pk_customers primary key,
                      name nvarchar(100) not null
                    )

                    insert into customers (name) values ('John')
                    insert into customers (name) values ('Ella')
                    insert into customers (name) values ('Peter')
                    ");
            }
        }


    }
}