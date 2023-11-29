## ADR Containerscanning 
### Status
accepted

### Context
Er bestaan veel containers in de pitstop app die niet gecontroleerd worden op security issues. Dit zorgt ervoor dat onze applicatie minder veilig wordt.

### Decision
We gaan gebruik maken van Trivy om de containers te scannen en zo vulnerabilities te vinden en op te lossen

### Consequences
Alle security issues worden opgespoord door Trivy zodat wij ze kunnen oplossen