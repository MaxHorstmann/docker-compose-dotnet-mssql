IF NOT EXISTS(SELECT 1 FROM sys.databases WHERE name='test')
BEGIN
	CREATE DATABASE [test]
END

