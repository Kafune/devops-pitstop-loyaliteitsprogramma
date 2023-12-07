# Eigen bijdrage Nigel Peperkamp

Dit verslag behandelt mijn bijdrage aan het project in negen hoofdonderwerpen. Allereerst mijn rol in code- en platformontwikkeling, gevolgd door mijn inzet voor app-configuratie, containers en Kubernetes. Daarnaast mijn betrokkenheid bij versiebeheer, CI/CD-pipelines en monitoring. Ik heb onderzoek uitgevoerd en bijgedragen aan code-reviews en documentatie. Ook ben ik actief geweest in Agile-werkprocessen en communicatie. Tijdens het project heb ik veel geleerd en dit komt tot uiting in mijn conclusies en feedback. Deze onderwerpen bieden een compleet overzicht van mijn inzet en ervaringen.

## 1. Code/platform bijdrage

1. Frontend voor het loyalty program toegevoegd: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/38)

   - In deze pull request heb ik een nieuwe pagina heb toegevoegd aan de frontend. Deze pagina is voor het loyalty program waarop is het zien hoeveel punten iedere gebruiker heeft.

2. Review code: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/58)
   - In deze pull request heb ik de code van een Kachung gereviewd.

## 2. Bijdrage app configuratie/containers/kubernetes

1. Aanpassing in het docker compose bestand: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/commit/b7985bca59909358ec915af4f6cba79deb1659c4)
   - Grafana container aangepast zodat die automatisch de dashboard & datasources aanmaakt
   - De dashsources toegoevoegd in een yaml bestand zodat die gelezen kunnen worden door de grafana container
   - De dashboards toegevoegd in een json bestand zodat die gelezen kunnen worden door de grafana container

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

1. Hardware metrics en loyaliteitsprogamma metrics toegevoegd aan grafana: (Zie grafana dashboard)
2. Opzetten van cluster informatie in een influxDB dashboard: (Zie InfluxDB dashboard)

## 4. Onderzoek

1. InfluxDB onderzoek uitgevoerd: [Onderzoek](https://github.com/hanaim-devops/blogpost-tom-reith-influxDB)

## 5. Bijdrage code review/kwaliteit anderen en security

1. Ik heb een pull request gereviewd en vervolgend goedgekeurd: [Pull requesten](https://github.com/hanaim-devops/pitstop-groep-d/pull/56)

## 6. Bijdrage documentatie

1. System Context Diagram: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/31)
   - Hieraan heb ik diagrammen toegevoegd die de architectuur van het systeem weergeven.
2. InfluxDB ADR geschreven: [ADR influxDB](https://github.com/hanaim-devops/pitstop-groep-d/blob/main/adr/InfluxDB)

## 7. Bijdrage Agile werken, groepsproces en communicatie opdrachtgever en soft skills

1. Elke dag hadden wij de volgende meetings:
   - Daily stand-up
   - progressiemeeting voor de pauze
   - Einde werkdag meeting
2. Gebruiken van het issue board in github om de voortgang van het project bij te houden

## 8. Leerervaringen

Tijdens dit project ben ik in aanraking gekomen met een aantal technieken waarvan ik veel geleerd heb. Dit zijn de volgende:

- Docker
- Grafana, Prometheus en influxdb
- Kubernetes
- Config as code

## 9. Conclusie & feedback

Ik vond het een 'lastige' opdracht, dit kwam voornamelijk omdat we moeten werken aan een systeem wat is gebouwd en we helemaal zelf alles moeten uitzoeken. Zo hebben we met C# gewerkt waar we allemaal nog niet veel ervaring mee hadden en ook met de andere technieken hadden we nog niet veel ervaring. Dit was wel een goede leerervaring omdat we nu veel hebben geleerd over de technieken waar we mee hebben gewerkt. Iets wat ik leuk en leerzaam vond is het welken met configuratie as code, zoals het opzetten van de grafana datasource en dashboard met een yaml en json bestand zodat alles meteen bij het opstarten van de containers werkt. Uiteindelijk ben ik wel tevreden met het resultaat van het project maar het had zeker beter gekunt. 
