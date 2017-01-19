CREATE TABLE medras
  (
     idmed  INT NOT NULL,
     idrass INT NOT NULL FOREIGN KEY REFERENCES vogelsoort(id)
  )