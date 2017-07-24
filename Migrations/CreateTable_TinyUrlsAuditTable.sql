CREATE TABLE TinyUrlsAuditTable(
       TinyUrlString VARCHAR(30) NOT NULL,
       UtcCreatedDate DATETIME NOT NULL,
       UrlString VARCHAR(MAX) NOT NULL,
       AspNetUsersID NVARCHAR(128))
