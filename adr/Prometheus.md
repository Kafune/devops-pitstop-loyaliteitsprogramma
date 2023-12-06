# ADR Prometheus
## Status: Accepted

### Context

Met de toenemende complexiteit van moderne IT-infrastructuren is het monitoren en verzamelen van gegevens van cruciaal belang geworden. Prometheus is een populaire open-source oplossing voor monitoring en het verzamelen van metrische gegevens in gedistribueerde omgevingen.

### Decision

Het implementeren van Prometheus als de standaard monitoringtool voor het verzamelen van metrische gegevens van verschillende systemen, services en applicaties. Prometheus zal worden geconfigureerd en geïntegreerd met de benodigde exporters om metrische gegevens te verzamelen en op te slaan.

### Consequences

1. **Krachtige Monitoring:** Prometheus biedt flexibele querymogelijkheden met PromQL en een schaalbare gegevensopslag, waardoor gedetailleerde inzichten in de systeemprestaties mogelijk zijn.

2. **Leercurve:** Het leren gebruiken van PromQL en het effectief configureren van Prometheus kan tijd vergen. Dit kan extra training en inspanning vereisen voor teamleden die met Prometheus werken.

3. **Systeembronnen:** Het continue verzamelen van metrische gegevens kan leiden tot een verhoogd gebruik van systeembronnen. Efficiënt beheer van retentiebeleid en opslag is cruciaal om de schaalbaarheid te handhaven.

Het implementeren van Prometheus biedt aanzienlijke mogelijkheden voor gedetailleerde monitoring, maar vereist mogelijk initiële training en aandacht voor resourcebeheer.
