# Kubernetes secrets via externe provider

## Status

Proposed

## Context

Er is een poging gedaan om kubernetes secrets te bewaren in de HashiCorp Vault. Kubernetes Secrets bieden een manier om gevoelige informatie op te slaan binnen een Kubernetes-cluster, zoals wachtwoorden, tokens of certificaten. HashiCorp Vault integreert met Kubernetes om het beheer van deze geheimen te verbeteren. Door dit via een externe provider te doen biedt dit enkele voordelen zoals: centraal beheer van de secrets, audit mogelijkheden en integratie met Kubernetes-native workflows.



## Decision

Secrets lokaal houden en niet laten hosten bij een externe provider.


