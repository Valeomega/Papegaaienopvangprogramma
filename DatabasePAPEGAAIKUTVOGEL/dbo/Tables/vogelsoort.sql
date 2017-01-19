CREATE TABLE vogelsoort
  (
     id                 INT PRIMARY KEY NOT NULL,
     naam               VARCHAR(200) NOT NULL,
     idtolistsubsoorten INT FOREIGN KEY REFERENCES hoofdtoonder(id) NOT NULL,
     idtovoeding        INT FOREIGN KEY REFERENCES hoofdtovoed(id) NOT NULL
  )