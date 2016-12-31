create table locatie
(
id int primary key not null,
idkooilist int foreign key references loctokooi(Idloc) not null,
toegang bit not null,
naam varchar not null,
);