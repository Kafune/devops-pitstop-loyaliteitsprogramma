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

Voor elke 30 minuten dat de job duurt krijgt de customer 25 punten.
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

## Individuele bijdrage factsheets

# Eigen bijdrage <mijn-naam>
 
Als deliverable voor de individuele bijdrage in het beroepsproduct maak een eigen markdown bestand `<mijn-voornaam>.md` in je repo aan met tekst inclusief linkjes naar code en documentaties bestanden, pull requests, commit diffs. Maak hierin de volgende kopjes met een invulling.
 
Je schrapt verder deze tekst en vervangt alle andere template zaken, zodat alleen de kopjes over blijven. **NB: Aanwezigheid van template teksten na inleveren ziet de beoordelaar als een teken dat je documentatie nog niet af is, en hij/zij deze dus niet kan of hoeft te beoordelen**.
 
Je begin hier onder het hoofdkopje met een samenvatting van je bijdrage zoals je die hieronder uitwerkt. Best aan het einde schrijven. Zorg voor een soft landing van de beoordelaar, maar dat deze ook direct een beeld krijgt. Je hoeft geen heel verslag te schrijven. De kopjes kunnen dan wat korter met wat bullet lijst met links voor 2 tot 4 zaken en 1 of 2 inleidende zinnen erboven. Een iets uitgebreidere eind conclusie schrijf je onder het laatste kopje.


## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

Beschrijf hier kort je bijdrage vanuit je rol, developer (Dev) of infrastructure specialist (Ops). Als Developer beschrijf en geef je links van minimaal 2 en maximaal 4 grootste bijdrages qua code functionaliteiten of non-functionele requirements. Idealiter werk je TDD (dus ook commit van tests en bijbehorende code tegelijk), maar je kunt ook linken naar geschreven automatische tests (unit tests, acceptance tests (BDD), integratie tests, end to end tests, performance/load tests, etc.). Als Opser geef je je minimaal 2 maximaal 4 belangrijkste bijdragen aan het opzetten van het Kubernetes platform, achterliggende netwerk infrastructuur of configuration management (MT) buiten Kubernetes (en punt 2).
 
## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*
 
Beschrijf en geef hier links naar je minimaal 2 en maximaal 4 grootste bijdragen qua configuratie, of bijdrage qua 12factor app of container Dockerfiles en/of .yml bestanden of vergelijkbare config (rondom containerization en orchestration).

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

Beschrijf hier en geef links naar je bijdragen aan het opzetten en verder automatiseren van delivery pipeline, GitOps toepassing en/of het opzetten van monitoring, toevoegen van metrics en custom metrics en rapportages.

NB Het gebruik van *versiebeheer* ((e.g. git)) hoort bij je standaardtaken en deze hoef je onder dit punt NIET te beschrijven, het gaat hier vooral om documenteren van processtandaarden, zoals toepassen van een pull model.

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

Beschrijf hier voor het Course BP kort je onderzochte technologie met een link naar je blog post, of het toepassen ervan gelukt is en hoe, of waarom niet. Beschrijf evt. kort extra leerervaringen met andere technologieen of verdieping sinds het blog. 

Tijdens het grote project beschrijf je hier onderzoek naar het domein en nieuwe onderzochte/gebruikte DevOps technologieën. Wellicht heb je nogmaals de voor blog onderzochte technologie kunnen toepassen in een andere context. Verder heb je nu een complex domein waar je in moet verdiepen en uitvragen bij de opdrachtgever. Link bijvoorbeeld naar repo's met POC's of, domein modellen of beschrijf andere onderwerpen en link naar gebruikte bronnen.

