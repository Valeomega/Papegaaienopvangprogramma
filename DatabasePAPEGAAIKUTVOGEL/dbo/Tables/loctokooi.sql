create table loctokooi
(
Idloc int not null ,
idkooi int foreign key references kooien(Kooiid) not null,

);