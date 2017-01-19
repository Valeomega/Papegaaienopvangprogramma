CREATE TABLE hoofdtoonder
  (
     id             INT NOT NULL,
     idondersoorten INT FOREIGN KEY REFERENCES ondersoort(id) NOT NULL,
  )