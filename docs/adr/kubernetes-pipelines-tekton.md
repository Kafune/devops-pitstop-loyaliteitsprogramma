# Kubernetes pipelines met Tekton

## Status

Proposed

## Context

What is the issue that we're seeing that is motivating this decision or change?

Er is een poging gedaan om [Tekton](https://github.com/hanaim-devops/blog-kachung-tekton) te implementeren in Kubernetes dat een onderzoeksonderwerp is binnen de Devops minor. Met Tekton is het mogelijk om pipelines te gebruiken in Kubernetes. Het idee hierbij is om met [triggers](https://tekton.dev/docs/triggers/) de docker image van het loyaliteitssysteem te bouwen en te pushen naar de Docker registry met [Kaniko](https://hub.tekton.dev/tekton/task/kaniko) als er een event van git plaatsvindt. De trigger zou nog geconfigureerd moeten worden zodat het alleen afgaat als er een verandering binnen het loyaliteitssyteem plaatsvindt.

Bij een CI/CD zoals Gitlab of Github Actions zit de pipeline standaard in de git repository ingebouwd. Voor Gitlab moet er specifiek een omgeving staan waar de Runner in kan draaien. Met Tekton kunnen we de repository pullen en opslaan binnen een [workspace](https://tekton.dev/docs/pipelines/workspaces/). Zo kunnen andere taken gebruik maken van de opgehaalde Git repository. Hierbij is er gebruik gemaakt van SSH credentials om te kijken hoe [Kubernetes Secrets](https://kubernetes.io/docs/concepts/configuration/secret/#ssh-authentication-secrets) in elkaar zit, en een [git-clone task](https://hub.tekton.dev/tekton/task/git-clone) die van tevoren gemaakt is.

Het was lastig geweest om de SSH-sleutels in te stellen, omdat het vaak fouten teruggaf wat uiteindelijk weinig met de configuratie hiervan te maken had. Dit was lastig om terug te vinden in de foutmelden. Uiteindelijk bleek het dat de Git-clone task niet in versie 0.9 werkte, dus deze moest terug naar versie 0.6.

## Decision

What is the change that we're proposing and/or doing?

Schrappen van Tekton CI/CD voor het pitstop project wegens beperkte tijd.

## Consequences

What becomes easier or more difficult to do because of this change?

Waarschijnlijk moeten we na elke verandering binnen het loyaliteitsysteem de Docker image elke keer pushen naar de Docker registry, tenzij er met lokale images wordt gewerkt.
