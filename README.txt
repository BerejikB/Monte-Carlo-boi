#Answers to question in assignment

##Why do we multiply the value from step 5 above by 4?
	
	π/4 . is the value of the area of the circle / by the area of the square, so we have to multiply values by 4 to get an accurate estimation of the area of the circle. 
	
	π/4≈ hypontenuse > 1/total hypontenuse
    π4≈ hypontenuse > 1/total hypontenuse

##What do you observe in the output when running your program with parameters of increasing size?
	The total number of hypotenuses over 1 increases, as would be expected, if the pool of possible values is larger, then the number of values that could be over 1 should also increase.
	The estimation of pi also gets closer to Math.PI's number. 
	

##If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
	The "estimation of pi" becomes more accurate, to a certain degree limited by randomnes.  
	The total number of hypotenuses > 0 increases hoewver, as it should.
	

##Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of π?
	No parameter I can input will cause over 1 second of run time without causing System.OverflowException.
	I have attached a screenshot in the ZIP, I seem to be able to run approxmately a 9 digit number with no issue, but anything longer causes a problem.


##Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
	