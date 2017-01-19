CREATE TABLE medicatie
  (
     id           INT PRIMARY KEY NOT NULL,
     naam         VARCHAR(200) NOT NULL,
     idlistrassen INT FOREIGN KEY REFERENCES medras(idmed)
  )