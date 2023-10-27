# Eigen bijdrage Kachung Li

Als deliverable voor de individuele bijdrage in het beroepsproduct maak een eigen markdown bestand `<mijn-voornaam>.md` in je repo aan met tekst inclusief linkjes naar code en documentaties bestanden, pull requests, commit diffs. Maak hierin de volgende kopjes met een invulling.

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

Voor code heb ik voornamelijk aan [de back-end van het loyaliteitssysteem](https://github.com/hanaim-devops/pitstop-groep-d/issues/6) gewerkt, voornamelijk [het opzetten hiervan] zodat mijn teamleden hiermee verder konden. Hierbij heb ik een aparte .Net Core API aangemaakt. Hierbij heb ik [het eerste model en controller](https://github.com/hanaim-devops/pitstop-groep-d/commit/7f89efec6c880baf0b422d4da6d7d486fc5d986f) aangemaakt voor het loyaliteitssysteem. De controller had alleen een GET request om te testen of de API daadwerkelijk werkte. Ook heb ik de [integratie met EFCore](https://github.com/hanaim-devops/pitstop-groep-d/commit/582a026231a8409d1e5eefd606f223c8bc6143b9) werkend gekregen zodat het makkelijk is om een databasetabel aan te maken d.m.v. het ORM systeem. Het werkend krijgen van de EFCore verbinding met de database in Docker duurde het langste. Nadat dit was gelukt, kon ik het API overdragen naar mijn teamgenoten overdragen zodat zij de endpoints konden maken.

## 2. Bijdrage app configuratie/containers/kubernetes

De API van het loyaliteitssysteem heb ik uiteindelijk met Pitstop geïntegreerd d.m.v. Docker compose. Hiervoor heb ik de [Dockerfile](https://github.com/hanaim-devops/pitstop-groep-d/blob/main/src/LoyaltySystemAPI/Dockerfile) en de [bestaande Docker Compose](https://github.com/hanaim-devops/pitstop-groep-d/commit/56685a7be8d0c2f21a9060435c8774e5a55801ed) aangepast zodat de image op dezelfde manier als de andere bestaande microservices van Pitstop werd gebouwd. Het configureren duurde een stuk langer dan verwacht, voornamelijk omdat er toch [een aantal verschillen zaten bij de configuraties](https://github.com/hanaim-devops/pitstop-groep-d/commit/582a026231a8409d1e5eefd606f223c8bc6143b9) die ik samen met een teamgenoot gewoon niet zag. Dit wist ik uiteindelijk te fixen nadat ik later verder ging.

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
  - Werkte niet (authenticatie Docker credentials niet goed doordat Pitstop niet in openbare repository binnen Docker registry stond) NOG WEL KIJKEN OF GITHUB REGISTRY WERKT - MAX 2u (helaas niet werkend: ghcr.io login)
  - Beschrijven verdere potentie niet kunnen uitzoeken doordat veel tijd kwijt aan uitzoeken authenticatie met SSH en Docker credentials (v0.6 git-clone task)
  
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

Ik ben blij met de bijdrage en overdracht van de back-end API. Het heeft me veel tijd gekost om de back-end in elkaar te zetten, voornamelijk de configuratie van de API en de integratie met Pitstop. Hiervoor moest ik vaak een stuk langer doorwerken om dat voor elkaar te krijgen, waardoor de API uiteindelijk werkt. We hadden nog de gedachte om geen database te gebruiken omdat de connectie via EFCore gewoon niet goed ging. Ik heb veel doorgezet om het probleem uiteindelijk op te lossen.

Dit is echter ook een valkuil tegelijk, want ik ben erg lang bezig geweest om Tekton CI/CD te integreren, maar het authenticeren binnen Tekton is mij uiteindelijk niet gelukt. Ik ben hier waarschijnlijk het meeste tijd kwijt voor geen resultaat, en ik heb hiervoor ook geen hulp gevraagd. Hiervoor had ik beter een domeinexpert kunnen vragen waarom het steeds niet lukte.

## 9. Conclusie & feedback

Schrijf een conclusie van al bovenstaande punten. En beschrijf dan ook wat algemener hoe je terugkijkt op het project. Geef wat constructieve feedback, tips aan docenten/beoordelaars e.d. En beschrijf wat je aan devops kennis, vaardigheden of andere zaken meeneemt naar je afstudeeropdracht of verdere loopbaan. 

CDMM INVULLEN VOOR PROJECT MET TOELICHTING

- Begin project was lastig om op te starten. Geen idee wat er moest gebeuren.
- Helaas bij begin weinig met Kubernetes & Rancher gedaan, handig geweest om dit vanaf begin af aan te doen.
  - Teamlid vroeg af wat het punt was. Kon ik op dat moment niet bedenken, maar richting het einde was het handig geweest om gewoon de kennis te hebben om een Kubernetes app te deployen op Rancher.
