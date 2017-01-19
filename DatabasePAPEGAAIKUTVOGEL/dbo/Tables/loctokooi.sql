CREATE TABLE loctokooi
  (
     idloc  INT NOT NULL,
     idkooi INT FOREIGN KEY REFERENCES kooien(kooiid) NOT NULL
  )