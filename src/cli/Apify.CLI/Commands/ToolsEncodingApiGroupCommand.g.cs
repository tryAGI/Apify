#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ToolsEncodingApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"tools-encoding", @"Tools/Encoding endpoint commands.");
                         command.Subcommands.Add(ToolsEncodingToolsDecodeAndVerifyPostCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsEncodingToolsEncodeAndSignPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}