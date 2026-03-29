dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.apify.com/api/openapi.json
autosdk generate openapi.yaml \
  --namespace Apify \
  --clientClassName ApifyClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
