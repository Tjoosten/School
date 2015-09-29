PRG - Psuedocode 
=========================
Psuedocode wordt over het algemeen een onechte (niet-formele) programmeertaal bedoeld. 
'Pseudo' betekend onecht, 'code' verwijst naar de broncode van een computer programma. 
Door dat het een informaal karakter heeft, is het niet geschikt om gecompileerd en uitgevoerd te worden. 
Het word hierdoor niet officieel herkend als development of programmeer taal. 

Pseudocode heeft verschillende doeleinden, zo word het bv gebruikt om algoritmen vast te leggen
een makkelijk verstaanbare manier met behoud van stappen. 
Natuurlijke taal us hiervoor niet voor geschikt. omdat deze ambigu is. 

Een werkelijke (formele) programmeertaal is meestal te strak en bevat een strikte syntax, 
en vereist nog eens specifieke kennis van die taal om het algoritme snel voor begrijpelijk te maken? 

In pseudocode komen bekende constructies uit bestaande programmeertalen voor zoals C, Java, BASIC. 

Een voorbeeld van pseudocode:

```java
If within boundaries of search 
  Calculate midpoint
  If value at midpoint is what we are looking for 
    Return midpoint
  Else if value is midpoint is too big 
    Look to the left
  Else if value at midpoint is too small 
    Look to the right? 
  EndIf
EndIf

Return -1 when number wasn't found
```

Pseudocode is nergens echt gedefinieerd (zoals dat bij het ontwerpen van een echte programmeertaal wel gebeurt), 
waardoor de schrijver van de pseudocode een zeer grote, haast dichterlijke vrijheid heeft.
Hierdoor kan een hoger abstractieniveau worden gebruikt dan in een programmeertaal, 
hetgeen de leesbaarheid ten goede komt.

Net als programmeertalen maakt pseudocode gebruik van constructies voor herhalingen en beslissingen. 
Ook is het gebruikelijk pseudocode te laten inspringen. 
Details die voor compilers van belang zijn maar de leesbaarheid niet dienen (zoals puntkomma's en accolades) worden meestal niet gebruikt.
