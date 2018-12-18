FROM microsoft/mssql-server-linux:2017-latest
ADD . /migrations
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Password! -i /migrations/01_create_db.sql 
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Password! -d test -i /migrations/02_create_tables.sql 
