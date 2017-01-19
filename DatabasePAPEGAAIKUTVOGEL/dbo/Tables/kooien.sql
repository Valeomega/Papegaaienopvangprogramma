CREATE TABLE kooien
  (
     kooiid            INT NOT NULL PRIMARY KEY,
     kooidlistppg      INT FOREIGN KEY REFERENCES kooientoppg(id),
     quarantaine       BIT NOT NULL,
     idvogelsoort      INT NOT NULL FOREIGN KEY REFERENCES vogelsoort(id),
     idvogelondersoort INT NOT NULL FOREIGN KEY REFERENCES ondersoort(id),
     vasteoflossekooie BIT NOT NULL,
     bezetofniet       BIT NOT NULL,
     idlistsponsor     INT NOT NULL FOREIGN KEY REFERENCES kooisponsortopersonen
     (id)
  )