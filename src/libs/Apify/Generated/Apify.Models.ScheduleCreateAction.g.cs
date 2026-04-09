#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ScheduleCreateAction : global::System.IEquatable<ScheduleCreateAction>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleCreateActionRunActor? RunActor { get; init; }
#else
        public global::Apify.ScheduleCreateActionRunActor? RunActor { get; }
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
        public global::Apify.ScheduleCreateActionRunActorTask? RunActorTask { get; init; }
#else
        public global::Apify.ScheduleCreateActionRunActorTask? RunActorTask { get; }
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
        public static implicit operator ScheduleCreateAction(global::Apify.ScheduleCreateActionRunActor value) => new ScheduleCreateAction((global::Apify.ScheduleCreateActionRunActor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleCreateActionRunActor?(ScheduleCreateAction @this) => @this.RunActor;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleCreateAction(global::Apify.ScheduleCreateActionRunActor? value)
        {
            RunActor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleCreateAction(global::Apify.ScheduleCreateActionRunActorTask value) => new ScheduleCreateAction((global::Apify.ScheduleCreateActionRunActorTask?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleCreateActionRunActorTask?(ScheduleCreateAction @this) => @this.RunActorTask;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleCreateAction(global::Apify.ScheduleCreateActionRunActorTask? value)
        {
            RunActorTask = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ScheduleCreateAction(
            global::Apify.ScheduleCreateActionDiscriminatorType? type,
            global::Apify.ScheduleCreateActionRunActor? runActor,
            global::Apify.ScheduleCreateActionRunActorTask? runActorTask
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
            global::System.Func<global::Apify.ScheduleCreateActionRunActor?, TResult>? runActor = null,
            global::System.Func<global::Apify.ScheduleCreateActionRunActorTask?, TResult>? runActorTask = null,
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
            global::System.Action<global::Apify.ScheduleCreateActionRunActor?>? runActor = null,
            global::System.Action<global::Apify.ScheduleCreateActionRunActorTask?>? runActorTask = null,
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
                typeof(global::Apify.ScheduleCreateActionRunActor),
                RunActorTask,
                typeof(global::Apify.ScheduleCreateActionRunActorTask),
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
        public bool Equals(ScheduleCreateAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleCreateActionRunActor?>.Default.Equals(RunActor, other.RunActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleCreateActionRunActorTask?>.Default.Equals(RunActorTask, other.RunActorTask) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScheduleCreateAction obj1, ScheduleCreateAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScheduleCreateAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScheduleCreateAction obj1, ScheduleCreateAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScheduleCreateAction o && Equals(o);
        }
    }
}
