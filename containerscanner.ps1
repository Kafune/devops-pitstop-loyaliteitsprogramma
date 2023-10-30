
$imagesToScan = @(
    "pitstop/vehiclemanagementapi:1.0",
    "pitstop/workshopmanagementapi:1.0",
    "pitstop/auditlogservice:1.0",
    "pitstop/invoiceservice:1.0",
    "pitstop/notificationservice:1.0",
    "pitstop/timeservice:1.0",
    "pitstop/workshopmanagementeventhandler:1.0",
    "pitstop/webapp:1.0",
    "pitstop/customermanagementapi:2.0",
    "pitstop/apigateway:1.0"
)

function Scan-Image {
    param($image)
    $imageName = $image.Substring(8, $image.Length - 9)
    $rapport = "trivy-rapport.JSON"
    $TRIVY_REPORT = "$imageName"+$rapport
    Write-Output "Scannen van image: $image"
    trivy image -f json -o $rapport $image
}


foreach ($image in $imagesToScan){
    Write-Output "Pulling Docker image: $image"
    docker pull $image
    Scan-Image $image
}

