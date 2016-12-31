create table medicatie
(
id int primary key not null,
Naam varchar not null,
idlistrassen int foreign key references medras(Idmed),

);