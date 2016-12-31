create table medischonderzoek(
id int primary key not null,
idklachten int foreign key references klachtentoklacht(id),
);