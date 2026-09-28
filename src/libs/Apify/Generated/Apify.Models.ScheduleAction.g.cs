#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ScheduleAction : global::System.IEquatable<ScheduleAction>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleActionRunActor? RunActor { get; init; }
#else
        public global::Apify.ScheduleActionRunActor? RunActor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunActor))]
#endif
        public bool IsRunActor => RunActor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunActor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ScheduleActionRunActor? value)
        {
            value = RunActor;
            return IsRunActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionRunActor PickRunActor() => RunActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleActionRunActorTask? RunActorTask { get; init; }
#else
        public global::Apify.ScheduleActionRunActorTask? RunActorTask { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunActorTask))]
#endif
        public bool IsRunActorTask => RunActorTask != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunActorTask(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ScheduleActionRunActorTask? value)
        {
            value = RunActorTask;
            return IsRunActorTask;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionRunActorTask PickRunActorTask() => RunActorTask is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunActorTask' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScheduleAction(global::Apify.ScheduleActionRunActor value) => new ScheduleAction((global::Apify.ScheduleActionRunActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ScheduleActionRunActor?(ScheduleAction @this) => @this.RunActor;

        /// <summary>
        ///
        /// </summary>
        public ScheduleAction(global::Apify.ScheduleActionRunActor? value)
        {
            RunActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScheduleAction FromRunActor(global::Apify.ScheduleActionRunActor? value) => new ScheduleAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScheduleAction(global::Apify.ScheduleActionRunActorTask value) => new ScheduleAction((global::Apify.ScheduleActionRunActorTask?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ScheduleActionRunActorTask?(ScheduleAction @this) => @this.RunActorTask;

        /// <summary>
        ///
        /// </summary>
        public ScheduleAction(global::Apify.ScheduleActionRunActorTask? value)
        {
            RunActorTask = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScheduleAction FromRunActorTask(global::Apify.ScheduleActionRunActorTask? value) => new ScheduleAction(value);

        /// <summary>
        ///
        /// </summary>
        public ScheduleAction(
            global::Apify.ScheduleActionDiscriminatorType? type,
            global::Apify.ScheduleActionRunActor? runActor,
            global::Apify.ScheduleActionRunActorTask? runActorTask
            )
        {
            Type = type;

            RunActor = runActor;
            RunActorTask = runActorTask;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RunActorTask as object ??
            RunActor as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RunActor?.ToString() ??
            RunActorTask?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRunActor && !IsRunActorTask || !IsRunActor && IsRunActorTask;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ScheduleActionRunActor, TResult>? runActor = null,
            global::System.Func<global::Apify.ScheduleActionRunActorTask, TResult>? runActorTask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunActor is { } __value0 && runActor != null)
            {
                return runActor(__value0);
            }
            else if (RunActorTask is { } __value1 && runActorTask != null)
            {
                return runActorTask(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ScheduleActionRunActor>? runActor = null,

            global::System.Action<global::Apify.ScheduleActionRunActorTask>? runActorTask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunActor is { } __value0)
            {
                runActor?.Invoke(__value0);
            }
            else if (RunActorTask is { } __value1)
            {
                runActorTask?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.ScheduleActionRunActor>? runActor = null,
            global::System.Action<global::Apify.ScheduleActionRunActorTask>? runActorTask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunActor is { } __value0)
            {
                runActor?.Invoke(__value0);
            }
            else if (RunActorTask is { } __value1)
            {
                runActorTask?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunActor,
                typeof(global::Apify.ScheduleActionRunActor),
                RunActorTask,
                typeof(global::Apify.ScheduleActionRunActorTask),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ScheduleAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleActionRunActor?>.Default.Equals(RunActor, other.RunActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleActionRunActorTask?>.Default.Equals(RunActorTask, other.RunActorTask)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ScheduleAction obj1, ScheduleAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScheduleAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScheduleAction obj1, ScheduleAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScheduleAction o && Equals(o);
        }
    }
}
