CREATE TABLE TinyUrlAspNetUserJoinTable(
       TinyUrlString varchar(30) not null,
       AspNetUsersID NVARCHAR(128) NOT NULL,
       FOREIGN KEY (TinyUrlString)
       	       REFERENCES TinyUrls(TinyUrlString),
	FOREIGN KEY (AspNetUsersID)
	REFERENCES AspNetUsers(Id))

GO

ALTER TABLE TinyUrlAspNetUserJoinTable
ADD CONSTRAINT [PK_TinyUrlAspNetUserJoinTable_Clustered] PRIMARY KEY CLUSTERED(
    TinyUrlString ASC,
    AspNetUsersID ASC)

GO
