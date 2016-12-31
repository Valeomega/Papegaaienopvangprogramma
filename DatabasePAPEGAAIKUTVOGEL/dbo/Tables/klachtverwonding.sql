create table klachtverwonding(
id int primary key not null,
infoverwonding varchar not null,
datum datetime not null,
Persoonidwaarnemer int foreign key references personen(id) not null,
locatieverwonding varchar not null,
oorzaak varchar not null,

);