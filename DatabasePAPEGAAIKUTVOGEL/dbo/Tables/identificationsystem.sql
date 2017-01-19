CREATE TABLE identificationsystem
  (
     idfromid INT NOT NULL PRIMARY KEY,
     ringnr   VARCHAR(200) NOT NULL,
     regin    INT NOT NULL,
     regout   INT,
     citesnr  VARCHAR(200)
  )