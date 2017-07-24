CREATE PROCEDURE dbo.GetTinyUrlsForUser @userID NVARCHAR(128)
AS
	(SELECT tu.TinyUrlString, tu.UrlString, j.AspNetUsersID FROM TinyUrls tu
	JOIN TinyUrlAspNetUserJoinTable j
	ON j.TinyUrlString = tu.TinyUrlString
	WHERE j.AspNetUsersID = @userID)

UNION

	(SELECT * FROM TinyUrls
	WHERE AspNetUsersID = @userID)

GO
