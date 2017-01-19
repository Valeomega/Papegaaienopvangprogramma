CREATE TABLE papegaaien
  (
     id               INT PRIMARY KEY NOT NULL,
     naam             VARCHAR(200),
     idhoofdsoort     INT FOREIGN KEY REFERENCES vogelsoort(id) NOT NULL,
     idondersoort     INT FOREIGN KEY REFERENCES ondersoort(id) NOT NULL,
     sex              BIT NOT NULL,
     idmeter          INT FOREIGN KEY REFERENCES personen(id) NOT NULL,
     idpeter          INT FOREIGN KEY REFERENCES personen(id) NOT NULL,
     idmedischeinfo   INT FOREIGN KEY REFERENCES medisch(id),
     identificationid INT FOREIGN KEY REFERENCES identificationsystem(idfromid) NOT NULL,
     aanofafwezig     BIT NOT NULL,
     redenvanafwezig  VARCHAR,
     idadoptant       INT FOREIGN KEY REFERENCES personen(id)
  )