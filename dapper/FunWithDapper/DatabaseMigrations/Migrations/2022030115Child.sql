create table Children
(
    ID       int identity
        constraint PK_Children
            primary key,
    Name     nvarchar(max) not null,
    ParentID int           not null
        constraint FK_Children_Parents_ParentID
            references Parents
            on delete cascade
)
go

create index IX_Children_ParentID
    on Children (ParentID)
