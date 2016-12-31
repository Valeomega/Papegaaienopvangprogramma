create table hoofdtovoed(
id int not null,
idvoeding int foreign key references voeding(id) not null,
);