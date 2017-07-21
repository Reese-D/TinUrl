CREATE TABLE TinyUrls(
       TinyUrlString VARCHAR(30) NOT NULL PRIMARY KEY,
       UrlString VARCHAR(MAX) NOT NULL,
       AspNetUsersID NVARCHAR(128) NOT NULL,
       CONSTRAINT FK_TinyUrls_AspNetUsersID
       		  FOREIGN KEY (AspNetUsersID)
		  REFERENCES AspNetUsers(Id))

GO
