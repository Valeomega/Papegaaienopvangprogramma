create table voeding(
id int primary key not null,
idijdvoederen int foreign key references voedertijd(id) not null,
aantalsheppen int not null,
naameten varchar not null,
);