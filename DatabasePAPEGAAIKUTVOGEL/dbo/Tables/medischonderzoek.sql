CREATE TABLE medischonderzoek
  (
     id         INT PRIMARY KEY NOT NULL,
     idklachten INT FOREIGN KEY REFERENCES klachtentoklacht(id)
  )