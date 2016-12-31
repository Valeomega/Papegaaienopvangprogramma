create table kooisponsortopersonen(
id int primary key not null,
idpersonen int foreign key references personen(id) not null ,
);