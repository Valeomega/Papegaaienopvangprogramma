create table voedertijd(
id int not null,
iddatum int references perdagvoeder(id)
);