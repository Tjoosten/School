```
begin 

	lees leeftijd, bedrag 
	
	select case leeftijd 
		
		case leeftijd < 20:      premie = 2
		case 20 < leeftijd 30:   premie = 3.5
		case 30 < leeftijd < 40: premie 6.25 
		case 40 < leeftijd < 60: premie = 22
		
		else premie = 10
	endselect
	
	verzekerd = bedrag/1000 * premie * 12 

	druk verzekerd
endif
```
