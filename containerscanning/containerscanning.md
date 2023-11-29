
## Containerscanning

Dit document is een uitbreiding op het onderzoek/blogpost "DevSecOps en containerscanning: De Brug tussen Snelheid en Veiligheid in Softwareontwikkeling" deze kan je hier vinden https://github.com/hanaim-devops/onderzoekWijnandvZyl


Na het uitvoeren van het script (containerscanner.ps1) krijg je json terug waarin alle vulnerabilities instaan. Elke vulnerability heeft een titel, een uitleg, de referenties en een severity (low, critical, high etc.)
Een voorbeeld hiervan kun je hieronder zien.

```  
        {
          "VulnerabilityID": "CVE-2023-36414",
          "PkgName": "Azure.Identity",
          "InstalledVersion": "1.7.0",
          "FixedVersion": "1.10.2",
          "Status": "fixed",
          "Layer": {
            "DiffID": "sha256:be344a242d5cad8f465c4afa4b573878342b1fa2e19bdf2e6e9980a029b3b521"
          },
          "SeveritySource": "ghsa",
          "PrimaryURL": "https://avd.aquasec.com/nvd/cve-2023-36414",
          "DataSource": {
            "ID": "ghsa",
            "Name": "GitHub Security Advisory NuGet",
            "URL": "https://github.com/advisories?query=type%3Areviewed+ecosystem%3Anuget"
          },
          "Title": "Azure Identity SDK Remote Code Execution Vulnerability",
          "Description": "Azure Identity SDK Remote Code Execution Vulnerability",
          "Severity": "HIGH",
          "CVSS": {
            "ghsa": {
              "V3Vector": "CVSS:3.1/AV:N/AC:L/PR:L/UI:N/S:U/C:H/I:H/A:H",
              "V3Score": 8.8
            },
            "nvd": {
              "V3Vector": "CVSS:3.1/AV:N/AC:L/PR:L/UI:N/S:U/C:H/I:H/A:H",
              "V3Score": 8.8
            }
          },
          "References": [
            "https://github.com/Azure/azure-sdk-for-net",
            "https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/identity/Azure.Identity/CHANGELOG.md#1102-2023-10-10",
            "https://msrc.microsoft.com/update-guide/vulnerability/CVE-2023-36414",
            "https://nvd.nist.gov/vuln/detail/CVE-2023-36414"
          ],
          "PublishedDate": "2023-10-10T18:15:00Z",
          "LastModifiedDate": "2023-10-13T17:11:00Z"
        }
      
```
Als je een vulnerabilities zoals deze wilt oplossen moet je kijken naar wat het probleem is. Daar kan je meer over lezen in de "references". In dit geval moeten we de versie updaten van azure identity van versie 1.7.0 naar 1.10.2 om het probleem op te lossen.

De bestaande containers van pitstop hebben allemaal meer dan 100 vulnerabilities. Ook onze eigen loyaltysystem rapport heeft er 112. Niet al van deze 112 kunnen opgelost worden. Dit kan je zien aan de status, bij het voorbeeld is die "fixed". dit houd in dat er een fix bestaat voor het probleem maar het kan net zo goed zijn "wil_not_fix". In dit geval kan je er niks aan doen om het op te lossen.




