INSERT INTO Parents (Name) VALUES ('A parent created in a migration')
DECLARE @parentID INT;

SET @parentID = (SELECT SCOPE_IDENTITY());

INSERT INTO Children (Name, ParentID) VALUES ('First child created in a migration', @parentID);
INSERT INTO Children (Name, ParentID) VALUES ('Second child created in a migration', @parentID);
INSERT INTO Children (Name, ParentID) VALUES ('Third child created in a migration', @parentID);
