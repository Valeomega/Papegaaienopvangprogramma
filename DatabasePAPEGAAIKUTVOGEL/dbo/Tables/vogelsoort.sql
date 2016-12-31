create table vogelsoort(
id int primary key not null,
naam varchar not null,
idtolistsubsoorten int foreign key references hoofdtoonder(id) not null,
idtovoeding int foreign key references hoofdtovoed(id) not null,
);