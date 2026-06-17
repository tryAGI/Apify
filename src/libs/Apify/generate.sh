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

rm -rf ../../cli/Apify.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Apify.CLI \
  --sdk-project ../../libs/Apify/Apify.csproj \
  --targetFramework net10.0 \
  --namespace Apify \
  --clientClassName ApifyClient \
  --package-id Apify.CLI \
  --tool-command-name apify \
  --user-secrets-id Apify.CLI \
  --api-key-env-var APIFY_API_KEY \
  --base-url-env-var APIFY_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
