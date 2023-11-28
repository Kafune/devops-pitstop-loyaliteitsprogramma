# Draft gebruiken voor opzet deployment pipeline kubernetes

## Status
Rejected

## Decision
Terwijl we Draft wel kunnen gebruiken om gemakkelijk een docker compose aan te maken is Draft niet bruikbaar voor het beroepsproduct. De belangrijkste functionaliteit van Draft is om een deployment pipeline op te zetten voor een kubernetes cluster. Helaas doet Draft dit alleen met Azure en moet deployment naar andere clusters handmatig geconfigureerd worden. Daardoor hebben we ervoor gekozen Draft niet te gebruiken bij het beroepsproduct aangezien de hoofdfunctionaliteit van Draft niet werkt met onze uiteindelijke deployment.

## Consequences
Het aanmaken van een Docker Compose bestand moet hierdoor handmatig gedaan worden. Het opzetten van de deployment naar de kubernetes cluster moet alsnog handmatig gevonfigureerd worden of met een andere tool.