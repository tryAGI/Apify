# Apify.CLI

Command-line interface for the Apify SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global Apify.CLI --prerelease
```

## Usage

```bash
apify --help
apify api --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
apify completion bash > /usr/local/etc/bash_completion.d/apify
apify completion zsh  > _apify   # then put it on your zsh fpath
apify completion fish > ~/.config/fish/completions/apify.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.