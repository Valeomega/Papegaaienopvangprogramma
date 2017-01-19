CREATE TABLE medischonderzoekconnect
  (
     id                 INT NOT NULL,
     idmedischonderzoek INT FOREIGN KEY REFERENCES medischonderzoek(id) NOT NULL

  )