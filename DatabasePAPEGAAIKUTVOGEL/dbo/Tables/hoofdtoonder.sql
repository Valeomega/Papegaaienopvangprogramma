create table hoofdtoonder(
id int not null,
idondersoorten int foreign key references ondersoort(id) not null,
);