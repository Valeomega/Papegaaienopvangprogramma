create table papegaaien
(
Id int primary key not null,
Naam varchar ,
idHoofdsoort int foreign key references vogelsoort(id) not null,
idOndersoort int foreign key references ondersoort(id) not null,
sex bit not null,
idmeter int foreign key references personen(id) not null,
idpeter int foreign key references personen(id) not null,
idmedischeinfo int foreign key references medisch(id),
identificationid int foreign key references identificationsystem(idfromid) not null,
aanofafwezig bit not null,
redenvanafwezig varchar,
idadoptant int foreign key references personen(id),
);