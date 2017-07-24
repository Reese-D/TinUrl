CREATE TABLE TinyUrlsAuditTable(
       TinyUrlString VARCHAR(30) NOT NULL PRIMARY KEY,
       UtcCreatedDate DATETIME NOT NULL,
       UrlString VARCHAR(MAX) NOT NULL,
       AspNetUsersID NVARCHAR(128))
