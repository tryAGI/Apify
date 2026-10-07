#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ScheduleListItemAction : global::System.IEquatable<ScheduleListItemAction>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleListItemActionRunActor? RunActor { get; init; }
#else
        public global::Apify.ScheduleListItemActionRunActor? RunActor { get; }
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
            out global::Apify.ScheduleListItemActionRunActor? value)
        {
            value = RunActor;
            return IsRunActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionRunActor PickRunActor() => RunActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleListItemActionRunActorTask? RunActorTask { get; init; }
#else
        public global::Apify.ScheduleListItemActionRunActorTask? RunActorTask { get; }
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
            out global::Apify.ScheduleListItemActionRunActorTask? value)
        {
            value = RunActorTask;
            return IsRunActorTask;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionRunActorTask PickRunActorTask() => RunActorTask is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunActorTask' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScheduleListItemAction(global::Apify.ScheduleListItemActionRunActor value) => new ScheduleListItemAction((global::Apify.ScheduleListItemActionRunActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ScheduleListItemActionRunActor?(ScheduleListItemAction @this) => @this.RunActor;

        /// <summary>
        ///
        /// </summary>
        public ScheduleListItemAction(global::Apify.ScheduleListItemActionRunActor? value)
        {
            RunActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScheduleListItemAction FromRunActor(global::Apify.ScheduleListItemActionRunActor? value) => new ScheduleListItemAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScheduleListItemAction(global::Apify.ScheduleListItemActionRunActorTask value) => new ScheduleListItemAction((global::Apify.ScheduleListItemActionRunActorTask?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ScheduleListItemActionRunActorTask?(ScheduleListItemAction @this) => @this.RunActorTask;

        /// <summary>
        ///
        /// </summary>
        public ScheduleListItemAction(global::Apify.ScheduleListItemActionRunActorTask? value)
        {
            RunActorTask = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScheduleListItemAction FromRunActorTask(global::Apify.ScheduleListItemActionRunActorTask? value) => new ScheduleListItemAction(value);

        /// <summary>
        ///
        /// </summary>
        public ScheduleListItemAction(
            global::Apify.ScheduleListItemActionDiscriminatorType? type,
            global::Apify.ScheduleListItemActionRunActor? runActor,
            global::Apify.ScheduleListItemActionRunActorTask? runActorTask
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
            global::System.Func<global::Apify.ScheduleListItemActionRunActor, TResult>? runActor = null,
            global::System.Func<global::Apify.ScheduleListItemActionRunActorTask, TResult>? runActorTask = null,
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
            global::System.Action<global::Apify.ScheduleListItemActionRunActor>? runActor = null,

            global::System.Action<global::Apify.ScheduleListItemActionRunActorTask>? runActorTask = null,
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
            global::System.Action<global::Apify.ScheduleListItemActionRunActor>? runActor = null,
            global::System.Action<global::Apify.ScheduleListItemActionRunActorTask>? runActorTask = null,
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
                typeof(global::Apify.ScheduleListItemActionRunActor),
                RunActorTask,
                typeof(global::Apify.ScheduleListItemActionRunActorTask),
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
        public bool Equals(ScheduleListItemAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleListItemActionRunActor?>.Default.Equals(RunActor, other.RunActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleListItemActionRunActorTask?>.Default.Equals(RunActorTask, other.RunActorTask)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ScheduleListItemAction obj1, ScheduleListItemAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScheduleListItemAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScheduleListItemAction obj1, ScheduleListItemAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScheduleListItemAction o && Equals(o);
        }
    }
}
