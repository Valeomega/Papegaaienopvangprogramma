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