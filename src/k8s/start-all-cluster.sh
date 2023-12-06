#!/bin/bash

# If started with argument --nomesh, the solution is started without service-mesh.
# If started with argument --istio, the solution is started with the Istio service-mesh.
# If started with argument --linkerd, the solution is started with the Linkerd service-mesh.

MESHPOSTFIX=''

if [ "$1" != "--nomesh" and  "$1" != "--istio" and "$1" != "--linkerd" ]
then
    echo "Error: You must specify how to start Pitstop:"
    echo "  start-all.ps1 < --nomesh | --istio | --linkerd >."
    exit 1
fi

if [ "$1" = "--nomesh" ]
then
    echo "Starting Pitstop without service mesh."
fi

if [ "$1" = "--istio" ]
then
    MESHPOSTFIX='-istio'

    echo "Starting Pitstop with Istio service mesh."

    # disable global istio side-car injection (only for annotated pods)
    ./disable-default-istio-injection.sh
fi

if [ "$1" = "--linkerd" ]
then
    MESHPOSTFIX='-linkerd'

    echo "Starting Pitstop with Linkerd service mesh."
fi

kubectl apply \
    -f ./pitstop-namespace$MESHPOSTFIX.yaml --kubeconfig=cg-4.yaml \
    -f ./ingress.yaml --kubeconfig=cg-4.yaml \
    -f ./rabbitmq.yaml --kubeconfig=cg-4.yaml \
    -f ./logserver.yaml --kubeconfig=cg-4.yaml \
    -f ./sqlserver.yaml --kubeconfig=cg-4.yaml \
    -f ./mailserver.yaml --kubeconfig=cg-4.yaml \
    -f ./invoiceservice.yaml --kubeconfig=cg-4.yaml \
    -f ./timeservice.yaml --kubeconfig=cg-4.yaml \
    -f ./notificationservice.yaml --kubeconfig=cg-4.yaml \
    -f ./workshopmanagementeventhandler.yaml --kubeconfig=cg-4.yaml \
    -f ./auditlogservice.yaml --kubeconfig=cg-4.yaml \
    -f ./customermanagementapi-v1$MESHPOSTFIX.yaml --kubeconfig=cg-4.yaml \
    -f ./customermanagementapi-svc.yaml --kubeconfig=cg-4.yaml \
    -f ./vehiclemanagementapi$MESHPOSTFIX.yaml --kubeconfig=cg-4.yaml \
    -f ./workshopmanagementapi$MESHPOSTFIX.yaml --kubeconfig=cg-4.yaml \
    -f ./webapp$MESHPOSTFIX.yaml --kubeconfig=cg-4.yaml \
    -f ./prometheus.yaml --kubeconfig=cg-4.yaml \
    -f ./node-exporter.yaml --kubeconfig=cg-4.yaml \
    -f ./grafana.yaml --kubeconfig=cg-4.yaml \
    -f ./influxdb.yaml --kubeconfig=cg-4.yaml

$SHELL
