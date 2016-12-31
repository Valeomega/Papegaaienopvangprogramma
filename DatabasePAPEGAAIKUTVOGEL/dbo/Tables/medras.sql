create table medras
(
Idmed int not null,
idrass int not null foreign key references vogelsoort(id), 
);