# Kubernetes pipelines met Tekton

## Status

Accepted

## Context

Er is een poging gedaan om [Tekton](https://github.com/hanaim-devops/blog-kachung-tekton) te implementeren in Kubernetes dat een onderzoeksonderwerp is binnen de Devops minor. Met Tekton is het mogelijk om pipelines te gebruiken in Kubernetes. Het idee hierbij is om met [triggers](https://tekton.dev/docs/triggers/) de docker image van het loyaliteitssysteem te bouwen en te pushen naar de Docker registry met [Kaniko](https://hub.tekton.dev/tekton/task/kaniko) als er een event van git plaatsvindt. De trigger zou nog geconfigureerd moeten worden zodat het alleen afgaat als er een verandering binnen het loyaliteitssyteem plaatsvindt. Voor deze taken zijn er Git en Docker credentials nodig zodat de pipeline de gegevens van de Git repo

Bij een CI/CD zoals Gitlab of Github Actions zit de pipeline standaard in de git repository ingebouwd. Voor Gitlab moet er specifiek een omgeving staan waar de Runner in kan draaien. Met Tekton kunnen we de repository pullen en opslaan binnen een [workspace](https://tekton.dev/docs/pipelines/workspaces/). Zo kunnen andere taken gebruik maken van de opgehaalde Git repository. Hierbij is er gebruik gemaakt van SSH credentials om te kijken hoe [Kubernetes Secrets](https://kubernetes.io/docs/concepts/configuration/secret/#ssh-authentication-secrets) in elkaar zit, en een [git-clone task](https://hub.tekton.dev/tekton/task/git-clone) die van tevoren gemaakt is.

Het configureren van Git en Docker credentials heeft veel tijd gekost, waarvan de Docker credentials waarschijnlijk gelukt is. De foutmelding geeft dit niet helemaal helder terug.

Doordat het veel tijd kostte, is het niet mogelijk om een image te bouwen via Tekton. Het was de tijd niet meer waard om verder uit te zoeken waarom Tekton niet meer werkt.

In plaats daarvan, maken we nu gebruik van Github Actions om de image van het loyaliteitssysteem te pushen naar de Github Registry. Dit is uiteindelijk [wel gelukt](https://github.com/hanaim-devops/pitstop-groep-d/actions/runs/7005164272).

## Decision

Schrappen van Tekton CI/CD voor het pitstop project wegens beperkte tijd. Het deployment via pipelines vervangen door Github Actions.

## Consequences

Na elke PR naar de main, bouwt en pusht de Github actions pipeline een nieuwe image van het loyaliteitssysteem naar de Github Registry. Hierdoor blijft de image binnen de Github registry constant up-to-date, waardoor Kubernetes deze image weer kan ophalen. Het nadeel is dat de base-images ook op de Github registry moeten staan wegens rechten om de afhaneklijke images te pullen. Hierdoor moet elke developer die met Docker & Kubernetes werkt, zich authenticeren voor [de Github Registry](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-container-registry#authenticating-with-a-personal-access-token-classic).
