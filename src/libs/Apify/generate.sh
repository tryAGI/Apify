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

# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}
install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection
rm -rf Generated
fetch_spec -o openapi.yaml https://docs.apify.com/api/openapi.json
autosdk generate openapi.yaml \
  --namespace Apify \
  --clientClassName ApifyClient \
  --targetFramework net10.0 \
  --output Generated \
  --reject-unknown-enum-values \
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
