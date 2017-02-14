## Opgave:

In een elektronicazaak zijn alles artikels geprijsd zonder BTW. 
Schrijf een algoritme dat de prijs (exclusief BTW) en het BTW-percentage 
inleest en prijs inclusief BTW berekent en afdrukt. 

## Oplossing:

```
begin 
  btwbedrag, btw, prijsInclusief, prijsExclusief :double 

  lees btw
  lees prijsExclusief 

  btwbedrag = prijsExclusief / 100 * btw
  prijsInclusief = btwbedrag + prijsExclusief

  druk prijsInclusief
einde
  
```
