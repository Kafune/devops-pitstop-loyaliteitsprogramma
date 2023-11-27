
## Containerscanning

Na het uitvoeren van het script (containerscanner.ps1) krijg je json terug waarin alle vulnerabilities instaan. Elke vulnerability heeft een titel, een uitleg, de referenties en een severity (low, critical, high etc.)
Een voorbeeld hiervan kun je hieronder zien.

```
   {
          "VulnerabilityID": "CVE-2011-4116",
          "PkgID": "perl-base@5.32.1-4+deb11u2",
          "PkgName": "perl-base",
          "InstalledVersion": "5.32.1-4+deb11u2",
          "Status": "affected",
          "Layer": {
            "DiffID": "sha256:10764c37bcbc8dff79bd134e34e5e8d9c6a3e0d482ca2e6e0ff978485ada5c3c"
          },
          "SeveritySource": "debian",
          "PrimaryURL": "https://avd.aquasec.com/nvd/cve-2011-4116",
          "DataSource": {
            "ID": "debian",
            "Name": "Debian Security Tracker",
            "URL": "https://salsa.debian.org/security-tracker-team/security-tracker"
          },
          "Title": "perl: File::Temp insecure temporary file handling",
          "Description": "_is_safe in the File::Temp module for Perl does not properly handle symlinks.",
          "Severity": "LOW",
          "CweIDs": [
            "CWE-59"
          ],
          "CVSS": {
            "nvd": {
              "V2Vector": "AV:N/AC:L/Au:N/C:N/I:P/A:N",
              "V3Vector": "CVSS:3.1/AV:N/AC:L/PR:N/UI:N/S:U/C:N/I:H/A:N",
              "V2Score": 5,
              "V3Score": 7.5
            },
            "redhat": {
              "V2Vector": "AV:L/AC:M/Au:N/C:N/I:P/A:N",
              "V2Score": 1.9
            }
          },
          "References": [
            "http://www.openwall.com/lists/oss-security/2011/11/04/2",
            "http://www.openwall.com/lists/oss-security/2011/11/04/4",
            "https://access.redhat.com/security/cve/CVE-2011-4116",
            "https://github.com/Perl-Toolchain-Gang/File-Temp/issues/14",
            "https://nvd.nist.gov/vuln/detail/CVE-2011-4116",
            "https://rt.cpan.org/Public/Bug/Display.html?id=69106",
            "https://seclists.org/oss-sec/2011/q4/238",
            "https://www.cve.org/CVERecord?id=CVE-2011-4116"
          ],
          "PublishedDate": "2020-01-31T18:15:00Z",
          "LastModifiedDate": "2020-02-05T22:10:00Z"
        },
```

De bestaande containers van pitstop hebben allemaal meer dan 100 vulnerabilities. Ook onze eigen loyaltysystem rapport heeft er een heleboel (meer dan 5000 lines aan vulnerabilities)