Als de tijdens course onderzochte technologie wel toepasbaar is kun je dit uiteraard onder dit punt noemen. Of wellicht was door een teamgenoot onderzochte technologie relevant, waar jij je nu verder in verdiept hebt en mee gewerkt hebt, dus hier kunt beschrijven. Tot slot kun je hier ook juist een korte uitleg geef over WAAROM  jouw eerder onderzochte technologie dan precies niet relevant of inpasbaar was. Dit is voor een naieve buitenstaander niet altijd meteen duidelijk, maar kan ook heel interessant zijn. Bijvoorbeeld dat [gebruik van Ansible in combi met Kubernetes](https://www.ansible.com/blog/how-useful-is-ansible-in-a-cloud-native-kubernetes-environment) niet handig blijkt. Ook als je geen uitgebreid onderzoek hebt gedaan of ADR hebt waar je naar kunt linken, dan kun je onder dit kopje wel alsnog kort conceptuele kennis duidelijk maken.
 
## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

Beschrijf hier en geef links naar de minimaal 2 en maximaal 4 grootste *review acties* die je gedaan hebt, bijvoorbeeld pull requests incl. opmerkingen. Het interessantst zijn natuurlijk gevallen waar code niet optimaal was. Zorg dat je minstens een aantal reviews hebt waar in gitlab voor een externe de kwestie ook duidelijk is, in plaats van dat je dit altijd mondeling binnen het team oplost.
 
## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

Zet hier een links naar en geef beschrijving van je C4 diagram of diagrammen, README of andere markdown bestanden, ADR's of andere documentatie. Bij andere markdown bestanden of doumentatie kun je denken aan eigen proces documentatie, zoals code standaarden, commit- of branchingconventies. Tot slot ook user stories en acceptatiecriteria (hopelijk verwerkt in gitlab issues en vertaalt naar `.feature` files) en evt. noemen en verwijzen naar handmatige test scripts/documenten.
 
## 7. Bijdrage Agile werken, groepsproces en communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Beschrijf hier minimaal 2 en maximaal 4 situaties van je inbreng en rol tijdens Scrum ceremonies. Beschrijf ook feedback of interventies tijdens Scrum meetings, zoals sprint planning of retrospective die je aan groespgenoten hebt gegeven.

Beschrijf tijdens het project onder dit kopje ook evt. verdere activiteiten rondom communicatie met de opdrachtgever of domein experts, of andere meer 'professional skills' of 'soft skilss' achtige zaken.
  
## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

Geef tot slot hier voor jezelf minimaal 2 en maximaal **4 tops** en 2 dito (2 tot 4) **tips** á la professional skills die je kunt meenemen in je verdere loopbaan. Beschrijf ook de voor jezelf er het meest uitspringende hulp of feedback van groepsgenoten die je (tot dusver) hebt gehad tijdens het project.

## 9. Conclusie & feedback

Schrijf een conclusie van al bovenstaande punten. En beschrijf dan ook wat algemener hoe je terugkijkt op het project. Geef wat constructieve feedback, tips aan docenten/beoordelaars e.d. En beschrijf wat je aan devops kennis, vaardigheden of andere zaken meeneemt naar je afstudeeropdracht of verdere loopbaan. 

# C4 diagrams

## System context diagram

```mermaid
C4Context
        Person(EmployeeA, "Employee", "Employee working for pitstop")

        System(SystemA, "System pitstop webapp", "")

        System(SystemB, "Vehicle management", "")
        System(SystemC, "Customer managment", "")
        System(SystemD, "Workshop managment", "")
        System(SystemJ, "Loyalty program managment", "")

        System(SystemI, "MessageBroker", "")

        System(SystemE, "Time service","")
        System(SystemF, "Invoicing", "")
        System(SystemG, "Notifications", "")
        System(SystemH, "Auditlog", "")

        Rel_D(EmployeeA, SystemA, "Manages daily tasks with")
        Rel_D(SystemA, SystemB, "Communicates with")
        Rel_D(SystemA, SystemC, "Communicates with")
        Rel_D(SystemA, SystemD, "Communicates with")
        Rel_D(SystemA, SystemJ, "Communicates with")
        Rel_D(SystemJ, SystemI, "Publishes using")
        Rel_D(SystemB, SystemI, "Publishes using")
        Rel_D(SystemC, SystemI, "Publishes using")
        Rel_D(SystemD, SystemI, "Publishes using")
        Rel_D(SystemI, SystemF, "Sends events to")
        Rel_D(SystemI, SystemG, "Sends events to")
        Rel_D(SystemI, SystemH, "Sends events to")
        Rel_U(SystemE, SystemI, "Publishes using")
```
### Legenda
Pitstop Webapp System: The web application is the front-end for the system. Users can manage customers, vehicles and the planning for the workshop from this front-end. 
Vehicle Management: This service offers an API that is used to manage Vehicles in the system.
Customer Management: This service offers an API that is used to manage Customers in the system.
Workshop Management: This service contains 2 parts: an API for managing the workshop planning and an event-handler that handles events and builds a read-model that is used by the API.
Loyalty Program Management: This service handles rewards customers receive for their service and repairs.
Message Broker: Handles messages between services.
Time Service: Service that informs other services when a certain time-period has passed. 
Invoicing: Creates an invoice for all maintenance jobs that have been finished (and are not yet invoiced). 
Notifications: The notification service sends a notification to every customer that has a maintenance job planned on the current day.
Auditlog: Picks up all events from the message-broker and stores them for later reference.

## Container diagram

### Loyalty program diagram

```mermaid
C4Container
    Container_Boundary(c1, "Loyalty program") {
        ContainerDb(DatabaseA, Database, "")
        Container(SystemA, API, "")
    }
    System_Ext(SystemB, Pitstop Web APP, "")
    System_Ext(SystemC, Message Broker, "")
    Rel_D(SystemB, SystemA, "Request from")
    Rel_R(SystemA, DatabaseA, "Queries")
    Rel_D(SystemA, SystemC, "Uses")
```
