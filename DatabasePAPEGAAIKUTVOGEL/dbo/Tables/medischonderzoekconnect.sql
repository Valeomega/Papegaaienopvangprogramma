create table medischonderzoekconnect(
id int not null,
idmedischonderzoek int foreign key references medischonderzoek(id) not null,
);