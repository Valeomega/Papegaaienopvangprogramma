 CREATE TABLE personen
  (
     id           INT NOT NULL,
     naam         VARCHAR(200) NOT NULL,
     achternaam   VARCHAR(200) NOT NULL,
     straatnaam   VARCHAR(200) NOT NULL,
     straatnr     INT NOT NULL,
     postcode     INT NOT NULL,
     telnr        VARCHAR(200) NOT NULL,
     email        VARCHAR(200) NOT NULL,
     gsmnr        VARCHAR(200) NOT NULL,
     rekeningnr   VARCHAR(200) NOT NULL,
     xrtanotities VARCHAR(200) NOT NULL,
     PRIMARY KEY (id)
  )

 CREATE TABLE ondersoort
  (
      id int not null,  
      naam VARCHAR(200),
     PRIMARY KEY (id)
  )

 CREATE TABLE perdagvoeder
  (
     id    INT NOT NULL,
     datum DATE NOT NULL,
     PRIMARY KEY (id)
  )

 CREATE TABLE voedertijd
  (
     id      INT NOT NULL primary key,
     iddatum INT REFERENCES perdagvoeder(id)
  )

 CREATE TABLE voeding
  (
     id            INT PRIMARY KEY NOT NULL,
     idijdvoederen INT REFERENCES voedertijd(id) 
     aantalsheppen INT NOT NULL,
     naameten      VARCHAR NOT NULL
  )

 CREATE TABLE hoofdtoonder (
    id             INT NOT NULL,
    idondersoorten INT NOT NULL REFERENCES `ondersoort`(`id`)     
);

 CREATE TABLE hoofdtovoed
  (
     id        INT NOT NULL,
     idvoeding INT REFERENCES voeding(id) NOT NULL
  )

 CREATE TABLE vogelsoort
  (
     id                 INT ,
     naam               VARCHAR(200) NOT NULL,
     idtolistsubsoorten INT  NOT NULL,
     idtovoeding        INT  NOT NULL
	 KEY `id` (`id`),
	 CONSTRAINT `idtolistsubsoorten` FOREIGN KEY (`idtolistsubsoorten`) REFERENCES `hoofdtoonder` (`id`)
	 CONSTRAINT `idtovoeding` FOREIGN KEY (`idtovoeding`) REFERENCES `hoofdtovoed` (`id`)
  )

 CREATE TABLE identificationsystem
  (
     idfromid INT NOT NULL PRIMARY KEY,
     ringnr   VARCHAR(200) NOT NULL,
     regin    INT NOT NULL,
     regout   INT,
     citesnr  VARCHAR(200)
  )

 CREATE TABLE medras
  (
     idmed  INT NOT NULL,
     idrass INT NOT NULL REFERENCES vogelsoort(id)
  )

 CREATE TABLE medicatie
  (
     id           INT PRIMARY KEY NOT NULL,
     naam         VARCHAR(200) NOT NULL,
     idlistrassen INT REFERENCES medras(idmed)
  )

 CREATE TABLE kuur
  (
     idkuur          INT NOT NULL PRIMARY KEY,
     idkuurmedicatie INT NOT NULL REFERENCES medicatie(id),
     uurvanaanbreng  DATETIME NOT NULL,
     dosering        DECIMAL NOT NULL,
     extrainfo       VARCHAR
  )

 CREATE TABLE kurenconect
  (
     id     INT NOT NULL,
     idkuur INT NOT NULL
  )

 CREATE TABLE klachtverwonding
  (
     id                 INT PRIMARY KEY NOT NULL,
     infoverwonding     VARCHAR(200) NOT NULL,
     datum              DATETIME(3) NOT NULL,
     persoonidwaarnemer INT REFERENCES personen(id) NOT NULL,
     locatieverwonding  VARCHAR NOT NULL,
     oorzaak            VARCHAR NOT NULL
  )

 CREATE TABLE klachtentoklacht
  (
     id       INT NOT NULL,
     idklacht INT REFERENCES klachtverwonding(id) NOT NULL
  )

 CREATE TABLE medischonderzoek
  (
     id         INT PRIMARY KEY NOT NULL,
     idklachten INT REFERENCES klachtentoklacht(id)
  )

 CREATE TABLE medischonderzoekconnect
  (
     id                 INT NOT NULL,
     idmedischonderzoek INT REFERENCES medischonderzoek(id) NOT NULL

  )

 CREATE TABLE medisch
  (
     id                 INT PRIMARY KEY NOT NULL,
     vastekuurid        INT REFERENCES kuur(idkuur),
     idrefkuren         INT REFERENCES kurenconect(id),
     idmedischonderzoek INT REFERENCES medischonderzoekconnect(id) NOT NULL
  )

 CREATE TABLE papegaaien
  (
     id               INT PRIMARY KEY NOT NULL,
     naam             VARCHAR(200),
     idhoofdsoort     INT REFERENCES vogelsoort(id) NOT NULL,
     idondersoort     INT REFERENCES ondersoort(id) NOT NULL,
     sex              BIT NOT NULL,
     idmeter          INT REFERENCES personen(id) NOT NULL,
     idpeter          INT REFERENCES personen(id) NOT NULL,
     idmedischeinfo   INT REFERENCES medisch(id),
     identificationid INT REFERENCES identificationsystem(idfromid) NOT NULL,
     aanofafwezig     BIT NOT NULL,
     redenvanafwezig  VARCHAR,
     idadoptant       INT REFERENCES personen(id)
  )

 CREATE TABLE kooientoppg
  (
     id           INT PRIMARY KEY NOT NULL,
     idpapegaaien INT REFERENCES papegaaien(id)
  )

 CREATE TABLE kooisponsortopersonen
  (
     id         INT PRIMARY KEY NOT NULL,
     idpersonen INT REFERENCES personen(id) NOT NULL
  )

CREATE TABLE kooien
  (
     kooiid            INT NOT NULL PRIMARY KEY,
     kooidlistppg      INT REFERENCES kooientoppg(id),
     quarantaine       BIT NOT NULL,
     idvogelsoort      INT NOT NULL REFERENCES vogelsoort(id),
     idvogelondersoort INT NOT NULL REFERENCES ondersoort(id),
     vasteoflossekooie BIT NOT NULL,
     bezetofniet       BIT NOT NULL,
     idlistsponsor     INT NOT NULL REFERENCES kooisponsortopersonen
     (id)
  )

CREATE TABLE loctokooi
  (
     idloc  INT NOT NULL,
     idkooi INT REFERENCES kooien(kooiid) NOT NULL
  )

CREATE TABLE locatie
  (
     id         INT PRIMARY KEY NOT NULL,
     idkooilist INT REFERENCES loctokooi(idloc) NOT NULL,
     toegang    BIT NOT NULL,
     naam       VARCHAR NOT NULL
  )  