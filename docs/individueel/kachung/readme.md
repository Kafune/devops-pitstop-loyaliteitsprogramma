# Eigen bijdrage Kachung Li

Als deliverable voor de individuele bijdrage in het beroepsproduct maak een eigen markdown bestand `<mijn-voornaam>.md` in je repo aan met tekst inclusief linkjes naar code en documentaties bestanden, pull requests, commit diffs. Maak hierin de volgende kopjes met een invulling.
 
Je schrapt verder deze tekst en vervangt alle andere template zaken, zodat alleen de kopjes over blijven. **NB: Aanwezigheid van template teksten na inleveren ziet de beoordelaar als een teken dat je documentatie nog niet af is, en hij/zij deze dus niet kan of hoeft te beoordelen**.
 
Je begin hier onder het hoofdkopje met een samenvatting van je bijdrage zoals je die hieronder uitwerkt. Best aan het einde schrijven. Zorg voor een soft landing van de beoordelaar, maar dat deze ook direct een beeld krijgt. Je hoeft geen heel verslag te schrijven. De kopjes kunnen dan wat korter met wat bullet lijst met links voor 2 tot 4 zaken en 1 of 2 inleidende zinnen erboven. Een iets uitgebreidere eind conclusie schrijf je onder het laatste kopje.

SAMENVATTING BIJDRAGE SCHRIJVEN
- back-end opzetten API loyaliteitssysteem
  - EFCore opzet
  - Eerste API Controller
  - API verbonden met Docker netwerk met Compose

- Configuratie Tekton pipelines
  - Opzetten SSH verbinding
  - Clonen van Git repo
  - Opzetten Docker credentials (Nog niet gelukt, Github registry i.p.v. Docker registry proberen)
- Configuratie Github Actions
- Code reviews c4 diagram

## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

Beschrijf hier kort je bijdrage vanuit je rol, developer (Dev) of infrastructure specialist (Ops). Als Developer beschrijf en geef je links van minimaal 2 en maximaal 4 grootste bijdrages qua code functionaliteiten of non-functionele requirements. Idealiter werk je TDD (dus ook commit van tests en bijbehorende code tegelijk), maar je kunt ook linken naar geschreven automatische tests (unit tests, acceptance tests (BDD), integratie tests, end to end tests, performance/load tests, etc.). Als Opser geef je je minimaal 2 maximaal 4 belangrijkste bijdragen aan het opzetten van het Kubernetes platform, achterliggende netwerk infrastructuur of configuration management (MT) buiten Kubernetes (en punt 2).

