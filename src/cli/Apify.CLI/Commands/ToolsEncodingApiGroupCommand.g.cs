#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ToolsEncodingApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tools-encoding", @"Tools/Encoding endpoint commands.");
                         command.Subcommands.Add(ToolsEncodingToolsDecodeAndVerifyPostCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsEncodingToolsEncodeAndSignPostCommandApiCommand.Create());
        return command;
    }
}