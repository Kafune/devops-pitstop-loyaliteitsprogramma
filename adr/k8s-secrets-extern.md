# Kubernetes secrets via externe provider

## Status

Proposed

## Context

Er is een poging gedaan om Kubernetes secrets te implementeren via een externe provider. Externe providers voor secrets management in Kubernetes bieden een veilige en centrale oplossing voor het beheren van gevoelige informatie, zoals wachtwoorden en tokens, buiten het Kubernetes-cluster. Deze aanpak verbetert de beveiliging door geavanceerde beveiligingsfuncties te bieden, zoals encryptie en toegangscontrole, en maakt het mogelijk om credentials centraal te beheren. Het integreren van externe providers vereenvoudigt het inbrengen, wijzigen en verwijderen van secrets zonder directe interactie met de Kubernetes-configuratie, terwijl het tegelijkertijd helpt bij het handhaven van compliance door middel van audittrails en logging van toegang tot gevoelige informatie.

Voor deze opdracht is er de keuze gemaakt om HashiCorp vault te gebruiken. De reden hier achter is, omdat dit bij het opzoeken van een provider als een van de betere naar voren kwam.

Voor het proberen uitwerken van een oplossing met de HashiCorp Vault heb ik twee tutorials gevolgd ([HashiCorp](https://www.youtube.com/watch?v=VHtN41FhcgQ&t=615s&ab_channel=HashiCorp) en [KubeSimplify](https://www.youtube.com/watch?v=V40tXvvKh5Y)).

Bij het uitwerken van de oplossing van de HashiCorp tutorial kreeg ik niet de connectie werkend tussen de pitstop applicatie en de HashiCorp Vault. Nadat ik met deze uitwerking langer bezig was dan verwacht ben ik overgestapt naar een andere tutorial.

De tweede tutorial van KubeSimplify was een uitwerking met [HELM](https://helm.sh/) en [MiniKube](https://minikube.sigs.k8s.io/docs/). Bij het proberen uit te werken van deze implementatie werkte de k8s configuratie van de pitstop applicatie niet meer en was deze niet meer te draaien via de 'start-all.sh' commando. 

Na hier meerdere dagen aan te besteden was er ook de optie om de sercrets lokaal de implementeren in plaats van het te doen doormiddel van een externe provider.

## Decision

Secrets lokaal houden en niet laten hosten bij een externe provider.

## Consequences

De secrets worden minder goed beveiligd opgeslagen en staan in de zelfde repository als het project.