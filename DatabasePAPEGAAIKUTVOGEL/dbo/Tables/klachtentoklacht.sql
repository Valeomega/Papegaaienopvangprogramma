create table klachtentoklacht(
id int not null,
idklacht int foreign key references klachtverwonding(id) not null,
);