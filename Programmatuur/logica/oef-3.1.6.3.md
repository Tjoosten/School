## Opgave 

De toegangsprijs voor een dierentuin bedraagd 10,- EUR voor volwassenen en 7,50- EUR voor kinderen onder de 12 jaar. 
Maak een schema voor een programma dat het aantal volwassenen en het aantal kinderen onder de 12 jaar inleest en daarna
de totale prijs berekent en afdrukt. 

## Oplossing: 

```
begin 
  aantalVolwassenen, aantalKinderen :int 
  prijsVolwassenen, prijsKinderen, prijsTotaal :double

  prijsVolwassenen = 70
  prijsKinderen    = 7,50

  lees aantalVolwassenen 
  lees aantalKinderen

  prijsTotaal = (aantalKinderen * prijsKinderen) + (prijsVolwassenen * aantalVolwassenen)

  druk prijsTotaal
einde
```
