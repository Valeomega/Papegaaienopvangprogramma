CREATE TABLE hoofdtovoed
  (
     id        INT NOT NULL,
     idvoeding INT FOREIGN KEY REFERENCES voeding(id) NOT NULL
  )