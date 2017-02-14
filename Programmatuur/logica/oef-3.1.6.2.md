## Opgave:

In een elektronicazaak zijn alles artikels geprijsd zonder BTW. 
Schrijf een algoritme dat de prijs (exclusief BTW) en het BTW-percentage 
inleest en prijs inclusief BTW berekent en afdrukt. 

## Oplossing:

```
begin 
  prijs, btw, prijsInclusief, prijsExclusief :double 

  prijsExclusief = prijs / 100 * btw
  prijsInclusief = prijs + prijsExclusief

  druk prijsInclusief
einde
```
