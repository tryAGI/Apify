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
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleActionShortScheduleActionShortRunActor? RunActor { get; init; }
#else
        public global::Apify.ScheduleActionShortScheduleActionShortRunActor? RunActor { get; }
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
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorTask? RunActorTask { get; init; }
#else
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorTask? RunActorTask { get; }
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
        public static implicit operator ScheduleActionShort(global::Apify.ScheduleActionShortScheduleActionShortRunActor value) => new ScheduleActionShort((global::Apify.ScheduleActionShortScheduleActionShortRunActor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleActionShortScheduleActionShortRunActor?(ScheduleActionShort @this) => @this.RunActor;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleActionShort(global::Apify.ScheduleActionShortScheduleActionShortRunActor? value)
        {
            RunActor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleActionShort(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask value) => new ScheduleActionShort((global::Apify.ScheduleActionShortScheduleActionShortRunActorTask?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleActionShortScheduleActionShortRunActorTask?(ScheduleActionShort @this) => @this.RunActorTask;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleActionShort(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask? value)
        {
            RunActorTask = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ScheduleActionShort(
            global::Apify.ScheduleActionShortScheduleActionShortRunActor? runActor,
            global::Apify.ScheduleActionShortScheduleActionShortRunActorTask? runActorTask
            )
        {
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
            global::System.Func<global::Apify.ScheduleActionShortScheduleActionShortRunActor?, TResult>? runActor = null,
            global::System.Func<global::Apify.ScheduleActionShortScheduleActionShortRunActorTask?, TResult>? runActorTask = null,
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
            global::System.Action<global::Apify.ScheduleActionShortScheduleActionShortRunActor?>? runActor = null,
            global::System.Action<global::Apify.ScheduleActionShortScheduleActionShortRunActorTask?>? runActorTask = null,
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
                typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActor),
                RunActorTask,
                typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask),
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
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleActionShortScheduleActionShortRunActor?>.Default.Equals(RunActor, other.RunActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleActionShortScheduleActionShortRunActorTask?>.Default.Equals(RunActorTask, other.RunActorTask) 
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
