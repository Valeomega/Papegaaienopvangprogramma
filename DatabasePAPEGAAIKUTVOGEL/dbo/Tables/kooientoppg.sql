CREATE TABLE kooientoppg
  (
     id           INT PRIMARY KEY NOT NULL,
     idpapegaaien INT FOREIGN KEY REFERENCES papegaaien(id)
  )