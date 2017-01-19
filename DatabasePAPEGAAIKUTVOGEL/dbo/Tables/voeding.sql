CREATE TABLE voeding
  (
     id            INT PRIMARY KEY NOT NULL,
     idijdvoederen INT FOREIGN KEY REFERENCES voedertijd(id) NOT NULL,
     aantalsheppen INT NOT NULL,
     naameten      VARCHAR NOT NULL
  )