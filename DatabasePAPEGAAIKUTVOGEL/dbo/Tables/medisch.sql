CREATE TABLE medisch
  (
     id                 INT PRIMARY KEY NOT NULL,
     vastekuurid        INT FOREIGN KEY REFERENCES kuur(idkuur),
     idrefkuren         INT FOREIGN KEY REFERENCES kurenconect(id),
     idmedischonderzoek INT FOREIGN KEY REFERENCES medischonderzoekconnect(id) NOT NULL
  )