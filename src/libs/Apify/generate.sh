install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://docs.apify.com/api/openapi.json
autosdk generate openapi.yaml \
  --namespace Apify \
  --clientClassName ApifyClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --auth-env-var APIFY_API_KEY \
  --generate-prediction-workflow-helpers \
  --exclude-deprecated-operations
