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