- Aanmaken API Loyaliteitssysteem met ASP.net Core. [Link](https://github.com/hanaim-devops/pitstop-groep-d/issues/6)
- Aanmaken Models en DBContext voor gebruik EFCore.

Voor code heb ik voornamelijk aan de API van het loyaliteitssysteem gewerkt.

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*
 
Beschrijf en geef hier links naar je minimaal 2 en maximaal 4 grootste bijdragen qua configuratie, of bijdrage qua 12factor app of container Dockerfiles en/of .yml bestanden of vergelijkbare config (rondom containerization en orchestration).

- Tekton YAML bestanden aanmaken voor het pullen van een git repo. Latere stappen nog uitvoeren (bijvoorbeeld docker image pushen naar Docker Registry)
- Configuratie van loyaliteitsAPI zodat Pitstop gebruik maakt van die aparte microservice [Link naar commit]
- Dockerfile aangemaakt en aangepast voor Loyaliteitssysteem


## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

Beschrijf hier en geef links naar je bijdragen aan het opzetten en verder automatiseren van delivery pipeline, GitOps toepassing en/of het opzetten van monitoring, toevoegen van metrics en custom metrics en rapportages.

NB Het gebruik van *versiebeheer* ((e.g. git)) hoort bij je standaardtaken en deze hoef je onder dit punt NIET te beschrijven, het gaat hier vooral om documenteren van processtandaarden, zoals toepassen van een pull model.

- M.b.v Tekton (of Github Actions) Pipelines opzetten om het builden en pushen van image te automatiseren
- Opzet van Docker Registry (of Github Registry) voor updaten image

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

Beschrijf hier voor het Course BP kort je onderzochte technologie met een link naar je blog post, of het toepassen ervan gelukt is en hoe, of waarom niet. Beschrijf evt. kort extra leerervaringen met andere technologieen of verdieping sinds het blog. 

Tijdens het grote project beschrijf je hier onderzoek naar het domein en nieuwe onderzochte/gebruikte DevOps technologieën. Wellicht heb je nogmaals de voor blog onderzochte technologie kunnen toepassen in een andere context. Verder heb je nu een complex domein waar je in moet verdiepen en uitvragen bij de opdrachtgever. Link bijvoorbeeld naar repo's met POC's of, domein modellen of beschrijf andere onderwerpen en link naar gebruikte bronnen.

Als de tijdens course onderzochte technologie wel toepasbaar is kun je dit uiteraard onder dit punt noemen. Of wellicht was door een teamgenoot onderzochte technologie relevant, waar jij je nu verder in verdiept hebt en mee gewerkt hebt, dus hier kunt beschrijven. Tot slot kun je hier ook juist een korte uitleg geef over WAAROM  jouw eerder onderzochte technologie dan precies niet relevant of inpasbaar was. Dit is voor een naieve buitenstaander niet altijd meteen duidelijk, maar kan ook heel interessant zijn. Bijvoorbeeld dat [gebruik van Ansible in combi met Kubernetes](https://www.ansible.com/blog/how-useful-is-ansible-in-a-cloud-native-kubernetes-environment) niet handig blijkt. Ook als je geen uitgebreid onderzoek hebt gedaan of ADR hebt waar je naar kunt linken, dan kun je onder dit kopje wel alsnog kort conceptuele kennis duidelijk maken.

- Tekton beschrijven (Linken naar ADR)

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

Beschrijf hier en geef links naar de minimaal 2 en maximaal 4 grootste *review acties* die je gedaan hebt, bijvoorbeeld pull requests incl. opmerkingen. Het interessantst zijn natuurlijk gevallen waar code niet optimaal was. Zorg dat je minstens een aantal reviews hebt waar in gitlab voor een externe de kwestie ook duidelijk is, in plaats van dat je dit altijd mondeling binnen het team oplost.

- Review gegeven op C4 diagram voor loyaliteitsprogramma wegens kennis van API door het opzetten

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

Zet hier een links naar en geef beschrijving van je C4 diagram of diagrammen, README of andere markdown bestanden, ADR's of andere documentatie. Bij andere markdown bestanden of doumentatie kun je denken aan eigen proces documentatie, zoals code standaarden, commit- of branchingconventies. Tot slot ook user stories en acceptatiecriteria (hopelijk verwerkt in gitlab issues en vertaalt naar `.feature` files) en evt. noemen en verwijzen naar handmatige test scripts/documenten.
 
- Code review naar C4 Diagram (link)
- ADR geschreven voor Tekton waarom dit niet werkt (nog bijwerken)
- 1 User story geschreven over downtime loyaltysystem ()

## 7. Bijdrage Agile werken, groepsproces en communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Beschrijf hier minimaal 2 en maximaal 4 situaties van je inbreng en rol tijdens Scrum ceremonies. Beschrijf ook feedback of interventies tijdens Scrum meetings, zoals sprint planning of retrospective die je aan groespgenoten hebt gegeven.

Beschrijf tijdens het project onder dit kopje ook evt. verdere activiteiten rondom communicatie met de opdrachtgever of domein experts, of andere meer 'professional skills' of 'soft skilss' achtige zaken.

- Werkproces in scrum gedaan. Elke dag een daily standup gedaan en het einde van de dag nog een daily standdown via teams.
  
## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

Geef tot slot hier voor jezelf minimaal 2 en maximaal **4 tops** en 2 dito (2 tot 4) **tips** á la professional skills die je kunt meenemen in je verdere loopbaan. Beschrijf ook de voor jezelf er het meest uitspringende hulp of feedback van groepsgenoten die je (tot dusver) hebt gehad tijdens het project.

Top

- Bijdrage kennis
- Doorzetten
  - Vaak problemen verder uitzoeken in vrije tijd

Tips

- Initiatief nemen
  - Hulp aanbieden opzetten API
  - Weten wanneer doorzetten te ver gaat
- Doorzetten
- Meer vragen naar domein expert

## 9. Conclusie & feedback

Schrijf een conclusie van al bovenstaande punten. En beschrijf dan ook wat algemener hoe je terugkijkt op het project. Geef wat constructieve feedback, tips aan docenten/beoordelaars e.d. En beschrijf wat je aan devops kennis, vaardigheden of andere zaken meeneemt naar je afstudeeropdracht of verdere loopbaan. 

CDMM INVULLEN VOOR PROJECT MET TOELICHTING

- Begin project was lastig om op te starten. Geen idee wat er moest gebeuren.
- Helaas bij begin weinig met Kubernetes & Rancher gedaan, handig geweest om dit vanaf begin af aan te doen.
  - Teamlid vroeg af wat het punt was. Kon ik op dat moment niet bedenken, maar richting het einde was het handig geweest om gewoon de kennis te hebben om een Kubernetes app te deployen op Rancher.
