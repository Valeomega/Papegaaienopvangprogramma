create database data_papegaaien_opvang;
create table personen(
id int primary key not null,
naam varchar not null,
achternaam varchar not null,
straatnaam varchar not null,
straatnr int not null,
postcode int not null,
telnr varchar not null,
email varchar not null,
gsmnr varchar not null,
rekeningnr varchar not null,
xrtanotities varchar not null,

);
create table ondersoort(
id int primary key ,
naam varchar,
);
create table perdagvoeder(
id int primary key ,
datum date not null,
);
create table voedertijd(
id int not null,
iddatum int references perdagvoeder(id)
);
create table voeding(
id int primary key not null,
idijdvoederen int foreign key references voedertijd(id) not null,
aantalsheppen int not null,
naameten varchar not null,
);
create table hoofdtoonder(
id int not null,
idondersoorten int foreign key references ondersoort(id) not null,
);
create table hoofdtovoed(
id int not null,
idvoeding int foreign key references voeding(id) not null,
);
create table vogelsoort(
id int primary key not null,
naam varchar not null,
idtolistsubsoorten int foreign key references hoofdtoonder(id) not null,
idtovoeding int foreign key references hoofdtovoed(id) not null,
);

create table identificationsystem
(
idfromid int not null primary key,
ringnr varchar not null,
regin int not null,
regout int,
citesnr varchar,
);


create table medras
(
Idmed int not null,
idrass int not null foreign key references vogelsoort(id), 
);
create table medicatie
(
id int primary key not null,
Naam varchar not null,
idlistrassen int foreign key references medras(Idmed),

);
create table kuur
(
IDkuur int not null primary key,
idkuurmedicatie int not null foreign key references medicatie(id),
Uurvanaanbreng datetime not null,
dosering decimal not null,
extrainfo varchar , 
);
create table kurenconect
(
id int not null ,
idkuur int not null 
);
create table klachtverwonding(
id int primary key not null,
infoverwonding varchar not null,
datum datetime not null,
Persoonidwaarnemer int foreign key references personen(id) not null,
locatieverwonding varchar not null,
oorzaak varchar not null,

);
create table klachtentoklacht(
id int not null,
idklacht int foreign key references klachtverwonding(id) not null,
);
create table medischonderzoek(
id int primary key not null,
idklachten int foreign key references klachtentoklacht(id),
);
create table medischonderzoekconnect(
id int not null,
idmedischonderzoek int foreign key references medischonderzoek(id) not null,
);
create table medisch
(
id int primary key not null ,
vastekuurid int foreign key references kuur(IDkuur),
idrefkuren int foreign key references kurenconect(id) ,
idmedischonderzoek int foreign key references medischonderzoekconnect(id) not null

);
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
create table kooientoppg
(
Id int primary key not null,
idpapegaaien int foreign key references papegaaien(Id),

);
create table kooisponsortopersonen(
id int primary key not null,
idpersonen int foreign key references personen(id) not null ,
);
create table kooien
(
Kooiid int NOT NULL PRIMARY KEY,
Kooidlistppg int foreign key references kooientoppg(Id),
quarantaine bit not null ,
idvogelsoort int not null foreign key references vogelsoort(id),
idvogelondersoort int not null foreign key references ondersoort(id) ,
vasteoflossekooie bit not null,
bezetofniet bit not null,
idlistsponsor int not null foreign key references kooisponsortopersonen(id) ,

);
create table loctokooi
(
Idloc int not null ,
idkooi int foreign key references kooien(Kooiid) not null,

);
create table locatie
(
id int primary key not null,
idkooilist int foreign key references loctokooi(Idloc) not null,
toegang bit not null,
naam varchar not null,
);