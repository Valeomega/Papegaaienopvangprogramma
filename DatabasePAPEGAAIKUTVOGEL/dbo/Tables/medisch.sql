create table medisch
(
id int primary key not null ,
vastekuurid int foreign key references kuur(IDkuur),
idrefkuren int foreign key references kurenconect(id) ,
idmedischonderzoek int foreign key references medischonderzoekconnect(id) not null

);