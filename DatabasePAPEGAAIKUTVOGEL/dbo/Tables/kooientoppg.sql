create table kooientoppg
(
Id int primary key not null,
idpapegaaien int foreign key references papegaaien(Id),

);