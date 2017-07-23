CREATE FUNCTION [dbo].[ascii_value]
(
	@string varchar(2000)
)
RETURNS varchar(2000)
AS
	BEGIN
		DECLARE @position int, @aux char(3), @myval varchar(2000)='1'

		SET @position = 1

		WHILE @position <= DATALENGTH(@string)
		BEGIN
			SET @aux = ASCII(SUBSTRING(@string, @position, 1))

			SET @myval = @myval+ replace(@aux,' ','0')

			SET @position = @position + 1
		END
		RETURN @myval
	END
GO

CREATE VIEW MostRecentTinyUrl
AS
	SELECT TOP 1
       	       dbo.ascii_value(TinyUrlString) AS AsciiValue,
       	       TinyUrlString
	FROM TinyUrls
	ORDER BY asciiValue DESC

GO
