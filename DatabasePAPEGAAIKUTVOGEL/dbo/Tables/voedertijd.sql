CREATE TABLE voedertijd
  (
     id      INT NOT NULL,
     iddatum INT REFERENCES perdagvoeder(id)
  )