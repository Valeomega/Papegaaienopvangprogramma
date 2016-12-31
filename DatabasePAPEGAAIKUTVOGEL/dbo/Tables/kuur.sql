create table kuur
(
IDkuur int not null primary key,
idkuurmedicatie int not null foreign key references medicatie(id),
Uurvanaanbreng datetime not null,
dosering decimal not null,
extrainfo varchar , 
);