#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class SchedulesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"schedules", @"Schedules endpoint commands.");
                         command.Subcommands.Add(SchedulesScheduleDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(SchedulesScheduleGetCommandApiCommand.Create());
                         command.Subcommands.Add(SchedulesScheduleLogGetCommandApiCommand.Create());
                         command.Subcommands.Add(SchedulesSchedulePutCommandApiCommand.Create());
                         command.Subcommands.Add(SchedulesSchedulesGetCommandApiCommand.Create());
                         command.Subcommands.Add(SchedulesSchedulesPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}