# Calculation Appication
This simple web application takes a comma delimited list of numbers and returns the mean, median and mode of that list.

To start this application navigate to the CalculationClient directory and run 'npm install' then 'ng serve'
This chatbot was built using Microsoft's bot Framework (https://dev.botframework.com/) and deployed using an Azure application service


## Functionality
Spot has the follow functionality 
* **Tell me about [NFL Team abbreviation]** Will the return latest news on an NFL team from Rotoballer
* **[NFL team abbreviation] info** Will return some general information about an NFL team 
* **Show me [NFL team abbreviation] week #** will return the score for a given week in the most recent NFL season
* **[NFL team abbreviation] stats** will return the most recent statistics for a given NFL team


**All NFL data gathered using Fantasy Data API**(https://developer.fantasydata.com/).


is Licensed under [MIT License]()


### AI Integration 

Spot leverages Microsoft's LUIS to interpret and understand user intents (https://www.luis.ai/).
