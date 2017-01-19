CREATE TABLE klachtentoklacht
  (
     id       INT NOT NULL,
     idklacht INT FOREIGN KEY REFERENCES klachtverwonding(id) NOT NULL
  )