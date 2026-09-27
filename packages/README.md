# Local development package

Wisej-4.4.1.4.nupkg was repacked from the extracted Wisej-4 4.1.4 NuGet cache on 2026-09-27. It contains the locally updated framework, including the new Northwind controls. It is an unsigned development package; the original package signature was removed because the payload changed. The package ID/version and license are preserved. Do not publish this replacement as an official NuGet release.

NuGet.Config maps Wisej-4 exclusively to this directory. Other dependencies use nuget.org. Commit the package and configuration together so Railway can restore them.
