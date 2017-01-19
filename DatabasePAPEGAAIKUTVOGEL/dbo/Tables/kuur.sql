CREATE TABLE kuur
  (
     idkuur          INT NOT NULL PRIMARY KEY,
     idkuurmedicatie INT NOT NULL FOREIGN KEY REFERENCES medicatie(id),
     uurvanaanbreng  DATETIME NOT NULL,
     dosering        DECIMAL NOT NULL,
     extrainfo       VARCHAR
  )