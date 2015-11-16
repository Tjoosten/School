```
begin programma

	somvoet   = 0 
	somfiets  = 0 
	sommotor  = 0
	somauto   = 0
	somtram   = 0
	somtrein  = 0
	sombus    = 0
	somanders = 0
	
	for teller = 1 to 250 
		lees vervoer 
	
		select case vervoer 
		
			case 1: somvoet++
			case 2: somfiets++
			case 3: sommotor++
			case 4: somauto++
			case 5: somtram++
			case 6: sombus++
			case 7: somtrein++
			case 8: somanders++
		
			else: teller = teller -1
		endselect
	endfor
	
	pervoet   = somvoet / 2500 * 100
	perfiets  = somvoet / 2500 * 100
	permotor  = somvoet / 2500 * 100
	perauto   = somvoet / 2500 * 100
	pertram   = somvoet / 2500 * 100
	perbus    = somvoet / 2500 * 100
	pertrein  = somvoet / 2500 * 100
	peranders = somvoet / 2500 * 100
	
	druk pervoet, perfiets, permotor, perauto, pertram, perbus, pertrein, peranders
```
