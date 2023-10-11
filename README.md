# Pitstop Groep D

## Technologieën

- Wijnand: DevSecOps Container Scanning
- Kachung: Tekton CI/CD
- Wesley: Kubernetes secrets management via externe provider
- Cüneyt: Draft
- Nigel: Prometheus en Slack integratie
- Tom: InfluxDB

## Opdracht

Gekozen opdracht:

**Loyaliteitsprogramma:**
   Een loyaliteitsprogramma introduceren waar klanten punten verdienen voor elke service of reparatie. Deze punten kunnen worden ingewisseld voor kortingen op toekomstige diensten, wat de klantenbinding versterkt.

Voorbeeld puntensysteem:

```text
Puntensysteem voor Klantloyaliteitsprogramma:

Uitgegeven Bedrag:

Voor elke euro die een klant uitgeeft aan onderhouds- en reparatiediensten, ontvangt hij/zij 1 loyaliteitspunt.
Niveaus en Beloningen:

- Zilverniveau (0-500 punten):
  - 500 punten: 10% korting op de volgende servicebeurt.
  - 1000 punten: Gratis olieverversing.
- Goudniveau (501-1000 punten):
  - 1000 punten: 15% korting op de volgende servicebeurt.
  - 1500 punten: Gratis APK-keuring.
- Platinaniveau (1001+ punten):
  - 2000 punten: 20% korting op de volgende servicebeurt.
  - 2500 punten: Gratis kleine reparatie (tot een bepaald bedrag).
- Speciale Acties:
  - Verdien dubbele punten tijdens speciale actieperiodes (bijvoorbeeld: feestdagen, jubileumvieringen).
- Vriendenverwijzingsbonus:
  - Verdien 100 extra punten voor elke nieuwe klant die wordt doorverwezen naar het loyaliteitsprogramma.
- Verjaardagsbeloning:
  - Ontvang 50 punten als geschenk op je verjaardag.
- Inwisselen van Punten:
  - Klanten kunnen hun punten inwisselen bij de volgende servicebeurt of reparatie.

Dit is slechts een voorbeeld en het puntensysteem kan naar wens worden aangepast. Het is belangrijk dat het systeem duidelijk en transparant is voor klanten, zodat ze begrijpen hoe ze punten kunnen verdienen en hoe ze deze kunnen inwisselen voor beloningen. Daarnaast is het van belang om de privacy van klantgegevens te waarborgen en te voldoen aan eventuele wettelijke vereisten met betrekking tot loyaliteitsprogramma's.
```

Maak een (eigen) README in PitStop (sla originele README elders op, net als bij weekopdrachten)
Doe aan README driven development, lees de opdracht door op minordevops.nl . En zet de opdracht voor je team in de README

- A1. Applicatie live zetten (en houden)a. de applicatie werkend krijgt op een productie omgeving (dag 1 sprint 1).
  - a. maar ook een (externe) staging omgeving (cq. test, QA, etc.). (dag 2 sprint 1)
- A2. Toepassen technologieën
  - a. Je past alle technologieen toe van alle teamleden in het product.
  - b. Documenteert het gebruik in README, ADR’s en/of verwijzing/quote uit eigen blogs
  - c. En/of automatiseert in shell scripts zodat ook iemand die technologie niet kent met het product kan werken
- A3. Product Increment
  - a. Makkelijke uitrol van je product increment, via ‘niet standaard’ Deploymenbijvoorbeeld Canary, Blue Green Deployment of gebruik van een externe tool als Helm of Ansible
  - b. Aanpassing van architectuur van de applicatie, inclusief documentatie!
  - c. Monitoring van hardware gebruik
om problemen te voorkomen en efficiency en kostenbesparing mogelijk te maken en evt. custom metric en rapportages
  - d. Security aspecten, bv scan op container en/of dependency niveau
update van dependencies en uitrollen ervan zonder regressiefouten of voor gebruikers merkbare glitches of functionele veranderingen
  - e. Automatische schaling, bv. bij meer of minder (gesimuleerde) gebruikers
  - f. Fouttolerantie, design for failure en/of High Availabilityuitvallende hardware of services erop heeft geen merkbare gevolgen (evt. Chaos engineering toepassen)
Je ziet dat er heel wat items zijn. Maak erna issues aan, en prioriteer en verdeel de eerste.

## Leerdoelen Beroepsproduct

A. Het team:

- [ ] deployt een applicatie (systeem) die bestaat uit meerdere containers (microservices) naar minstens één live omgeving
- [ ] past de onderzochte DevOps technologieën uit de onderzoeksweek toe in de applicatie en/of deployment
- [ ] voert hierop een product increment door met toepassing van de in thema weken opgedane kennis en vaardigheden

B. Elk groepslid laat zien dat hij/zij:

- [ ] effectief samenwerkt in een team en onderling goed communiceert
- [ ] een eigen eigen rol en specialisatie heeft gevonden
- [ ] een bijdrage levert en een Agile aanpak hanteert
