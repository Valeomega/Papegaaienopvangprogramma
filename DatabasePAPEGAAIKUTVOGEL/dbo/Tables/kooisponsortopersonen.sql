CREATE TABLE kooisponsortopersonen
  (
     id         INT PRIMARY KEY NOT NULL,
     idpersonen INT FOREIGN KEY REFERENCES personen(id) NOT NULL
  )