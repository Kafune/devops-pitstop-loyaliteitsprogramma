# Eigen bijdrage Nigel Peperkamp

Dit verslag behandelt mijn bijdrage aan het project in negen hoofdonderwerpen. Allereerst mijn rol in code- en platformontwikkeling, gevolgd door mijn inzet voor app-configuratie, containers en Kubernetes. Daarnaast mijn betrokkenheid bij versiebeheer, CI/CD-pipelines en monitoring. Ik heb onderzoek uitgevoerd en bijgedragen aan code-reviews en documentatie. Ook ben ik actief geweest in Agile-werkprocessen en communicatie. Tijdens het project heb ik veel geleerd en dit komt tot uiting in mijn conclusies en feedback. Deze onderwerpen bieden een compleet overzicht van mijn inzet en ervaringen.

## 1. Code/platform bijdrage

1. Components toegevoegd aan docker-compose en k8s: https://github.com/hanaim-devops/pitstop-groep-d/pull/39: In deze pull request heb ik Prometheus, Prometheus node exporter en grafana toegevoegd aan docker-compose en k8s config bestanden. Daarnaast de shell scripten gewijzigd zodat die de nieuwe configs ook meenemen.

2. Review code: https://github.com/hanaim-devops/pitstop-groep-d/pull/35: Als de app wordt gestart is het voor onze metrics van belang dat er data (test) in de database zit. Zonder de testdata zou de metrics dan compleet leeg zijn. Deze pull request die ik heb gereviewd zorgt ervoor dat bij een migratie data in de database wordt toegevoegd.

3. Review code front-end: https://github.com/hanaim-devops/pitstop-groep-d/pull/38: Voor ons loyaliteitsprogamma moet er een front-end gemaakt worden. Hiervoor is deze pull request.
 
## 2. Bijdrage app configuratie/containers/kubernetes

1. Components toegevoegd aan docker-compose en k8s: https://github.com/hanaim-devops/pitstop-groep-d/pull/39: Hierin heb ik onderandere gewerkt aan config files om Prometheus, Prometheus node exporter en grafana toegevoegd aan docker-compose en k8s. Daarnaast de shell scripten gewijzigd zodat die de nieuwe configs ook meenemen.

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

1. hardeware metrics en loyaliteitsprogamma metrics toegevoegd aan grafana.
2. Juist gebruik maken van git doormiddel van principes (Feature branches gebruiken en pull requesten).

## 4. Onderzoek

1. Prometheus integratie met Slack onderzoek uitgevoerd: https://github.com/hanaim-devops/blog-prometheus-slack-integratie: Hierin heb ik onderzoek uitgevoerd naar Prometheus integratie met Slack.
 
## 5. Bijdrage code review/kwaliteit anderen en security

1. Dit is ook bij het eerste kopje behandeld maar zoals daar ook te zien is heb ik deelgenomen aan nuttige review sessies van pull requesten: https://github.com/hanaim-devops/pitstop-groep-d/pulls
 
## 6. Bijdrage documentatie

1. System Context Diagram pull request review: https://github.com/hanaim-devops/pitstop-groep-d/pull/31: Hierin heb ik een documentatie stuk gerevieuwd van het c4 model.
 
## 7. Bijdrage Agile werken, groepsproces en communicatie opdrachtgever en soft skills

1. Voor dit kleine project heb ik soort van het rol van teamleider op mij genomen. Hierin nam ik leiding in de meetings en overleggen.
2. Elke dag hadden wij de volgende meetings:
    * Daily stand-up
    * progressiemeeting voor de pauze
    * Einde werkdag meeting
  
## 8. Leerervaringen

Tijdens dit project ben ik in aanraking gekomen met een aantal technieken waarvan ik veel geleerd heb. Dit zijn de volgende:
* Kubernetes
* Prometheus en Node exporter ervan
* Grafana

## 9. Conclusie & feedback

Mijn bijdragen aan het project omvatten het configureren van Docker Compose en Kubernetes, het toevoegen van monitoringcomponenten, code review, en leiderschap als teamleider. Het project was een waardevolle leerervaring, waarbij we als team complexe technische uitdagingen hebben overwonnen. We hebben geleerd hoe belangrijk Agile werken en effectieve communicatie zijn voor projectefficiëntie. Dit project heeft mijn DevOps-vaardigheden verbeterd zeker in het gebied van Docker, Kubernetes, monitoring. Deze ervaring zal me goed van pas komen in toekomstige projecten en mijn algemene loopbaan in DevOps.
