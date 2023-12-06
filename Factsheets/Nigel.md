# Eigen bijdrage Nigel Peperkamp

Dit verslag behandelt mijn bijdrage aan het project in negen hoofdonderwerpen. Allereerst mijn rol in code- en platformontwikkeling, gevolgd door mijn inzet voor app-configuratie, containers en Kubernetes. Daarnaast mijn betrokkenheid bij versiebeheer, CI/CD-pipelines en monitoring. Ik heb onderzoek uitgevoerd en bijgedragen aan code-reviews en documentatie. Ook ben ik actief geweest in Agile-werkprocessen en communicatie. Tijdens het project heb ik veel geleerd en dit komt tot uiting in mijn conclusies en feedback. Deze onderwerpen bieden een compleet overzicht van mijn inzet en ervaringen.

## 1. Code/platform bijdrage

1. Components toegevoegd aan docker-compose en k8s: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/39)
    - In deze pull request heb ik Prometheus, Prometheus node exporter en grafana toegevoegd aan docker-compose en k8s config bestanden. Daarnaast de shell scripten gewijzigd zodat die de nieuwe configs ook meenemen.

2. Review code: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/35) 
    - Als de app wordt gestart is het voor onze metrics van belang dat er data (test) in de database zit. Zonder de testdata zou de metrics dan compleet leeg zijn. Deze pull request die ik heb gereviewd zorgt ervoor dat bij een migratie data in de database wordt toegevoegd.

3. Review code front-end: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/38)
    - Voor ons loyaliteitsprogamma moet er een front-end gemaakt worden. Hiervoor is deze pull request.
 
## 2. Bijdrage app configuratie/containers/kubernetes

1. Kubernetes en shell: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/39) 
    - Prometheus, Prometheus node exporter en grafana toegevoegd aan docker compose config
    - Prometheus, Prometheus node exporter en grafana toegevoegd aan kubernetes manifest
    - Shell scripts gewijzigd zodat de nieuwe onderdelen meegenomen worden

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

1. hardeware metrics en loyaliteitsprogamma metrics toegevoegd aan grafana: (Zie grafana dashboard)
2. Pipeline aangemaakt om shell script uit te voeren die kubernetes manifest bestanden op de cluster zet: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/59) 

## 4. Onderzoek

1. Prometheus met Slack integratie onderzoek uitgevoerd: [Onderzoek](https://github.com/hanaim-devops/blog-prometheus-slack-integratie)
 
## 5. Bijdrage code review/kwaliteit anderen en security

1. Wij hebben nuttig gebruik gemaakt van pull requesten die gereviewd zijn: [Pull requesten](https://github.com/hanaim-devops/pitstop-groep-d/pulls)
2. Pull request gereviewd met commentaar wat vervolgens aangewerkt is: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/31)
 
## 6. Bijdrage documentatie

1. System Context Diagram: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/31)
    - Hieraan heb ik meegedacht aan het opzetten van C4 model
    - Pull request reviewd met commentaar
2. Prometheus ADR geschreven: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/55)
3. Grafana ADR geschreven: [Pull request](https://github.com/hanaim-devops/pitstop-groep-d/pull/54)
 
## 7. Bijdrage Agile werken, groepsproces en communicatie opdrachtgever en soft skills

1. Voor dit (korte) project heb ik soort van het rol van teamleider op mij genomen. Hierin nam ik leiding in de meetings en overleggen.
2. Elke dag hadden wij de volgende meetings:
    * Daily stand-up
    * progressiemeeting voor de pauze
    * Einde werkdag meeting
3. gebruik gemaakt van issue systeem van Github. Hierbij heb ik issues aangemaakt en op closed gezet als de taak voltooid is.
  
## 8. Leerervaringen

Tijdens dit project ben ik in aanraking gekomen met een aantal technieken waarvan ik veel geleerd heb. Dit zijn de volgende:
* Kubernetes 
* Prometheus en Node exporter van Prometheus
* Grafana

## 9. Conclusie & feedback

Mijn bijdragen aan het project omvatten het configureren van Docker Compose en Kubernetes, het toevoegen van monitoringcomponenten, code review, en leiderschap als teamleider. Het project was een waardevolle leerervaring, waarbij we als team complexe technische uitdagingen hebben overwonnen. We hebben geleerd hoe belangrijk Agile werken en effectieve communicatie zijn voor projectefficiëntie. Dit project heeft mijn DevOps-vaardigheden verbeterd zeker in het gebied van Docker, Kubernetes, monitoring. Deze ervaring zal me goed van pas komen in toekomstige projecten en mijn algemene loopbaan in DevOps.
