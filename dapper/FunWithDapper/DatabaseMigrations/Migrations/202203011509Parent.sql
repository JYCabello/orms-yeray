create table Parents
(
    ID   int identity
        constraint PK_Parents
        primary key,
    Name nvarchar(max) not null
)
