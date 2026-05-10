#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ScheduleActionShort : global::System.IEquatable<ScheduleActionShort>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleActionShortRunActor? RunActor { get; init; }
#else
        public global::Apify.ScheduleActionShortRunActor? RunActor { get; }
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
            out global::Apify.ScheduleActionShortRunActor? value)
        {
            value = RunActor;
            return IsRunActor;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleActionShortRunActorTask? RunActorTask { get; init; }
#else
        public global::Apify.ScheduleActionShortRunActorTask? RunActorTask { get; }
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
            out global::Apify.ScheduleActionShortRunActorTask? value)
        {
            value = RunActorTask;
            return IsRunActorTask;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleActionShort(global::Apify.ScheduleActionShortRunActor value) => new ScheduleActionShort((global::Apify.ScheduleActionShortRunActor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleActionShortRunActor?(ScheduleActionShort @this) => @this.RunActor;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleActionShort(global::Apify.ScheduleActionShortRunActor? value)
        {
            RunActor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScheduleActionShort FromRunActor(global::Apify.ScheduleActionShortRunActor? value) => new ScheduleActionShort(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleActionShort(global::Apify.ScheduleActionShortRunActorTask value) => new ScheduleActionShort((global::Apify.ScheduleActionShortRunActorTask?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleActionShortRunActorTask?(ScheduleActionShort @this) => @this.RunActorTask;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleActionShort(global::Apify.ScheduleActionShortRunActorTask? value)
        {
            RunActorTask = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScheduleActionShort FromRunActorTask(global::Apify.ScheduleActionShortRunActorTask? value) => new ScheduleActionShort(value);

        /// <summary>
        /// 
        /// </summary>
        public ScheduleActionShort(
            global::Apify.ScheduleActionShortDiscriminatorType? type,
            global::Apify.ScheduleActionShortRunActor? runActor,
            global::Apify.ScheduleActionShortRunActorTask? runActorTask
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
            global::System.Func<global::Apify.ScheduleActionShortRunActor, TResult>? runActor = null,
            global::System.Func<global::Apify.ScheduleActionShortRunActorTask, TResult>? runActorTask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunActor && runActor != null)
            {
                return runActor(RunActor!);
            }
            else if (IsRunActorTask && runActorTask != null)
            {
                return runActorTask(RunActorTask!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ScheduleActionShortRunActor>? runActor = null,

            global::System.Action<global::Apify.ScheduleActionShortRunActorTask>? runActorTask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunActor)
            {
                runActor?.Invoke(RunActor!);
            }
            else if (IsRunActorTask)
            {
                runActorTask?.Invoke(RunActorTask!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.ScheduleActionShortRunActor>? runActor = null,
            global::System.Action<global::Apify.ScheduleActionShortRunActorTask>? runActorTask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunActor)
            {
                runActor?.Invoke(RunActor!);
            }
            else if (IsRunActorTask)
            {
                runActorTask?.Invoke(RunActorTask!);
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
                typeof(global::Apify.ScheduleActionShortRunActor),
                RunActorTask,
                typeof(global::Apify.ScheduleActionShortRunActorTask),
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
        public bool Equals(ScheduleActionShort other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleActionShortRunActor?>.Default.Equals(RunActor, other.RunActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleActionShortRunActorTask?>.Default.Equals(RunActorTask, other.RunActorTask) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScheduleActionShort obj1, ScheduleActionShort obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScheduleActionShort>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScheduleActionShort obj1, ScheduleActionShort obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScheduleActionShort o && Equals(o);
        }
    }
}
